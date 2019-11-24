using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;

namespace ProjetMFTR.Forms
{
	public partial class Options : MetroFramework.Forms.MetroForm
	{
		public Options()
		{
			InitializeComponent();

			Entities.Options options = Connexion.Instance().Options.FirstOrDefault();
			txtPath.Text = options.Path;
			txtParentPrefix.Text = options.ParentPrefix;
			txtKidsPrefix.Text = options.KidsPrefix;
		}

		private void Options_FormClosed(object sender, FormClosedEventArgs e)
		{
			Entities.Options options = Connexion.Instance().Options.FirstOrDefault();
			options.Path = txtPath.Text;
			options.ParentPrefix = txtParentPrefix.Text;
			options.KidsPrefix = txtKidsPrefix.Text;
			Connexion.connexionActionsOptions.Update(options);
		}
	}
}