namespace ProjetMFTR
{
	partial class ReferentList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReferentList));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnClearFilters = new System.Windows.Forms.Button();
			this.cboReferent = new System.Windows.Forms.ComboBox();
			this.btnRecherche = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.gvList = new System.Windows.Forms.DataGridView();
			this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btnAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.referentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.organisationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bsData = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
			this.ContextMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsData)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this.btnClearFilters);
			this.groupBox1.Controls.Add(this.cboReferent);
			this.groupBox1.Controls.Add(this.btnRecherche);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(794, 107);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Critères de recherche";
			// 
			// btnClearFilters
			// 
			this.btnClearFilters.BackColor = System.Drawing.Color.LightCoral;
			this.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClearFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClearFilters.Location = new System.Drawing.Point(6, 65);
			this.btnClearFilters.Name = "btnClearFilters";
			this.btnClearFilters.Size = new System.Drawing.Size(144, 23);
			this.btnClearFilters.TabIndex = 10;
			this.btnClearFilters.Text = "Supprimer les critères";
			this.btnClearFilters.UseVisualStyleBackColor = false;
			this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
			// 
			// cboReferent
			// 
			this.cboReferent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboReferent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboReferent.FormattingEnabled = true;
			this.cboReferent.Location = new System.Drawing.Point(108, 26);
			this.cboReferent.Name = "cboReferent";
			this.cboReferent.Size = new System.Drawing.Size(170, 21);
			this.cboReferent.TabIndex = 6;
			// 
			// btnRecherche
			// 
			this.btnRecherche.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnRecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRecherche.Location = new System.Drawing.Point(651, 65);
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
			this.label2.Location = new System.Drawing.Point(4, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Numéro de référent";
			// 
			// gvList
			// 
			this.gvList.AllowUserToAddRows = false;
			this.gvList.AllowUserToOrderColumns = true;
			this.gvList.AutoGenerateColumns = false;
			this.gvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referentIDDataGridViewTextBoxColumn,
            this.Prenom,
            this.Nom,
            this.organisationDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
			this.gvList.DataSource = this.bsData;
			this.gvList.Location = new System.Drawing.Point(12, 125);
			this.gvList.Name = "gvList";
			this.gvList.ReadOnly = true;
			this.gvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvList.Size = new System.Drawing.Size(794, 334);
			this.gvList.TabIndex = 1;
			this.gvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvList_CellDoubleClick);
			this.gvList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvList_CellFormatting);
			this.gvList.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.gvList_RowContextMenuStripNeeded);
			// 
			// Prenom
			// 
			this.Prenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Prenom.HeaderText = "Prénom";
			this.Prenom.Name = "Prenom";
			this.Prenom.ReadOnly = true;
			// 
			// Nom
			// 
			this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Nom.HeaderText = "Nom";
			this.Nom.Name = "Nom";
			this.Nom.ReadOnly = true;
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
			// ContextMenu
			// 
			this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnDelete});
			this.ContextMenu.Name = "ContextMenu";
			this.ContextMenu.Size = new System.Drawing.Size(130, 48);
			// 
			// btnAdd
			// 
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(129, 22);
			this.btnAdd.Text = "Ajouter";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(129, 22);
			this.btnDelete.Text = "Supprimer";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// referentIDDataGridViewTextBoxColumn
			// 
			this.referentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.referentIDDataGridViewTextBoxColumn.DataPropertyName = "Referent_ID";
			this.referentIDDataGridViewTextBoxColumn.HeaderText = "Referent";
			this.referentIDDataGridViewTextBoxColumn.Name = "referentIDDataGridViewTextBoxColumn";
			this.referentIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// organisationDataGridViewTextBoxColumn
			// 
			this.organisationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.organisationDataGridViewTextBoxColumn.DataPropertyName = "Organisation";
			this.organisationDataGridViewTextBoxColumn.HeaderText = "Organisation";
			this.organisationDataGridViewTextBoxColumn.Name = "organisationDataGridViewTextBoxColumn";
			this.organisationDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// typeDataGridViewTextBoxColumn
			// 
			this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
			this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
			this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			this.typeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bsData
			// 
			this.bsData.DataSource = typeof(ProjetMFTR.Entities.Referent);
			// 
			// ReferentList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(821, 473);
			this.Controls.Add(this.gvList);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ReferentList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Liste des référents";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
			this.ContextMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bsData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView gvList;
		private System.Windows.Forms.Button btnRecherche;
		private System.Windows.Forms.BindingSource bsData;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.Button btnClearFilters;
		private System.Windows.Forms.ComboBox cboReferent;
		private System.Windows.Forms.DataGridViewTextBoxColumn referentIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
		private System.Windows.Forms.DataGridViewTextBoxColumn organisationDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private System.Windows.Forms.ContextMenuStrip ContextMenu;
		private System.Windows.Forms.ToolStripMenuItem btnAdd;
		private System.Windows.Forms.ToolStripMenuItem btnDelete;
	}
}

