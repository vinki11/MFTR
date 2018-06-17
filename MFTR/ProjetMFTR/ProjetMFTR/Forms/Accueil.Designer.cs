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
            this.button1 = new System.Windows.Forms.Button();
            this.btnGestionIntervenant = new System.Windows.Forms.Button();
            this.btnGestionDossier = new System.Windows.Forms.Button();
            this.btnGestionSuivi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maison de la famille de Trois-Rivières inc, 2018";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::ProjetMFTR.Properties.Resources.icone_chat64;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(12, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(458, 80);
            this.button1.TabIndex = 5;
            this.button1.Text = "Communication";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnGestionIntervenant
            // 
            this.btnGestionIntervenant.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnGestionIntervenant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionIntervenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionIntervenant.ForeColor = System.Drawing.Color.Black;
            this.btnGestionIntervenant.Image = global::ProjetMFTR.Properties.Resources.icone_person_64;
            this.btnGestionIntervenant.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionIntervenant.Location = new System.Drawing.Point(12, 204);
            this.btnGestionIntervenant.Name = "btnGestionIntervenant";
            this.btnGestionIntervenant.Size = new System.Drawing.Size(458, 80);
            this.btnGestionIntervenant.TabIndex = 4;
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
            this.btnGestionDossier.Location = new System.Drawing.Point(12, 113);
            this.btnGestionDossier.Name = "btnGestionDossier";
            this.btnGestionDossier.Size = new System.Drawing.Size(458, 80);
            this.btnGestionDossier.TabIndex = 3;
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
            this.btnGestionSuivi.Location = new System.Drawing.Point(12, 22);
            this.btnGestionSuivi.Name = "btnGestionSuivi";
            this.btnGestionSuivi.Size = new System.Drawing.Size(458, 80);
            this.btnGestionSuivi.TabIndex = 2;
            this.btnGestionSuivi.Text = "Gestion des suivis";
            this.btnGestionSuivi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionSuivi.UseVisualStyleBackColor = false;
            this.btnGestionSuivi.Click += new System.EventHandler(this.btnGestionSuivi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjetMFTR.Properties.Resources.icone_MFTR_ACCUEIL;
            this.pictureBox1.Location = new System.Drawing.Point(476, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 262);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGestionIntervenant);
            this.Controls.Add(this.btnGestionDossier);
            this.Controls.Add(this.btnGestionSuivi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGestionSuivi;
        private System.Windows.Forms.Button btnGestionDossier;
        private System.Windows.Forms.Button btnGestionIntervenant;
		private System.Windows.Forms.Button button1;
	}
}