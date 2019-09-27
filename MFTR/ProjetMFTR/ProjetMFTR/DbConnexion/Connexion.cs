using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetMFTR.DbConnexion.Helper;

namespace ProjetMFTR.DataAccess
{
	//Classe ayant la connexion Entity Framework
	internal class Connexion
	{
		//Membres privés
		private static Entities.MFTR m_Instance;
		private static string ConnexionString;
		public static ConnexionActions<Entities.Dossier> connexionActions = new ConnexionActions<Entities.Dossier>();
		public static ConnexionActions<Entities.Adultes> connexionActionsAdultes = new ConnexionActions<Entities.Adultes>();
		public static ConnexionActions<Entities.Adresse> connexionActionsAdresse = new ConnexionActions<Entities.Adresse>();
		public static ConnexionActions<Entities.Parent> connexionActionsParent = new ConnexionActions<Entities.Parent>();
		public static ConnexionActions<Entities.Suivi> connexionActionsSuivi = new ConnexionActions<Entities.Suivi>();
		public static ConnexionActions<Entities.Transporteur> connexionActionsTransporteur = new ConnexionActions<Entities.Transporteur>();
		public static ConnexionActions<Entities.Intervenant> connexionActionsIntervenant = new ConnexionActions<Entities.Intervenant>();
		public static ConnexionActions<Entities.Enfants> connexionActionsEnfants = new ConnexionActions<Entities.Enfants>();
		public static ConnexionActions<Entities.Services> connexionActionsServices = new ConnexionActions<Entities.Services>();
		public static ConnexionActions<Entities.Referent> connexionActionsReferents = new ConnexionActions<Entities.Referent>();
		public static ConnexionActions<Entities.LienReferrent> connexionActionsLienReferrent = new ConnexionActions<Entities.LienReferrent>();
		public static ConnexionActions<Entities.Communication> connexionActionsCommunication = new ConnexionActions<Entities.Communication>();
		public static ConnexionActions<Entities.Telephone> connexionActionsTelephone = new ConnexionActions<Entities.Telephone>();
		public static ConnexionActions<Entities.Options> connexionActionsOptions = new ConnexionActions<Entities.Options>();

		//Voir si on garde en singleton ou non (ne permet pas de refresh les instances et d'avoir du data à jour
		/// <summary>
		/// Retourne l'instance de la connexion
		/// </summary>
		public static Entities.MFTR Instance()
		{
			if (m_Instance == null)
			{
				m_Instance = new Entities.MFTR();

				string destinationFile = @"C:\MFTR";
				destinationFile = Path.Combine(destinationFile, "connexion.txt");

				if (File.Exists(destinationFile))
				{
					string[] lines = File.ReadAllLines(destinationFile);
					m_Instance.Database.Connection.ConnectionString = lines[0];
					ConnexionString = lines[0];
					m_Instance.Configuration.LazyLoadingEnabled = true;
				}

			}

			return m_Instance;
		}


		/// <summary>
		/// Classe partial pour update
		/// </summary>
		public partial class ConnexionActions<TEntity> : IActions<TEntity> where TEntity : class
		{
			private TEntity currentEntity = null;
			private PrintDocument pdoc = null;
			private string strPrint = "";
			private Entities.Suivi suivi;

			public bool Add(TEntity entity)
			{
				try
				{
					Instance().Entry(entity).State = System.Data.Entity.EntityState.Modified;
					Instance().Set<TEntity>().Add(entity);
					Instance().SaveChanges();
					ObjectContextUpdater();
					return true;
				}
				catch (Exception e)
				{
					throw e;
				}
			}

			public void ObjectContextUpdater()
			{

				var context = ((IObjectContextAdapter)m_Instance);
				context.ObjectContext.Refresh(RefreshMode.StoreWins, m_Instance.Set<TEntity>().ToList());
			}


			public bool Update(TEntity entity)
			{
				try
				{
					Instance().Entry(entity).State = System.Data.Entity.EntityState.Modified;
					Instance().Entry(entity).OriginalValues.SetValues(entity);
					Instance().SaveChanges();
					ObjectContextUpdater();
					return true;
				}
				catch (Exception e)
				{
					throw e;
				}
			}

			public void Print(TEntity entity, PrintDialog pd)
			{
				if (entity == null) { return; }

				currentEntity = entity;

				if (ObjectContext.GetObjectType(currentEntity.GetType()) == typeof(Entities.Suivi))
				{
					suivi = (Entities.Suivi)(object)currentEntity;
					suivi = suivi as Entities.Suivi;
				}
				else
				{
					return;
				}

				pdoc = new PrintDocument();
				Font font = new Font("Arial", 15);
				pdoc.PrinterSettings = pd.PrinterSettings;
				pd.AllowPrintToFile = true;
				pd.AllowSomePages = true;
				pd.PrinterSettings.MinimumPage = 1;
				pd.PrinterSettings.FromPage = 1;

				PaperSize psize = new PaperSize("Custom", 110, 200);

				pd.Document = pdoc;
				pd.Document.DefaultPageSettings.PaperSize = psize;
				pdoc.DefaultPageSettings.PaperSize.Height = 1400;

				pdoc.DefaultPageSettings.PaperSize.Width = 805;
				pdoc.DefaultPageSettings.Margins = new Margins(200, 110, 0, 0);

				pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);

				strPrint = suivi.remarque;
				pdoc.Print();
			}

			private void pdoc_PrintPage(object sender, PrintPageEventArgs e)
			{
				if (suivi == null) { return; }

				Graphics graphics = e.Graphics;
				Font font = new Font("Arial", 12);
				SolidBrush brush = new SolidBrush(Color.Black);
				float fontHeight = font.GetHeight();
				int startX = 0;
				int startY = 55;
				int Offset = 40;

				if (suivi.remarque.Length.Equals(strPrint.Length))
				{
					graphics.DrawString("Impression du suivi", new Font("Arial", 18, FontStyle.Bold),
					brush, startX * 2, startY);
					Offset = Offset + 20;
					graphics.DrawString("Suivi :" + suivi.suivi_id,
					font,
					brush, startX, startY + Offset);
					Offset = Offset + 20;
					graphics.DrawString("Date du suivi :" + suivi.dateSuivi,
					font,
					brush, startX, startY + Offset);
					Offset = Offset + 20;
					graphics.DrawString("Dossier :" + suivi.dossier_id,
					font,
					brush, startX, startY + Offset);
					Offset = Offset + 20;
					graphics.DrawString("Enfant :" + Instance().Enfants.Where((x) => x.Enfant_ID.Equals(suivi.enfant_id)).FirstOrDefault().Name,
					font,
					brush, startX, startY + Offset);
					Offset = Offset + 20;
					graphics.DrawString("Intervenant :" + Instance().Intervenant.Where((x) => x.intervenant_id.Equals(suivi.intervenant_id)).FirstOrDefault().nom,
					font,
					brush, startX, startY + Offset);
					Offset = Offset + 20;
					graphics.DrawString("Moment :" + suivi.moment,
					font,
					brush, startX, startY + Offset);
					Offset = Offset + 20;

					e.Graphics.DrawString("Remarque :", font, Brushes.Black,
					 0, startY + Offset);
					Offset = Offset + 20;
				}

				int charCount = 0;
				int lineCount = 0;

				e.Graphics.MeasureString(strPrint, font,
								e.PageBounds.Size, StringFormat.GenericTypographic,
								out charCount, out lineCount);

				// Determine the page bound and draw the string accordingly
				e.Graphics.DrawString(strPrint, new Font("Arial", 10), Brushes.Black, new RectangleF(new PointF(0F, startY + Offset),
				new SizeF(e.PageBounds.Width - 50, e.PageBounds.Height)));

				// Now remove that part of the string that has been printed.
				strPrint = strPrint.Substring(charCount);

				// Check if any more pages left for printing
				if (strPrint.Length > 0)
					e.HasMorePages = true;
				else
					e.HasMorePages = false;
			}

			/// <summary>
			/// Permet de mettre à jour la clé primaire de dossier
			/// </summary>
			public void UpdateFolderIDs(string oldId, string newId)
			{
				using (SqlConnection conn = new SqlConnection(ConnexionString))
				{
					if (conn.State != ConnectionState.Open) { conn.Open(); }
					SqlTransaction transaction = conn.BeginTransaction();
					try
					{

						// 1.  create a command object identifying the stored procedure
						SqlCommand cmd = new SqlCommand("UpdateFolderIds", conn);

						// 2. set the command object so it knows to execute a stored procedure
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Transaction = transaction;
						// 3. add parameter to command, which will be passed to the stored procedure
						cmd.Parameters.Add(new SqlParameter("@OldId", oldId));
						cmd.Parameters.Add(new SqlParameter("@NewID", newId));

						cmd.ExecuteNonQuery();
						transaction.Commit();
					}
					catch (Exception e)
					{
						transaction.Rollback();
					}
				}
			}

			/// <summary>
			/// Permet de mettre à jour la clé primaire du dossier de la communication
			/// </summary>
			public void UpdateCommunicationFolderID(string oldId, string newId)
			{
				using (SqlConnection conn = new SqlConnection(ConnexionString))
				{
					if (conn.State != ConnectionState.Open) { conn.Open(); }

					SqlTransaction transaction = conn.BeginTransaction();

					try
					{
						transaction = conn.BeginTransaction();

						// 1.  create a command object identifying the stored procedure
						SqlCommand cmd = new SqlCommand("UpdateCommunicationFolderID", conn);
						cmd.Transaction = transaction;

						// 2. set the command object so it knows to execute a stored procedure
						cmd.CommandType = CommandType.StoredProcedure;

						// 3. add parameter to command, which will be passed to the stored procedure
						cmd.Parameters.Add(new SqlParameter("@OldId", oldId));
						cmd.Parameters.Add(new SqlParameter("@NewID", newId));

						cmd.ExecuteNonQuery();
						transaction.Commit();
					}
					catch (Exception e)
					{
						transaction.Rollback();
					}
				}
			}


			/// <summary>
			/// Permet de mettre à jour la clé primaire du referent
			/// </summary>
			public void UpdateReferentId(string oldId, string newId)
			{
				using (SqlConnection conn = new SqlConnection(ConnexionString))
				{
					if (conn.State != ConnectionState.Open) { conn.Open(); }

					SqlTransaction transaction = conn.BeginTransaction();

					try
					{

						// 1.  create a command object identifying the stored procedure
						SqlCommand cmd = new SqlCommand("UpdateReferentId", conn);
						cmd.Transaction = transaction;

						// 2. set the command object so it knows to execute a stored procedure
						cmd.CommandType = CommandType.StoredProcedure;

						// 3. add parameter to command, which will be passed to the stored procedure
						cmd.Parameters.Add(new SqlParameter("@OldId", oldId));
						cmd.Parameters.Add(new SqlParameter("@NewID", newId));

						cmd.ExecuteNonQuery();
						transaction.Commit();
					}
					catch (Exception e)
					{
						transaction.Rollback();
					}
				}
			}
		}
	}
}