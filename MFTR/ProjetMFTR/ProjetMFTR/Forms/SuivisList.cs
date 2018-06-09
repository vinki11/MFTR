using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.DbConnexion.Helper;
using ProjetMFTR.Forms;
using ProjetMFTR.Resources;

namespace ProjetMFTR
{
    public partial class SuivisList : Form
	{
		#region Members

		private Suivi m_Suivi;
		Connexion.ConnexionActions<Entities.Suivi> connexionActions = new Connexion.ConnexionActions<Entities.Suivi>();

		#endregion

		#region Constructors

		/// <summary>
		/// Constructeur de la classe
		/// </summary>
		public SuivisList()
		{
			//Thread thread = new Thread(new ThreadStart(Splash));
			//thread.Start();
			InitializeComponent();
			//Initialisation des combosbox
			Init();
			InitialiseCombos();
			//thread.Abort();
			//this.Focus();
		}

		#endregion

		#region Events

		/// <summary>
		/// Ajout d'un nouveau suivi
		/// </summary>
		private void btnAdd_Click(object sender, EventArgs e)
		{
			m_Suivi = new Suivi();
			m_Suivi.FormClosing += new FormClosingEventHandler(UpdateDataSource);
			m_Suivi.Show();
		}

		private void UpdateDataSource(object sender, EventArgs e)
		{
			Init();
		}

		private void btnRecherche_Click(object sender, EventArgs e)
		{
			string dossier = null;
			int? enfant = null,intervenant = null;
			List<Entities.Suivi> suivis = Connexion.Instance().Suivi.ToList();

			if (chkDate.Checked)
			{
				suivis = suivis.Where((x) => x.dateSuivi.Equals(dtpDate.Value.Date)).ToList();
			}

			if (cboFolders.SelectedValue != null)
			{
				dossier = ((Entities.Dossier)cboFolders.SelectedItem).Dossier_ID;
				suivis = suivis.Where((x) => x.dossier_id.Equals(dossier)).ToList();
			}

			if (cboKid.SelectedValue != null)
			{
				enfant = ((Entities.Enfants)cboKid.SelectedItem).Enfant_ID;
				suivis = suivis.Where((x) => x.enfant_id.Equals(enfant)).ToList();
			}

			if (cboEmployes.SelectedValue != null)
			{
				intervenant = ((Entities.Intervenant)cboEmployes.SelectedItem).intervenant_id;
				suivis = suivis.Where((x) => x.intervenant_id.Equals(intervenant)).ToList();
			}

			bsData.DataSource = null;
			bsData.DataSource = suivis.OrderBy( x => x.dateSuivi).ToList();
		}

		/// <summary>
		/// Supression de suivis
		/// </summary>
		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (gvList.SelectedRows.Count == 0 && gvList.CurrentRow == null) { return; }

			DialogResult result = MessageBox.Show(string.Format("Êtes-vous sur de vouloir supprimer {0} suivi(s) ?", gvList.SelectedRows.Count == 0 ? 1 : gvList.SelectedRows.Count),
			"Confirmation de suppression",
			MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (result.Equals(DialogResult.No)) { return; }

			DataGridViewSelectedRowCollection rows = gvList.SelectedRows;
			try
			{
			foreach (DataGridViewRow row in rows) { Connexion.Instance().Suivi.Remove((Entities.Suivi)row.DataBoundItem); }
			}
			catch(Exception ee)
			{
				Connexion.Instance().Dispose();
				return;
			}
			Connexion.Instance().SaveChanges();
			Init();
		}

		/// <summary>
		/// Impression des suivis
		/// </summary>
		private void btnPrint_Click(object sender, EventArgs e)
		{
			if (gvList.SelectedRows.Count == 0 && gvList.CurrentRow == null) { return; }

			DataGridViewSelectedRowCollection rows = gvList.SelectedRows;
			PrintDialog pd = new PrintDialog();

			List<Entities.Suivi> suivis = new List<Entities.Suivi>();
			DialogResult result = pd.ShowDialog();

			if (result != DialogResult.OK) { return; }

			foreach (DataGridViewRow row in rows)
			{
			Entities.Suivi s = (Entities.Suivi)row.DataBoundItem;
			suivis.Add(s);
			}

			foreach(Entities.Suivi s in suivis.OrderBy(f => f.dateSuivi))
			{
				connexionActions.Print(s, pd);
			}
		}

		// Tests d'impression avec libraries

		//private void print()
		//{
		//	PdfSharp.Pdf.PdfDocument pdf = new PdfSharp.Pdf.PdfDocument();
		//	pdf.Info.Title = "My First PDF";
		//	PdfSharp.Pdf.PdfPage pdfPage = pdf.AddPage();
		//	XGraphics graph = XGraphics.FromPdfPage(pdfPage);
		//	XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
		//	graph.DrawString("This is my first PDF document", font, XBrushes.Black, new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center);
		//	string pdfFilename = "firstpage.pdf";
		//	pdf.Save(pdfFilename);

		//	////Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();
		//	//Spire.Pdf.PdfDocument pdf = new Spire.Pdf.PdfDocument(PdfConformanceLevel.Pdf_A1A);

		//	//PdfPageBase page = pdf.Pages.Add(PdfPageSize.A4);
		//	//page.Canvas.DrawString("Hello World, test PDF/A-1a!", new PdfTrueTypeFont(new System.Drawing.Font("Arial", 20f), true), PdfBrushes.Red, new Point(10, 15));
		//	////doc.LoadFromStream("sample.pdf");
		//	//pdf.Print();
		//	////Use the default printer to print all the pages
		//	////doc.PrintDocument.Print();

		//	//Set the printer and select the pages you want to print

		//	Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();
		//	doc.LoadFromFile(pdfFilename);

		//	PrintDialog dialogPrint = new PrintDialog();
		//	dialogPrint.AllowPrintToFile = true;
		//	dialogPrint.AllowSomePages = true;
		//	dialogPrint.PrinterSettings.MinimumPage = 1;
		//	dialogPrint.PrinterSettings.MaximumPage = doc.Pages.Count;
		//	dialogPrint.PrinterSettings.FromPage = 1;
		//	dialogPrint.PrinterSettings.ToPage = doc.Pages.Count;

		//	if (dialogPrint.ShowDialog() == DialogResult.OK)
		//	{
		//		doc.PrintFromPage = dialogPrint.PrinterSettings.FromPage;
		//		doc.PrintToPage = dialogPrint.PrinterSettings.ToPage;
		//		doc.PrinterName = dialogPrint.PrinterSettings.PrinterName;

		//		PrintDocument printDoc = new PrintDocument();
		//		dialogPrint.Document = printDoc;
		//		printDoc.Print();
		//	}

		//}
		/// <summary>
		/// Survient au formatage des cellules
		/// </summary>
		private void gvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if ((gvList.Rows[e.RowIndex].DataBoundItem != null) &&
		 (gvList.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
			{
				e.Value = Helper.BindProperty(
											gvList.Rows[e.RowIndex].DataBoundItem,
											gvList.Columns[e.ColumnIndex].DataPropertyName
										);
			}
		}


		/// <summary>
		/// Sur le double click sur une row
		/// </summary>
		private void gvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = gvList.CurrentRow;
			m_Suivi = new Suivi((Entities.Suivi)row.DataBoundItem);
			m_Suivi.SuiviAdded += new EventHandler(UpdateDataSource);
			m_Suivi.Show();
		}

		private void chkDate_CheckedChanged(object sender, EventArgs e)
		{
			dtpDate.Enabled = chkDate.Checked;
		}


		private void btnClearFilters_Click(object sender, EventArgs e)
		{
			chkDate.Checked = false;
			cboEmployes.SelectedValue = -1;
			cboFolders.SelectedValue = -1;
			cboKid.SelectedValue = -1;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Initialisation de la grille des suivis
		/// </summary>
		private void Init()
		{
			bsData.DataSource = Connexion.Instance().Suivi.OrderBy((x) => x.dateSuivi).ToList();
			gvList.Columns["Dossier"].DataPropertyName = "Dossier.Dossier_ID";
			gvList.Columns["Enfant"].DataPropertyName = "Enfants.Name";
			gvList.Columns["Intervenant"].DataPropertyName = "Intervenant.nom";

		}

		/// <summary>
		/// Initialisation du combobox des enfants
		/// </summary>
		private void InitialiseCombos()
		{
			cboKid.DataSource = Connexion.Instance().Enfants.ToList();
			cboKid.DisplayMember = ResourcesString.STR_Name;
			cboKid.ValueMember = ResourcesString.STR_EnfantId;
			cboKid.SelectedValue = -1;

			cboFolders.DataSource = Connexion.Instance().Dossier.ToList();
			cboFolders.DisplayMember = ResourcesString.STR_Dossier_ID;
			cboFolders.ValueMember = ResourcesString.STR_Dossier_ID;
			cboFolders.SelectedValue = -1;

			cboEmployes.DataSource = Connexion.Instance().Intervenant.ToList();
			cboEmployes.DisplayMember = ResourcesString.STR_Nom;
			cboEmployes.ValueMember = ResourcesString.STR_IntervenantId;
			cboEmployes.SelectedValue = -1;
		}
		#endregion

	}
}
