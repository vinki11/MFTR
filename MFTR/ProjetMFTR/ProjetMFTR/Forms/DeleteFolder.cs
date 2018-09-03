using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;
using ProjetMFTR.Resources;

namespace ProjetMFTR.Forms
{
	public partial class DeleteFolder : Form
	{
		#region Members

		//Liste de nos dossiers
		private DbSet<Entities.Dossier> m_Dossiers;

		#endregion Members

		#region Constructors

		/// <summary>
		/// Constructeur par défaut
		/// </summary>
		public DeleteFolder()
		{
			InitializeComponent();
			Initialize();
		}

		#endregion Constructors

		#region Methods

		/// <summary>
		/// Initialisation de notre bindingsource
		/// </summary>
		private void Initialize()
		{
			m_Dossiers = Connexion.Instance().Dossier;
			bsData.DataSource = m_Dossiers.Where(x => x.Ouverture.HasValue && x.Ouverture.Value.Year <= DateTime.Now.Year - 5).OrderByDescending(o => o.Ouverture.Value).ToList();

			lblFolderCount.Text = bsData.Count.ToString();

			cboFolders.DataSource = m_Dossiers.ToList();
			cboFolders.DisplayMember = ResourcesString.STR_Dossier_ID;
			cboFolders.ValueMember = ResourcesString.STR_Dossier_ID;
			cboFolders.SelectedValue = -1;
		}
		#endregion Methods

		#region Event Handlers

		/// <summary>
		/// Survient à la suppression des dossiers
		/// </summary>
		private void btnDeleteFolder_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Êtes-vous sur de vouloir effectuer la suppression des dossiers ?" + Environment.NewLine + "Cette action sera irréversible",
			ResourcesString.STR_TitleConfirmDelete,
			MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.No) { return; }

			//S'il y a une valeur dans le combobox, on priorise cette valeur
			if (cboFolders.SelectedValue != null)
			{
				var dossier = (Entities.Dossier)cboFolders.SelectedItem;
				if (dossier != null)
				{
					Connexion.Instance().Dossier.Remove(dossier);
					Connexion.Instance().SaveChanges();
				}
			}
			//Sinon on supprime avec la sélection de la grille
			else
			{
				foreach (DataGridViewRow row in gvList.SelectedRows)
				{
					var dossier = (Entities.Dossier)row.DataBoundItem;
					Connexion.Instance().Dossier.Remove(dossier);
					Connexion.Instance().SaveChanges();
				}
			}

			Initialize();
		}

		#endregion Event Handlers
	}
}