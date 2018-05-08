namespace ProjetMFTR
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtFolderNumber = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnRecherche = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cboKid = new System.Windows.Forms.ComboBox();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.gvList = new System.Windows.Forms.DataGridView();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnGestion = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bsData = new System.Windows.Forms.BindingSource(this.components);
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Enfant = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Dossier = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Intervenant = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsData)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this.txtFolderNumber);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btnRecherche);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cboKid);
			this.groupBox1.Controls.Add(this.dtpDate);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(794, 151);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Critères de recherche";
			// 
			// txtFolderNumber
			// 
			this.txtFolderNumber.Location = new System.Drawing.Point(321, 31);
			this.txtFolderNumber.Name = "txtFolderNumber";
			this.txtFolderNumber.Size = new System.Drawing.Size(272, 20);
			this.txtFolderNumber.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(225, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Enfant";
			// 
			// btnRecherche
			// 
			this.btnRecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRecherche.Location = new System.Drawing.Point(466, 109);
			this.btnRecherche.Name = "btnRecherche";
			this.btnRecherche.Size = new System.Drawing.Size(127, 23);
			this.btnRecherche.TabIndex = 3;
			this.btnRecherche.Text = "Rechercher";
			this.btnRecherche.UseVisualStyleBackColor = true;
			this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(225, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Numéro dossier";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Date";
			// 
			// cboKid
			// 
			this.cboKid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboKid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboKid.FormattingEnabled = true;
			this.cboKid.Location = new System.Drawing.Point(321, 68);
			this.cboKid.Name = "cboKid";
			this.cboKid.Size = new System.Drawing.Size(272, 21);
			this.cboKid.TabIndex = 1;
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(62, 31);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(144, 20);
			this.dtpDate.TabIndex = 0;
			// 
			// gvList
			// 
			this.gvList.AllowUserToOrderColumns = true;
			this.gvList.AutoGenerateColumns = false;
			this.gvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Enfant,
            this.Dossier,
            this.Intervenant});
			this.gvList.DataSource = this.bsData;
			this.gvList.Location = new System.Drawing.Point(12, 173);
			this.gvList.Name = "gvList";
			this.gvList.ReadOnly = true;
			this.gvList.Size = new System.Drawing.Size(794, 286);
			this.gvList.TabIndex = 1;
			this.gvList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvList_CellFormatting);
			// 
			// btnDelete
			// 
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Location = new System.Drawing.Point(591, 465);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(72, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Supprimer";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Location = new System.Drawing.Point(679, 465);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(127, 23);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "Ajouter";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnGestion
			// 
			this.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGestion.Location = new System.Drawing.Point(12, 465);
			this.btnGestion.Name = "btnGestion";
			this.btnGestion.Size = new System.Drawing.Size(125, 23);
			this.btnGestion.TabIndex = 6;
			this.btnGestion.Text = "Gestion intervenant";
			this.btnGestion.UseVisualStyleBackColor = true;
			this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Location = new System.Drawing.Point(158, 465);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(127, 23);
			this.btnPrint.TabIndex = 6;
			this.btnPrint.Text = "Imprimer";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Enfants";
			this.dataGridViewTextBoxColumn1.HeaderText = "Enfant";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Enfants";
			this.dataGridViewTextBoxColumn2.HeaderText = "Enfant";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Enfants";
			this.dataGridViewTextBoxColumn3.HeaderText = "Enfant";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// bsData
			// 
			this.bsData.DataSource = typeof(ProjetMFTR.Entities.Suivi);
			// 
			// Date
			// 
			this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Date.DataPropertyName = "dateSuivi";
			this.Date.FillWeight = 85F;
			this.Date.HeaderText = "Date";
			this.Date.Name = "Date";
			this.Date.ReadOnly = true;
			this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// Enfant
			// 
			this.Enfant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Enfant.DataPropertyName = "Enfants";
			this.Enfant.HeaderText = "Enfant";
			this.Enfant.Name = "Enfant";
			this.Enfant.ReadOnly = true;
			this.Enfant.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// Dossier
			// 
			this.Dossier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Dossier.HeaderText = "Dossier";
			this.Dossier.Name = "Dossier";
			this.Dossier.ReadOnly = true;
			// 
			// Intervenant
			// 
			this.Intervenant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Intervenant.DataPropertyName = "intervenant_id";
			this.Intervenant.HeaderText = "Intervenant";
			this.Intervenant.Name = "Intervenant";
			this.Intervenant.ReadOnly = true;
			// 
			// Accueil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(821, 507);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.btnGestion);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.gvList);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "Accueil";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Suivis";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboKid;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvList;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.TextBox txtFolderNumber;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.BindingSource bsData;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private System.Windows.Forms.DataGridViewTextBoxColumn Enfant;
		private System.Windows.Forms.DataGridViewTextBoxColumn Dossier;
		private System.Windows.Forms.DataGridViewTextBoxColumn Intervenant;
	}
}

