namespace ProjetMFTR.Forms
{
    partial class DossierNouveau
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
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpDateOuverture = new System.Windows.Forms.DateTimePicker();
			this.gbParent = new System.Windows.Forms.GroupBox();
			this.listParents = new System.Windows.Forms.DataGridView();
			this.Enfant = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Dossier = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbEnfants = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label6 = new System.Windows.Forms.Label();
			this.rtxtRemarque = new System.Windows.Forms.RichTextBox();
			this.txtNoDossier = new System.Windows.Forms.TextBox();
			this.btnSaveAndQuit = new System.Windows.Forms.Button();
			this.btnSaveAndNew = new System.Windows.Forms.Button();
			this.cboType = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.gbParent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.listParents)).BeginInit();
			this.gbEnfants.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "Numéro dossier";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Date d\'ouverture";
			// 
			// dtpDateOuverture
			// 
			this.dtpDateOuverture.Location = new System.Drawing.Point(117, 70);
			this.dtpDateOuverture.Name = "dtpDateOuverture";
			this.dtpDateOuverture.Size = new System.Drawing.Size(146, 20);
			this.dtpDateOuverture.TabIndex = 3;
			// 
			// gbParent
			// 
			this.gbParent.Controls.Add(this.listParents);
			this.gbParent.Location = new System.Drawing.Point(32, 116);
			this.gbParent.Name = "gbParent";
			this.gbParent.Size = new System.Drawing.Size(610, 159);
			this.gbParent.TabIndex = 14;
			this.gbParent.TabStop = false;
			this.gbParent.Text = "Parents";
			// 
			// listParents
			// 
			this.listParents.AllowUserToAddRows = false;
			this.listParents.AllowUserToOrderColumns = true;
			this.listParents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.listParents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.listParents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Enfant,
            this.Dossier,
            this.Sexe,
            this.Statut,
            this.Date});
			this.listParents.Location = new System.Drawing.Point(15, 20);
			this.listParents.Name = "listParents";
			this.listParents.ReadOnly = true;
			this.listParents.Size = new System.Drawing.Size(589, 123);
			this.listParents.TabIndex = 2;
			// 
			// Enfant
			// 
			this.Enfant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Enfant.DataPropertyName = "Enfants";
			this.Enfant.HeaderText = "Prénom";
			this.Enfant.Name = "Enfant";
			this.Enfant.ReadOnly = true;
			this.Enfant.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// Dossier
			// 
			this.Dossier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Dossier.HeaderText = "Nom";
			this.Dossier.Name = "Dossier";
			this.Dossier.ReadOnly = true;
			// 
			// Sexe
			// 
			this.Sexe.HeaderText = "Sexe";
			this.Sexe.Name = "Sexe";
			this.Sexe.ReadOnly = true;
			// 
			// Statut
			// 
			this.Statut.HeaderText = "Statut";
			this.Statut.Name = "Statut";
			this.Statut.ReadOnly = true;
			// 
			// Date
			// 
			this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Date.DataPropertyName = "dateSuivi";
			this.Date.FillWeight = 85F;
			this.Date.HeaderText = "Date de naissance";
			this.Date.Name = "Date";
			this.Date.ReadOnly = true;
			this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// gbEnfants
			// 
			this.gbEnfants.Controls.Add(this.dataGridView1);
			this.gbEnfants.Location = new System.Drawing.Point(32, 296);
			this.gbEnfants.Name = "gbEnfants";
			this.gbEnfants.Size = new System.Drawing.Size(604, 187);
			this.gbEnfants.TabIndex = 15;
			this.gbEnfants.TabStop = false;
			this.gbEnfants.Text = "Enfants";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.dataGridView1.Location = new System.Drawing.Point(9, 19);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(589, 162);
			this.dataGridView1.TabIndex = 3;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Enfants";
			this.dataGridViewTextBoxColumn1.HeaderText = "Prénom";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Sexe";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Accueil";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn5.DataPropertyName = "dateSuivi";
			this.dataGridViewTextBoxColumn5.FillWeight = 85F;
			this.dataGridViewTextBoxColumn5.HeaderText = "Date de naissance";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(29, 486);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "Remarques";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// rtxtRemarque
			// 
			this.rtxtRemarque.Location = new System.Drawing.Point(32, 511);
			this.rtxtRemarque.Name = "rtxtRemarque";
			this.rtxtRemarque.Size = new System.Drawing.Size(598, 78);
			this.rtxtRemarque.TabIndex = 16;
			this.rtxtRemarque.Text = "";
			this.rtxtRemarque.TextChanged += new System.EventHandler(this.rtxtRemarque_TextChanged);
			// 
			// txtNoDossier
			// 
			this.txtNoDossier.Location = new System.Drawing.Point(115, 29);
			this.txtNoDossier.Name = "txtNoDossier";
			this.txtNoDossier.Size = new System.Drawing.Size(166, 20);
			this.txtNoDossier.TabIndex = 1;
			// 
			// btnSaveAndQuit
			// 
			this.btnSaveAndQuit.BackColor = System.Drawing.Color.PaleGreen;
			this.btnSaveAndQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveAndQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveAndQuit.Location = new System.Drawing.Point(329, 615);
			this.btnSaveAndQuit.Name = "btnSaveAndQuit";
			this.btnSaveAndQuit.Size = new System.Drawing.Size(136, 23);
			this.btnSaveAndQuit.TabIndex = 4;
			this.btnSaveAndQuit.Text = "Enregistrer et Fermer";
			this.btnSaveAndQuit.UseVisualStyleBackColor = false;
			this.btnSaveAndQuit.Click += new System.EventHandler(this.btnSaveAndQuit_Click);
			// 
			// btnSaveAndNew
			// 
			this.btnSaveAndNew.BackColor = System.Drawing.Color.PaleGreen;
			this.btnSaveAndNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveAndNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveAndNew.Location = new System.Drawing.Point(476, 615);
			this.btnSaveAndNew.Name = "btnSaveAndNew";
			this.btnSaveAndNew.Size = new System.Drawing.Size(154, 23);
			this.btnSaveAndNew.TabIndex = 5;
			this.btnSaveAndNew.Text = "Enregistrer et nouveau";
			this.btnSaveAndNew.UseVisualStyleBackColor = false;
			this.btnSaveAndNew.Click += new System.EventHandler(this.btnSaveAndNew_Click);
			// 
			// cboType
			// 
			this.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboType.FormattingEnabled = true;
			this.cboType.Items.AddRange(new object[] {
            "Cour Supérieure",
            "Centre Jeunesse",
            "Entente entre les parties"});
			this.cboType.Location = new System.Drawing.Point(384, 29);
			this.cboType.Name = "cboType";
			this.cboType.Size = new System.Drawing.Size(219, 21);
			this.cboType.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(326, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 23;
			this.label2.Text = "Type";
			// 
			// DossierNouveau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(665, 648);
			this.Controls.Add(this.cboType);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSaveAndNew);
			this.Controls.Add(this.btnSaveAndQuit);
			this.Controls.Add(this.txtNoDossier);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.rtxtRemarque);
			this.Controls.Add(this.gbEnfants);
			this.Controls.Add(this.gbParent);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpDateOuverture);
			this.Name = "DossierNouveau";
			this.Text = "Nouveau Dossier";
			this.gbParent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.listParents)).EndInit();
			this.gbEnfants.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateOuverture;
        private System.Windows.Forms.GroupBox gbParent;
        private System.Windows.Forms.GroupBox gbEnfants;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxtRemarque;
        private System.Windows.Forms.TextBox txtNoDossier;
        private System.Windows.Forms.DataGridView listParents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enfant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dossier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnSaveAndQuit;
        private System.Windows.Forms.Button btnSaveAndNew;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label2;
    }
}