﻿namespace ProjetMFTR.Forms
{
    partial class Enfant
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enfant));
			this.btnSave = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
			this.cboStatut = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cboSexe = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPrenom = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSaveAndClose = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.cboReferent = new System.Windows.Forms.ComboBox();
			this.pnlPicture = new MetroFramework.Controls.MetroPanel();
			this.openFile = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(577, 447);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(136, 23);
			this.btnSave.TabIndex = 36;
			this.btnSave.Text = "Enregistrer";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 13);
			this.label4.TabIndex = 34;
			this.label4.Text = "Naissance";
			// 
			// dtpNaissance
			// 
			this.dtpNaissance.Location = new System.Drawing.Point(87, 176);
			this.dtpNaissance.Name = "dtpNaissance";
			this.dtpNaissance.Size = new System.Drawing.Size(144, 20);
			this.dtpNaissance.TabIndex = 35;
			// 
			// cboStatut
			// 
			this.cboStatut.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboStatut.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboStatut.FormattingEnabled = true;
			this.cboStatut.Items.AddRange(new object[] {
            "Oui",
            "Non"});
			this.cboStatut.Location = new System.Drawing.Point(87, 115);
			this.cboStatut.Name = "cboStatut";
			this.cboStatut.Size = new System.Drawing.Size(170, 21);
			this.cboStatut.TabIndex = 33;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 32;
			this.label2.Text = "Accueil";
			// 
			// cboSexe
			// 
			this.cboSexe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboSexe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboSexe.FormattingEnabled = true;
			this.cboSexe.Items.AddRange(new object[] {
            "",
            "Garçon",
            "Fille"});
			this.cboSexe.Location = new System.Drawing.Point(87, 85);
			this.cboSexe.Name = "cboSexe";
			this.cboSexe.Size = new System.Drawing.Size(170, 21);
			this.cboSexe.TabIndex = 31;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(24, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 30;
			this.label6.Text = "Sexe";
			// 
			// txtPrenom
			// 
			this.txtPrenom.Location = new System.Drawing.Point(87, 54);
			this.txtPrenom.Name = "txtPrenom";
			this.txtPrenom.Size = new System.Drawing.Size(170, 20);
			this.txtPrenom.TabIndex = 29;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 28;
			this.label1.Text = "Prénom";
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(87, 23);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(170, 20);
			this.txtNom.TabIndex = 27;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(24, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 13);
			this.label5.TabIndex = 26;
			this.label5.Text = "Nom";
			// 
			// btnSaveAndClose
			// 
			this.btnSaveAndClose.BackColor = System.Drawing.Color.PaleGreen;
			this.btnSaveAndClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveAndClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveAndClose.Location = new System.Drawing.Point(413, 447);
			this.btnSaveAndClose.Name = "btnSaveAndClose";
			this.btnSaveAndClose.Size = new System.Drawing.Size(136, 23);
			this.btnSaveAndClose.TabIndex = 37;
			this.btnSaveAndClose.Text = "Enregistrer et Fermer";
			this.btnSaveAndClose.UseVisualStyleBackColor = false;
			this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveAndClose_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 149);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 38;
			this.label3.Text = "Référent";
			// 
			// cboReferent
			// 
			this.cboReferent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboReferent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboReferent.FormattingEnabled = true;
			this.cboReferent.Location = new System.Drawing.Point(87, 146);
			this.cboReferent.Name = "cboReferent";
			this.cboReferent.Size = new System.Drawing.Size(170, 21);
			this.cboReferent.TabIndex = 39;
			// 
			// pnlPicture
			// 
			this.pnlPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlPicture.HorizontalScrollbarBarColor = true;
			this.pnlPicture.HorizontalScrollbarHighlightOnWheel = false;
			this.pnlPicture.HorizontalScrollbarSize = 10;
			this.pnlPicture.Location = new System.Drawing.Point(313, 23);
			this.pnlPicture.Name = "pnlPicture";
			this.pnlPicture.Size = new System.Drawing.Size(400, 400);
			this.pnlPicture.TabIndex = 40;
			this.pnlPicture.VerticalScrollbarBarColor = true;
			this.pnlPicture.VerticalScrollbarHighlightOnWheel = false;
			this.pnlPicture.VerticalScrollbarSize = 10;
			this.pnlPicture.DoubleClick += new System.EventHandler(this.pnlPicture_DoubleClick);
			// 
			// openFile
			// 
			this.openFile.FileName = "openFileDialog1";
			// 
			// Enfant
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(747, 482);
			this.Controls.Add(this.pnlPicture);
			this.Controls.Add(this.cboReferent);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnSaveAndClose);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtpNaissance);
			this.Controls.Add(this.cboStatut);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboSexe);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtPrenom);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNom);
			this.Controls.Add(this.label5);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Enfant";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Enfant";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNaissance;
        private System.Windows.Forms.ComboBox cboStatut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSexe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSaveAndClose;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboReferent;
		private MetroFramework.Controls.MetroPanel pnlPicture;
		private System.Windows.Forms.OpenFileDialog openFile;
	}
}