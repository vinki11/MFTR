using ProjetMFTR.DataAccess;
using ProjetMFTR.DbConnexion.Helper;
using ProjetMFTR.Forms;
using ProjetMFTR.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetMFTR.Forms
{
	public partial class DossierNouveau : Form
	{
		#region Members

		Entities.Dossier CurrentDossier;
		EditMode editMode;
		Connexion.ConnexionActions<Entities.Dossier> connexionActions = new Connexion.ConnexionActions<Entities.Dossier>();

		private Parent m_NewParent;
		private Enfant m_NewEnfant;

		#endregion

		public DossierNouveau()
		{
			InitializeComponent();
			Init();
			//editMode = EditMode.New;
			nouveau();
		}

		public DossierNouveau(Entities.Dossier dossier) : this()
		{
			AssignFolder(dossier);
			editMode = EditMode.Edit;
			this.Text = "Modification d'un dossier";
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void rtxtRemarque_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnSaveAndQuit_Click(object sender, EventArgs e)
		{
			Save();
			Close();
		}

		private void Init()
		{
			listParents.Columns["Nom"].DataPropertyName = "Adultes.Nom";
			listParents.Columns["SubName"].DataPropertyName = "Adultes.Prenom";
		}

		/// <summary>
		/// Sauvegarde le dossier
		/// </summary>
		private Boolean Save()
		{
			//Valider si un dossier existe déja avec ce numéro si on est en mode ajout
			DialogResult result;
			if (CurrentDossier != null)
			{
				AssignValues();
				connexionActions.Update(CurrentDossier);
				result = MessageBox.Show(ResourcesString.STR_MessageUpdateConfirmation1 + "du dossier" + ResourcesString.STR_MessageUpdateConfirmation2,
				ResourcesString.STR_TitleUpdateConfirmation,
				MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}

			if (string.IsNullOrWhiteSpace(txtNoDossier.Text))
			{
				MessageBox.Show("Vous devez définir un numéro de dossier pour pouvoir ajouter le dossier",
				"Attention",
				MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			if (Connexion.Instance().Dossier.Any(x => x.Dossier_ID == txtNoDossier.Text))
			{
				MessageBox.Show("Le numéro de dossier doit être unique",
				"Erreur",
				MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			CurrentDossier = new Entities.Dossier();
			AssignValues();


			connexionActions.Add(CurrentDossier);
			result = MessageBox.Show("Le dossier " + CurrentDossier.Dossier_ID + ResourcesString.STR_MessageAddConfirmation,
							ResourcesString.STR_TitleAddConfirmation,
							MessageBoxButtons.OK, MessageBoxIcon.Information);

			return true;
		}

		private void AssignFolder(Entities.Dossier dossier)
		{
			txtNoDossier.Text = Connexion.Instance().Dossier.FirstOrDefault(x => x.Dossier_ID == dossier.Dossier_ID).Dossier_ID;
			cboType.Text = dossier.Type;
			dtpDateOuverture.Value = dossier.Ouverture.HasValue ? dossier.Ouverture.Value : DateTime.MinValue;

			rtxtRemarque.Text = dossier.Remarque;
			CurrentDossier = dossier;

			AssignDataSources();
		}

		private void AssignDataSources()
		{
			if (CurrentDossier == null) { return; }

			var kids = Connexion.Instance().Enfants.Where(x => x.Dossier_ID == CurrentDossier.Dossier_ID).OrderBy(o => o.Naissance).ToList();
			bsDataKids.DataSource = kids;

			var parents = CurrentDossier.Adultes.SelectMany(x => x.Parent).ToList();
			bsDataParents.DataSource = parents;
		}

		private void AssignValues()
		{
			CurrentDossier.Dossier_ID = txtNoDossier.Text;
			CurrentDossier.Ouverture = this.dtpDateOuverture.Value.Date;
			CurrentDossier.Remarque = this.rtxtRemarque.Text;
			CurrentDossier.Type = cboType.Text;
			CurrentDossier.Actif = "0";
		}

		private void btnSaveAndNew_Click(object sender, EventArgs e)
		{
			Save();
			nouveau();
		}

		private void nouveau()
		{
			this.Text = "Nouveau dossier";
			CurrentDossier = null;

			this.txtNoDossier.Text = "";
			this.dtpDateOuverture.Value = DateTime.Today;
			this.rtxtRemarque.Text = "";
			this.cboType.SelectedIndex = 0;
			editMode = EditMode.New;

		}

		private void btnAddParent_Click(object sender, EventArgs e)
		{
			m_NewParent = new Parent(this.txtNoDossier.Text);
			m_NewParent.FormClosing += new FormClosingEventHandler(UpdateDataSource);
			m_NewParent.ShowDialog();

		}

		private void btnAjouterEnfant_Click(object sender, EventArgs e)
		{
			if (txtNoDossier.Text.Count() != 0)
			{
				m_NewEnfant = new Enfant(txtNoDossier.Text);
				m_NewEnfant.ChildAdded += new EventHandler<Entities.Enfants>(ChildAdded);
				m_NewEnfant.ShowDialog();
			}

		}

		private void ChildAdded(object sender, Entities.Enfants e)
		{
			bsDataKids.Add(e);
		}
		/// <summary>
		/// Met à jour le datasource
		/// </summary>
		private void UpdateDataSource(object sender, EventArgs e)
		{
			Init();
			AssignDataSources();
		}


		private enum EditMode
		{
			New = 1,
			Edit = 2
		};

		private void listParents_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			try
			{
				if ((listParents.Rows[e.RowIndex].DataBoundItem != null) &&
								(listParents.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
				{
					e.Value = Helper.BindProperty(
												listParents.Rows[e.RowIndex].DataBoundItem,
												listParents.Columns[e.ColumnIndex].DataPropertyName
											);
				}
			}
			catch (Exception)
			{

				return;
			}

		}

		private void listEnfants_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = listEnfants.CurrentRow;
			m_NewEnfant = new Enfant((Entities.Enfants)row.DataBoundItem);
			m_NewEnfant.ShowDialog();
		}
	}
}
