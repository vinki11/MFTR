namespace ProjetMFTR.Forms
{
	partial class Accueil
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
			this.label1 = new System.Windows.Forms.Label();
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.btnCommunication = new System.Windows.Forms.Button();
			this.btnGestionIntervenant = new System.Windows.Forms.Button();
			this.btnGestionDossier = new System.Windows.Forms.Button();
			this.btnGestionSuivi = new System.Windows.Forms.Button();
			this.btnOptions = new System.Windows.Forms.Button();
			this.lblVersion = new System.Windows.Forms.Label();
			this.btnPassage = new MetroFramework.Controls.MetroButton();
			this.btnPayment = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(224, 582);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(276, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Maison de la famille de Trois-Rivières inc, 2019";
			// 
			// metroPanel1
			// 
			this.metroPanel1.BackgroundImage = global::ProjetMFTR.Properties.Resources.icone_MFTR_ACCUEIL;
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 10;
			this.metroPanel1.Location = new System.Drawing.Point(530, 130);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Size = new System.Drawing.Size(172, 266);
			this.metroPanel1.TabIndex = 6;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			// 
			// btnCommunication
			// 
			this.btnCommunication.BackColor = System.Drawing.Color.Salmon;
			this.btnCommunication.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCommunication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCommunication.ForeColor = System.Drawing.Color.Black;
			this.btnCommunication.Image = global::ProjetMFTR.Properties.Resources.icone_chat64;
			this.btnCommunication.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCommunication.Location = new System.Drawing.Point(14, 232);
			this.btnCommunication.Name = "btnCommunication";
			this.btnCommunication.Size = new System.Drawing.Size(458, 64);
			this.btnCommunication.TabIndex = 10;
			this.btnCommunication.Text = "Communication";
			this.btnCommunication.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCommunication.UseVisualStyleBackColor = false;
			this.btnCommunication.Click += new System.EventHandler(this.btnCommunication_Click);
			// 
			// btnGestionIntervenant
			// 
			this.btnGestionIntervenant.BackColor = System.Drawing.Color.MediumOrchid;
			this.btnGestionIntervenant.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGestionIntervenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGestionIntervenant.ForeColor = System.Drawing.Color.Black;
			this.btnGestionIntervenant.Image = global::ProjetMFTR.Properties.Resources.icone_person_64;
			this.btnGestionIntervenant.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGestionIntervenant.Location = new System.Drawing.Point(14, 162);
			this.btnGestionIntervenant.Name = "btnGestionIntervenant";
			this.btnGestionIntervenant.Size = new System.Drawing.Size(458, 64);
			this.btnGestionIntervenant.TabIndex = 9;
			this.btnGestionIntervenant.Text = "Gestion des intervenants";
			this.btnGestionIntervenant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGestionIntervenant.UseVisualStyleBackColor = false;
			this.btnGestionIntervenant.Click += new System.EventHandler(this.btnGestionIntervenant_Click);
			// 
			// btnGestionDossier
			// 
			this.btnGestionDossier.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnGestionDossier.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGestionDossier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGestionDossier.ForeColor = System.Drawing.Color.Black;
			this.btnGestionDossier.Image = global::ProjetMFTR.Properties.Resources.icone_folder_64;
			this.btnGestionDossier.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGestionDossier.Location = new System.Drawing.Point(14, 22);
			this.btnGestionDossier.Name = "btnGestionDossier";
			this.btnGestionDossier.Size = new System.Drawing.Size(458, 64);
			this.btnGestionDossier.TabIndex = 8;
			this.btnGestionDossier.Text = "Gestion des dossiers";
			this.btnGestionDossier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGestionDossier.UseVisualStyleBackColor = false;
			this.btnGestionDossier.Click += new System.EventHandler(this.btnGestionDossier_Click);
			// 
			// btnGestionSuivi
			// 
			this.btnGestionSuivi.BackColor = System.Drawing.Color.PaleGreen;
			this.btnGestionSuivi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGestionSuivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGestionSuivi.ForeColor = System.Drawing.Color.Black;
			this.btnGestionSuivi.Image = global::ProjetMFTR.Properties.Resources.icone_suivi_64;
			this.btnGestionSuivi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGestionSuivi.Location = new System.Drawing.Point(14, 92);
			this.btnGestionSuivi.Name = "btnGestionSuivi";
			this.btnGestionSuivi.Size = new System.Drawing.Size(458, 64);
			this.btnGestionSuivi.TabIndex = 7;
			this.btnGestionSuivi.Text = "Gestion des suivis";
			this.btnGestionSuivi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGestionSuivi.UseVisualStyleBackColor = false;
			this.btnGestionSuivi.Click += new System.EventHandler(this.btnGestionSuivi_Click);
			// 
			// btnOptions
			// 
			this.btnOptions.BackColor = System.Drawing.Color.Salmon;
			this.btnOptions.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOptions.ForeColor = System.Drawing.Color.Black;
			this.btnOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOptions.Location = new System.Drawing.Point(14, 302);
			this.btnOptions.Name = "btnOptions";
			this.btnOptions.Size = new System.Drawing.Size(458, 64);
			this.btnOptions.TabIndex = 11;
			this.btnOptions.Text = "Options";
			this.btnOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOptions.UseVisualStyleBackColor = false;
			this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
			// 
			// lblVersion
			// 
			this.lblVersion.AutoSize = true;
			this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVersion.Location = new System.Drawing.Point(11, 582);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(61, 13);
			this.lblVersion.TabIndex = 12;
			this.lblVersion.Text = "Version : ";
			// 
			// btnPassage
			// 
			this.btnPassage.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnPassage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPassage.Enabled = false;
			this.btnPassage.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.btnPassage.Location = new System.Drawing.Point(14, 423);
			this.btnPassage.Name = "btnPassage";
			this.btnPassage.Size = new System.Drawing.Size(458, 55);
			this.btnPassage.TabIndex = 13;
			this.btnPassage.Text = "Passage";
			this.btnPassage.UseCustomBackColor = true;
			this.btnPassage.UseSelectable = true;
			this.btnPassage.Click += new System.EventHandler(this.btnPassage_Click);
			// 
			// btnPayment
			// 
			this.btnPayment.BackColor = System.Drawing.Color.Goldenrod;
			this.btnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPayment.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.btnPayment.Location = new System.Drawing.Point(14, 484);
			this.btnPayment.Name = "btnPayment";
			this.btnPayment.Size = new System.Drawing.Size(458, 55);
			this.btnPayment.TabIndex = 14;
			this.btnPayment.Text = "Arrivés / Départs";
			this.btnPayment.UseCustomBackColor = true;
			this.btnPayment.UseSelectable = true;
			this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
			// 
			// Accueil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(725, 603);
			this.Controls.Add(this.btnPayment);
			this.Controls.Add(this.btnPassage);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.btnOptions);
			this.Controls.Add(this.btnCommunication);
			this.Controls.Add(this.btnGestionIntervenant);
			this.Controls.Add(this.btnGestionDossier);
			this.Controls.Add(this.btnGestionSuivi);
			this.Controls.Add(this.metroPanel1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Accueil";
			this.Text = "Accueil";
			this.Load += new System.EventHandler(this.Accueil_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private MetroFramework.Controls.MetroPanel metroPanel1;
		private System.Windows.Forms.Button btnCommunication;
		private System.Windows.Forms.Button btnGestionIntervenant;
		private System.Windows.Forms.Button btnGestionDossier;
		private System.Windows.Forms.Button btnGestionSuivi;
		private System.Windows.Forms.Button btnOptions;
		private System.Windows.Forms.Label lblVersion;
		private MetroFramework.Controls.MetroButton btnPassage;
		private MetroFramework.Controls.MetroButton btnPayment;
	}
}