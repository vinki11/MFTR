using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using ProjetMFTR.DataAccess;

namespace ProjetMFTR.Forms
{
	public partial class Login : MetroFramework.Forms.MetroForm
	{

		public bool ConnexionAccepted = false;

		public Login()
		{
			InitializeComponent();

		}

		private void btnConnexion_Click(object sender, EventArgs e)
		{
			if (txtUsername.Text.Trim() == "")
			{
				MessageBox.Show("Vous devez entrer un utilisateur");
				return;
			}

			if (txtPassword.Text.Trim() == "")
			{
				MessageBox.Show("Vous devez entrer un mot de passe");
				return;
			}

			var user = Connexion.Instance().Intervenant.FirstOrDefault(x => x.Username == txtUsername.Text);

			if (user == null)
			{
				MessageBox.Show($"L'utilisateur {txtUsername.Text} n'a pas été trouvé");
				AddAuthLog();
				return;
			}

			var password = Connexion.BCEngine.Encrypt(txtPassword.Text, Connexion.SecretKey);

			ConnexionAccepted = Equals(password, user.Password);

			if (!ConnexionAccepted)
			{
				MessageBox.Show("Mot de passe invalide");
				AddAuthLog();
				return;
			}

			Close();
		}


		private void AddAuthLog()
		{
			Entities.AuthentificationLog authentificationLog = new Entities.AuthentificationLog();

			authentificationLog.DateAuth = DateTime.Now;
			authentificationLog.UserAttempt = txtUsername.Text;
			authentificationLog.PassAttempt = txtPassword.Text;
			authentificationLog.SessionID = Dns.GetHostName();

			Connexion.connexionActionsAuthentificationLog.Add(authentificationLog);
		}
	}
}