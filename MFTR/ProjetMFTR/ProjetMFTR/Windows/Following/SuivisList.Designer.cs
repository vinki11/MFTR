﻿namespace ProjetMFTR
{
    partial class SuivisList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuivisList));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnClearFilters = new System.Windows.Forms.Button();
			this.cboEmployes = new System.Windows.Forms.ComboBox();
			this.lblIntervenant = new System.Windows.Forms.Label();
			this.chkDate = new System.Windows.Forms.CheckBox();
			this.cboFolders = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnRecherche = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cboKid = new System.Windows.Forms.ComboBox();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.gvList = new System.Windows.Forms.DataGridView();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Dossier = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Enfant = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Intervenant = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bsData = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsData)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this.btnClearFilters);
			this.groupBox1.Controls.Add(this.cboEmployes);
			this.groupBox1.Controls.Add(this.lblIntervenant);
			this.groupBox1.Controls.Add(this.chkDate);
			this.groupBox1.Controls.Add(this.cboFolders);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btnRecherche);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cboKid);
			this.groupBox1.Controls.Add(this.dtpDate);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(794, 166);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Critères de recherche";
			// 
			// btnClearFilters
			// 
			this.btnClearFilters.BackColor = System.Drawing.Color.LightCoral;
			this.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClearFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClearFilters.Location = new System.Drawing.Point(6, 124);
			this.btnClearFilters.Name = "btnClearFilters";
			this.btnClearFilters.Size = new System.Drawing.Size(144, 23);
			this.btnClearFilters.TabIndex = 10;
			this.btnClearFilters.Text = "Supprimer les critères";
			this.btnClearFilters.UseVisualStyleBackColor = false;
			this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
			// 
			// cboEmployes
			// 
			this.cboEmployes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboEmployes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboEmployes.FormattingEnabled = true;
			this.cboEmployes.Location = new System.Drawing.Point(334, 81);
			this.cboEmployes.Name = "cboEmployes";
			this.cboEmployes.Size = new System.Drawing.Size(170, 21);
			this.cboEmployes.TabIndex = 9;
			// 
			// lblIntervenant
			// 
			this.lblIntervenant.AutoSize = true;
			this.lblIntervenant.Location = new System.Drawing.Point(267, 84);
			this.lblIntervenant.Name = "lblIntervenant";
			this.lblIntervenant.Size = new System.Drawing.Size(61, 13);
			this.lblIntervenant.TabIndex = 8;
			this.lblIntervenant.Text = "Intervenant";
			// 
			// chkDate
			// 
			this.chkDate.AutoSize = true;
			this.chkDate.Location = new System.Drawing.Point(20, 34);
			this.chkDate.Name = "chkDate";
			this.chkDate.Size = new System.Drawing.Size(15, 14);
			this.chkDate.TabIndex = 7;
			this.chkDate.UseVisualStyleBackColor = true;
			this.chkDate.CheckedChanged += new System.EventHandler(this.chkDate_CheckedChanged);
			// 
			// cboFolders
			// 
			this.cboFolders.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboFolders.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboFolders.FormattingEnabled = true;
			this.cboFolders.Location = new System.Drawing.Point(334, 31);
			this.cboFolders.Name = "cboFolders";
			this.cboFolders.Size = new System.Drawing.Size(170, 21);
			this.cboFolders.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(520, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Enfant";
			// 
			// btnRecherche
			// 
			this.btnRecherche.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnRecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRecherche.Location = new System.Drawing.Point(661, 124);
			this.btnRecherche.Name = "btnRecherche";
			this.btnRecherche.Size = new System.Drawing.Size(127, 23);
			this.btnRecherche.TabIndex = 3;
			this.btnRecherche.Text = "Rechercher";
			this.btnRecherche.UseVisualStyleBackColor = false;
			this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(248, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Numéro dossier";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(41, 34);
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
			this.cboKid.Location = new System.Drawing.Point(564, 31);
			this.cboKid.Name = "cboKid";
			this.cboKid.Size = new System.Drawing.Size(170, 21);
			this.cboKid.TabIndex = 1;
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(77, 31);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(144, 20);
			this.dtpDate.TabIndex = 0;
			// 
			// gvList
			// 
			this.gvList.AllowUserToAddRows = false;
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
			this.gvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvList.Size = new System.Drawing.Size(794, 286);
			this.gvList.TabIndex = 1;
			this.gvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvList_CellDoubleClick);
			this.gvList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvList_CellFormatting);
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
			// Dossier
			// 
			this.Dossier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Dossier.HeaderText = "Dossier";
			this.Dossier.Name = "Dossier";
			this.Dossier.ReadOnly = true;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(591, 465);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(82, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Supprimer";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.PaleGreen;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(679, 465);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(127, 23);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "Ajouter";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrint.Location = new System.Drawing.Point(12, 465);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(127, 23);
			this.btnPrint.TabIndex = 6;
			this.btnPrint.Text = "Imprimer";
			this.btnPrint.UseVisualStyleBackColor = false;
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
			// Enfant
			// 
			this.Enfant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Enfant.DataPropertyName = "Enfants";
			this.Enfant.HeaderText = "Enfant";
			this.Enfant.Name = "Enfant";
			this.Enfant.ReadOnly = true;
			this.Enfant.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// Intervenant
			// 
			this.Intervenant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Intervenant.DataPropertyName = "intervenant_id";
			this.Intervenant.HeaderText = "Intervenant";
			this.Intervenant.Name = "Intervenant";
			this.Intervenant.ReadOnly = true;
			// 
			// bsData
			// 
			this.bsData.DataSource = typeof(ProjetMFTR.Entities.Suivi);
			// 
			// SuivisList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(821, 507);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.gvList);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SuivisList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Liste des fiches de déroulement des échanges";
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
		private System.Windows.Forms.CheckBox chkDate;
		private System.Windows.Forms.ComboBox cboEmployes;
		private System.Windows.Forms.Label lblIntervenant;
		private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.ComboBox cboFolders;
    }
}

