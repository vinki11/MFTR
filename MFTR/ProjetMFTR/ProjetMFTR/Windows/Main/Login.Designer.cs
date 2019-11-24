namespace ProjetMFTR.Forms
{
	partial class Login
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.txtUsername = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.txtPassword = new MetroFramework.Controls.MetroTextBox();
			this.btnCancel = new MetroFramework.Controls.MetroButton();
			this.btnConnexion = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// txtUsername
			// 
			// 
			// 
			// 
			this.txtUsername.CustomButton.Image = null;
			this.txtUsername.CustomButton.Location = new System.Drawing.Point(232, 1);
			this.txtUsername.CustomButton.Name = "";
			this.txtUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtUsername.CustomButton.TabIndex = 1;
			this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtUsername.CustomButton.UseSelectable = true;
			this.txtUsername.CustomButton.Visible = false;
			this.txtUsername.Lines = new string[0];
			this.txtUsername.Location = new System.Drawing.Point(156, 84);
			this.txtUsername.MaxLength = 32767;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.PasswordChar = '\0';
			this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtUsername.SelectedText = "";
			this.txtUsername.SelectionLength = 0;
			this.txtUsername.SelectionStart = 0;
			this.txtUsername.ShortcutsEnabled = true;
			this.txtUsername.Size = new System.Drawing.Size(254, 23);
			this.txtUsername.TabIndex = 0;
			this.txtUsername.UseSelectable = true;
			this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(23, 88);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(109, 19);
			this.metroLabel1.TabIndex = 1;
			this.metroLabel1.Text = "Nom d\'utilisateur";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(23, 132);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(88, 19);
			this.metroLabel2.TabIndex = 3;
			this.metroLabel2.Text = "Mot de passe";
			// 
			// txtPassword
			// 
			// 
			// 
			// 
			this.txtPassword.CustomButton.Image = null;
			this.txtPassword.CustomButton.Location = new System.Drawing.Point(232, 1);
			this.txtPassword.CustomButton.Name = "";
			this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPassword.CustomButton.TabIndex = 1;
			this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPassword.CustomButton.UseSelectable = true;
			this.txtPassword.CustomButton.Visible = false;
			this.txtPassword.Lines = new string[0];
			this.txtPassword.Location = new System.Drawing.Point(156, 128);
			this.txtPassword.MaxLength = 32767;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '●';
			this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPassword.SelectedText = "";
			this.txtPassword.SelectionLength = 0;
			this.txtPassword.SelectionStart = 0;
			this.txtPassword.ShortcutsEnabled = true;
			this.txtPassword.Size = new System.Drawing.Size(254, 23);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.UseSelectable = true;
			this.txtPassword.UseSystemPasswordChar = true;
			this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Tomato;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(275, 187);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 33);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Annuler";
			this.btnCancel.UseCustomBackColor = true;
			this.btnCancel.UseSelectable = true;
			// 
			// btnConnexion
			// 
			this.btnConnexion.BackColor = System.Drawing.Color.PaleGreen;
			this.btnConnexion.Location = new System.Drawing.Point(381, 187);
			this.btnConnexion.Name = "btnConnexion";
			this.btnConnexion.Size = new System.Drawing.Size(75, 33);
			this.btnConnexion.TabIndex = 5;
			this.btnConnexion.Text = "Connexion";
			this.btnConnexion.UseCustomBackColor = true;
			this.btnConnexion.UseSelectable = true;
			this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
			// 
			// Login
			// 
			this.AcceptButton = this.btnConnexion;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(479, 233);
			this.Controls.Add(this.btnConnexion);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.txtUsername);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Login";
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Connexion";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroTextBox txtUsername;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroTextBox txtPassword;
		private MetroFramework.Controls.MetroButton btnCancel;
		private MetroFramework.Controls.MetroButton btnConnexion;
	}
}