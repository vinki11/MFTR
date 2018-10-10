namespace ProjetMFTR.Forms
{
	partial class Options
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
			this.txtPath = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.txtParentPrefix = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.txtKidsPrefix = new MetroFramework.Controls.MetroTextBox();
			this.SuspendLayout();
			// 
			// txtPath
			// 
			// 
			// 
			// 
			this.txtPath.CustomButton.Image = null;
			this.txtPath.CustomButton.Location = new System.Drawing.Point(537, 1);
			this.txtPath.CustomButton.Name = "";
			this.txtPath.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPath.CustomButton.TabIndex = 1;
			this.txtPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPath.CustomButton.UseSelectable = true;
			this.txtPath.CustomButton.Visible = false;
			this.txtPath.Lines = new string[0];
			this.txtPath.Location = new System.Drawing.Point(156, 84);
			this.txtPath.MaxLength = 32767;
			this.txtPath.Name = "txtPath";
			this.txtPath.PasswordChar = '\0';
			this.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPath.SelectedText = "";
			this.txtPath.SelectionLength = 0;
			this.txtPath.SelectionStart = 0;
			this.txtPath.ShortcutsEnabled = true;
			this.txtPath.Size = new System.Drawing.Size(559, 23);
			this.txtPath.TabIndex = 0;
			this.txtPath.UseSelectable = true;
			this.txtPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(23, 88);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(89, 19);
			this.metroLabel1.TabIndex = 1;
			this.metroLabel1.Text = "Accès préféré";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(23, 132);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(84, 19);
			this.metroLabel2.TabIndex = 3;
			this.metroLabel2.Text = "Préfix parent";
			// 
			// txtParentPrefix
			// 
			// 
			// 
			// 
			this.txtParentPrefix.CustomButton.Image = null;
			this.txtParentPrefix.CustomButton.Location = new System.Drawing.Point(537, 1);
			this.txtParentPrefix.CustomButton.Name = "";
			this.txtParentPrefix.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtParentPrefix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtParentPrefix.CustomButton.TabIndex = 1;
			this.txtParentPrefix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtParentPrefix.CustomButton.UseSelectable = true;
			this.txtParentPrefix.CustomButton.Visible = false;
			this.txtParentPrefix.Lines = new string[0];
			this.txtParentPrefix.Location = new System.Drawing.Point(156, 128);
			this.txtParentPrefix.MaxLength = 32767;
			this.txtParentPrefix.Name = "txtParentPrefix";
			this.txtParentPrefix.PasswordChar = '\0';
			this.txtParentPrefix.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtParentPrefix.SelectedText = "";
			this.txtParentPrefix.SelectionLength = 0;
			this.txtParentPrefix.SelectionStart = 0;
			this.txtParentPrefix.ShortcutsEnabled = true;
			this.txtParentPrefix.Size = new System.Drawing.Size(559, 23);
			this.txtParentPrefix.TabIndex = 2;
			this.txtParentPrefix.UseSelectable = true;
			this.txtParentPrefix.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtParentPrefix.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(23, 170);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(82, 19);
			this.metroLabel3.TabIndex = 5;
			this.metroLabel3.Text = "Préfix enfant";
			// 
			// txtKidsPrefix
			// 
			// 
			// 
			// 
			this.txtKidsPrefix.CustomButton.Image = null;
			this.txtKidsPrefix.CustomButton.Location = new System.Drawing.Point(537, 1);
			this.txtKidsPrefix.CustomButton.Name = "";
			this.txtKidsPrefix.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtKidsPrefix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtKidsPrefix.CustomButton.TabIndex = 1;
			this.txtKidsPrefix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtKidsPrefix.CustomButton.UseSelectable = true;
			this.txtKidsPrefix.CustomButton.Visible = false;
			this.txtKidsPrefix.Lines = new string[0];
			this.txtKidsPrefix.Location = new System.Drawing.Point(156, 166);
			this.txtKidsPrefix.MaxLength = 32767;
			this.txtKidsPrefix.Name = "txtKidsPrefix";
			this.txtKidsPrefix.PasswordChar = '\0';
			this.txtKidsPrefix.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtKidsPrefix.SelectedText = "";
			this.txtKidsPrefix.SelectionLength = 0;
			this.txtKidsPrefix.SelectionStart = 0;
			this.txtKidsPrefix.ShortcutsEnabled = true;
			this.txtKidsPrefix.Size = new System.Drawing.Size(559, 23);
			this.txtKidsPrefix.TabIndex = 4;
			this.txtKidsPrefix.UseSelectable = true;
			this.txtKidsPrefix.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtKidsPrefix.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// Options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(738, 271);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.txtKidsPrefix);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.txtParentPrefix);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.txtPath);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Options";
			this.Text = "Options";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Options_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroTextBox txtPath;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroTextBox txtParentPrefix;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroTextBox txtKidsPrefix;
	}
}