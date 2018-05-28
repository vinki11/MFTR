using System;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ProjetMFTR.DbConnexion.Helper;

namespace ProjetMFTR.DataAccess
{
	//Classe ayant la connexion Entity Framework
	class Connexion
	{
		//Membres privés
		private static Entities.MFTR m_Instance;

		//Voir si on garde en singleton ou non (ne permet pas de refresh les instances et d'avoir du data à jour
		/// <summary>
		/// Retourne l'instance de la connexion
		/// </summary>
		public static Entities.MFTR Instance()
		{
			if (m_Instance == null)
			{
				m_Instance = new Entities.MFTR();
				string destinationFile = "C:\\MFTR";
				destinationFile = Path.Combine(destinationFile, "connexion.txt");

				if (File.Exists(destinationFile))
				{
					string[] lines = System.IO.File.ReadAllLines(destinationFile);
					m_Instance.Database.Connection.ConnectionString = lines[0];
				}
			}
			return m_Instance;
		}

		/// <summary>
		/// Classe partial pour update
		/// </summary>
		public partial class ConnexionActions<TEntity> : IActions<TEntity> where TEntity : class
		{
			TEntity currentEntity = null;
			PrintDocument pdoc = null;
			string strPrint = "";
			Entities.Suivi suivi;

			public bool Add(TEntity entity)
			{
				try
				{
					m_Instance.Entry(entity).State = System.Data.Entity.EntityState.Modified;
					m_Instance.Set<TEntity>().Add(entity);
					m_Instance.SaveChanges();
					return true;
				}
				catch (Exception e)
				{
					return false;
				}
			}

			public bool Update(TEntity entity)
			{
				try
				{
					m_Instance.Entry(entity).State = System.Data.Entity.EntityState.Modified;
					m_Instance.Entry(entity).OriginalValues.SetValues(entity);
					m_Instance.SaveChanges();
					return true;
				}
				catch (Exception e)
				{
					return false;
				}
			}


			public void Print(TEntity entity,PrintDialog pd)
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
			void pdoc_PrintPage(object sender, PrintPageEventArgs e)
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

		}
	}
}
