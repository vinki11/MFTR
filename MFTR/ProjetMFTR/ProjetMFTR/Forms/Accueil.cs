using ProjetMFTR.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetMFTR
{
	public partial class Accueil : Form
	{

#region Constants
		private const string STR_Concatened = "concatened";
		private const string STR_Id = "id";
		#endregion

#region Constructors

		/// <summary>
		/// Constructeur de la classe
		/// </summary>
		public Accueil()
		{
			InitializeComponent();
			//Initialisation des combosbox
			InitialiseCombos();
		}

#endregion

#region Events

		/// <summary>
		/// Ajout d'un nouveau suivi
		/// </summary>
		private void btnAdd_Click(object sender, EventArgs e)
		{
			Suivi suivi = new Suivi();
			suivi.Show();
		}

		private void btnRecherche_Click(object sender, EventArgs e)
		{

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

		}

		private void btnGestion_Click(object sender, EventArgs e)
		{

		}
		#endregion

#region Methods

		/// <summary>
		/// Initialisation du combobox des enfants
		/// </summary>
		private void InitialiseCombos()
		{
			List<Kids> kids = new KidsDataAccess().GetKids();
			cboKid.DataSource = kids;
			cboKid.DisplayMember = STR_Concatened;
			cboKid.ValueMember = STR_Id;
		}
#endregion
    }
}
