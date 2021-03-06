﻿namespace ProjetMFTR.Forms
{
	partial class Dossier
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dossier));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtRechercheTelephone = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnClearFilters = new System.Windows.Forms.Button();
			this.cboFolders = new System.Windows.Forms.ComboBox();
			this.btnRecherche = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.gvList = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bsData = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rtxtRemarque = new System.Windows.Forms.RichTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cboType = new System.Windows.Forms.ComboBox();
			this.txtDossier = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpDossier = new System.Windows.Forms.DateTimePicker();
			this.btnSaveDossier = new System.Windows.Forms.Button();
			this.btnAddCommunication = new System.Windows.Forms.Button();
			this.btnReferents = new System.Windows.Forms.Button();
			this.DossierContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.Add_Folder = new System.Windows.Forms.ToolStripMenuItem();
			this.Remove_Folder = new System.Windows.Forms.ToolStripMenuItem();
			this.CommunicationContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.Remove_Communication = new System.Windows.Forms.ToolStripMenuItem();
			this.pageCommunication = new System.Windows.Forms.TabPage();
			this.gvCommunications = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Motif = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Interlocuteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bsDataCommunication = new System.Windows.Forms.BindingSource(this.components);
			this.pageKids = new System.Windows.Forms.TabPage();
			this.gvKids = new System.Windows.Forms.DataGridView();
			this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sexeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.naissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.accueilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bsDataKids = new System.Windows.Forms.BindingSource(this.components);
			this.pageParents = new System.Windows.Forms.TabPage();
			this.gvParents = new System.Windows.Forms.DataGridView();
			this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sexeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.naissanceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bsDataParents = new System.Windows.Forms.BindingSource(this.components);
			this.tb = new System.Windows.Forms.TabControl();
			this.gvTelephones = new System.Windows.Forms.DataGridView();
			this.TelNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TelPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telephone1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.posteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bsTelephones = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsData)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.DossierContextMenu.SuspendLayout();
			this.CommunicationContextMenu.SuspendLayout();
			this.pageCommunication.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvCommunications)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsDataCommunication)).BeginInit();
			this.pageKids.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvKids)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsDataKids)).BeginInit();
			this.pageParents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvParents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsDataParents)).BeginInit();
			this.tb.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvTelephones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsTelephones)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this.txtFirstName);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtLastName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtRechercheTelephone);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btnClearFilters);
			this.groupBox1.Controls.Add(this.cboFolders);
			this.groupBox1.Controls.Add(this.btnRecherche);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(22, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1469, 121);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Critères de recherche";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(495, 34);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(170, 20);
			this.txtFirstName.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(446, 37);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 13);
			this.label8.TabIndex = 15;
			this.label8.Text = "Prénom";
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(841, 34);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(170, 20);
			this.txtLastName.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(806, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "Nom";
			// 
			// txtRechercheTelephone
			// 
			this.txtRechercheTelephone.Location = new System.Drawing.Point(1293, 34);
			this.txtRechercheTelephone.Name = "txtRechercheTelephone";
			this.txtRechercheTelephone.Size = new System.Drawing.Size(170, 20);
			this.txtRechercheTelephone.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(1152, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Numéro de téléphone";
			// 
			// btnClearFilters
			// 
			this.btnClearFilters.BackColor = System.Drawing.Color.LightCoral;
			this.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClearFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClearFilters.Location = new System.Drawing.Point(20, 67);
			this.btnClearFilters.Name = "btnClearFilters";
			this.btnClearFilters.Size = new System.Drawing.Size(144, 23);
			this.btnClearFilters.TabIndex = 10;
			this.btnClearFilters.Text = "Supprimer les critères";
			this.btnClearFilters.UseVisualStyleBackColor = false;
			this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
			// 
			// cboFolders
			// 
			this.cboFolders.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cboFolders.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboFolders.FormattingEnabled = true;
			this.cboFolders.Location = new System.Drawing.Point(132, 34);
			this.cboFolders.Name = "cboFolders";
			this.cboFolders.Size = new System.Drawing.Size(170, 21);
			this.cboFolders.TabIndex = 1;
			// 
			// btnRecherche
			// 
			this.btnRecherche.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnRecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRecherche.Location = new System.Drawing.Point(1336, 79);
			this.btnRecherche.Name = "btnRecherche";
			this.btnRecherche.Size = new System.Drawing.Size(127, 23);
			this.btnRecherche.TabIndex = 5;
			this.btnRecherche.Text = "Rechercher";
			this.btnRecherche.UseVisualStyleBackColor = false;
			this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Numéro dossier";
			// 
			// gvList
			// 
			this.gvList.AllowUserToAddRows = false;
			this.gvList.AllowUserToDeleteRows = false;
			this.gvList.AllowUserToOrderColumns = true;
			this.gvList.AutoGenerateColumns = false;
			this.gvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Date,
            this.typeDataGridViewTextBoxColumn});
			this.gvList.DataSource = this.bsData;
			this.gvList.Location = new System.Drawing.Point(22, 161);
			this.gvList.Name = "gvList";
			this.gvList.ReadOnly = true;
			this.gvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvList.Size = new System.Drawing.Size(484, 231);
			this.gvList.TabIndex = 2;
			this.gvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvList_CellDoubleClick);
			this.gvList.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.gvList_RowContextMenuStripNeeded);
			this.gvList.SelectionChanged += new System.EventHandler(this.gvList_SelectionChanged);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Dossier_ID";
			this.dataGridViewTextBoxColumn1.HeaderText = "Dossier";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// Date
			// 
			this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Date.DataPropertyName = "Ouverture";
			this.Date.FillWeight = 85F;
			this.Date.HeaderText = "Date d\'ouverture";
			this.Date.Name = "Date";
			this.Date.ReadOnly = true;
			this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// typeDataGridViewTextBoxColumn
			// 
			this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
			this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
			this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			this.typeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bsData
			// 
			this.bsData.DataSource = typeof(ProjetMFTR.Entities.Dossier);
			// 
			// groupBox2
			// 
			this.groupBox2.AutoSize = true;
			this.groupBox2.Controls.Add(this.rtxtRemarque);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.cboType);
			this.groupBox2.Controls.Add(this.txtDossier);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.dtpDossier);
			this.groupBox2.Enabled = false;
			this.groupBox2.Location = new System.Drawing.Point(531, 161);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(960, 231);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Dossier";
			// 
			// rtxtRemarque
			// 
			this.rtxtRemarque.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsData, "Remarque", true));
			this.rtxtRemarque.Location = new System.Drawing.Point(121, 87);
			this.rtxtRemarque.Name = "rtxtRemarque";
			this.rtxtRemarque.Size = new System.Drawing.Size(700, 96);
			this.rtxtRemarque.TabIndex = 15;
			this.rtxtRemarque.Text = "";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 87);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Remarque";
			// 
			// cboType
			// 
			this.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsData, "Type", true));
			this.cboType.FormattingEnabled = true;
			this.cboType.Items.AddRange(new object[] {
            "Cour Supérieure",
            "Centre Jeunesse",
            "Entente entre les parties"});
			this.cboType.Location = new System.Drawing.Point(588, 19);
			this.cboType.Name = "cboType";
			this.cboType.Size = new System.Drawing.Size(219, 21);
			this.cboType.TabIndex = 14;
			// 
			// txtDossier
			// 
			this.txtDossier.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsData, "Dossier_ID", true));
			this.txtDossier.Location = new System.Drawing.Point(121, 22);
			this.txtDossier.Name = "txtDossier";
			this.txtDossier.Size = new System.Drawing.Size(170, 20);
			this.txtDossier.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(530, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Type";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "Date d\'ouverture";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Numéro de dossier";
			// 
			// dtpDossier
			// 
			this.dtpDossier.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsData, "Ouverture", true));
			this.dtpDossier.Location = new System.Drawing.Point(121, 53);
			this.dtpDossier.Name = "dtpDossier";
			this.dtpDossier.Size = new System.Drawing.Size(144, 20);
			this.dtpDossier.TabIndex = 13;
			// 
			// btnSaveDossier
			// 
			this.btnSaveDossier.BackColor = System.Drawing.Color.LightGreen;
			this.btnSaveDossier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveDossier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveDossier.Location = new System.Drawing.Point(1364, 722);
			this.btnSaveDossier.Name = "btnSaveDossier";
			this.btnSaveDossier.Size = new System.Drawing.Size(127, 23);
			this.btnSaveDossier.TabIndex = 13;
			this.btnSaveDossier.Text = "Enregistrer";
			this.btnSaveDossier.UseVisualStyleBackColor = false;
			this.btnSaveDossier.Visible = false;
			this.btnSaveDossier.Click += new System.EventHandler(this.btnSaveDossier_Click);
			// 
			// btnAddCommunication
			// 
			this.btnAddCommunication.BackColor = System.Drawing.Color.LightGreen;
			this.btnAddCommunication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddCommunication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddCommunication.Location = new System.Drawing.Point(22, 722);
			this.btnAddCommunication.Name = "btnAddCommunication";
			this.btnAddCommunication.Size = new System.Drawing.Size(164, 23);
			this.btnAddCommunication.TabIndex = 13;
			this.btnAddCommunication.Text = "Nouvelle communication";
			this.btnAddCommunication.UseVisualStyleBackColor = false;
			this.btnAddCommunication.Click += new System.EventHandler(this.btnAddCommunication_Click);
			// 
			// btnReferents
			// 
			this.btnReferents.BackColor = System.Drawing.Color.LightGreen;
			this.btnReferents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReferents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReferents.Location = new System.Drawing.Point(212, 722);
			this.btnReferents.Name = "btnReferents";
			this.btnReferents.Size = new System.Drawing.Size(164, 23);
			this.btnReferents.TabIndex = 15;
			this.btnReferents.Text = "Référents";
			this.btnReferents.UseVisualStyleBackColor = false;
			this.btnReferents.Click += new System.EventHandler(this.btnAddFolder_Click);
			// 
			// DossierContextMenu
			// 
			this.DossierContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_Folder,
            this.Remove_Folder});
			this.DossierContextMenu.Name = "contextMenu";
			this.DossierContextMenu.Size = new System.Drawing.Size(220, 48);
			// 
			// Add_Folder
			// 
			this.Add_Folder.Name = "Add_Folder";
			this.Add_Folder.Size = new System.Drawing.Size(219, 22);
			this.Add_Folder.Text = "Ajouter un nouveau dossier";
			this.Add_Folder.Click += new System.EventHandler(this.addRow_Click);
			// 
			// Remove_Folder
			// 
			this.Remove_Folder.Name = "Remove_Folder";
			this.Remove_Folder.Size = new System.Drawing.Size(219, 22);
			this.Remove_Folder.Text = "Suppression";
			this.Remove_Folder.Click += new System.EventHandler(this.Remove_Folder_Click);
			// 
			// CommunicationContextMenu
			// 
			this.CommunicationContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Remove_Communication});
			this.CommunicationContextMenu.Name = "contextMenu";
			this.CommunicationContextMenu.Size = new System.Drawing.Size(139, 26);
			// 
			// Remove_Communication
			// 
			this.Remove_Communication.Name = "Remove_Communication";
			this.Remove_Communication.Size = new System.Drawing.Size(138, 22);
			this.Remove_Communication.Text = "Suppression";
			this.Remove_Communication.Click += new System.EventHandler(this.Remove_Communication_Click);
			// 
			// pageCommunication
			// 
			this.pageCommunication.Controls.Add(this.gvCommunications);
			this.pageCommunication.Location = new System.Drawing.Point(4, 22);
			this.pageCommunication.Name = "pageCommunication";
			this.pageCommunication.Size = new System.Drawing.Size(916, 292);
			this.pageCommunication.TabIndex = 2;
			this.pageCommunication.Text = "Communications";
			this.pageCommunication.UseVisualStyleBackColor = true;
			// 
			// gvCommunications
			// 
			this.gvCommunications.AllowUserToAddRows = false;
			this.gvCommunications.AllowUserToDeleteRows = false;
			this.gvCommunications.AllowUserToOrderColumns = true;
			this.gvCommunications.AutoGenerateColumns = false;
			this.gvCommunications.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gvCommunications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvCommunications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.Type,
            this.Motif,
            this.Interlocuteur,
            this.EventDate,
            this.dataGridViewTextBoxColumn2});
			this.gvCommunications.DataSource = this.bsDataCommunication;
			this.gvCommunications.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gvCommunications.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.gvCommunications.Location = new System.Drawing.Point(0, 0);
			this.gvCommunications.Name = "gvCommunications";
			this.gvCommunications.ReadOnly = true;
			this.gvCommunications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvCommunications.Size = new System.Drawing.Size(916, 292);
			this.gvCommunications.TabIndex = 15;
			this.gvCommunications.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCommunications_CellDoubleClick);
			this.gvCommunications.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.gvCommunications_RowContextMenuStripNeeded);
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "DateComm";
			this.dataGridViewTextBoxColumn3.FillWeight = 85F;
			this.dataGridViewTextBoxColumn3.HeaderText = "Date communication";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// Type
			// 
			this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Type.DataPropertyName = "Type";
			this.Type.HeaderText = "Type communication";
			this.Type.Name = "Type";
			this.Type.ReadOnly = true;
			// 
			// Motif
			// 
			this.Motif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Motif.DataPropertyName = "Motif";
			this.Motif.HeaderText = "Motif";
			this.Motif.Name = "Motif";
			this.Motif.ReadOnly = true;
			// 
			// Interlocuteur
			// 
			this.Interlocuteur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Interlocuteur.DataPropertyName = "Interlocuteur";
			this.Interlocuteur.HeaderText = "Interlocuteur";
			this.Interlocuteur.Name = "Interlocuteur";
			this.Interlocuteur.ReadOnly = true;
			// 
			// EventDate
			// 
			this.EventDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.EventDate.DataPropertyName = "DateEven";
			this.EventDate.HeaderText = "Date événement";
			this.EventDate.Name = "EventDate";
			this.EventDate.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Note";
			this.dataGridViewTextBoxColumn2.HeaderText = "Notes";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// bsDataCommunication
			// 
			this.bsDataCommunication.DataSource = typeof(ProjetMFTR.Entities.Communication);
			// 
			// pageKids
			// 
			this.pageKids.Controls.Add(this.gvKids);
			this.pageKids.Location = new System.Drawing.Point(4, 22);
			this.pageKids.Name = "pageKids";
			this.pageKids.Padding = new System.Windows.Forms.Padding(3);
			this.pageKids.Size = new System.Drawing.Size(916, 292);
			this.pageKids.TabIndex = 1;
			this.pageKids.Text = "Enfants";
			this.pageKids.UseVisualStyleBackColor = true;
			// 
			// gvKids
			// 
			this.gvKids.AllowUserToAddRows = false;
			this.gvKids.AllowUserToDeleteRows = false;
			this.gvKids.AllowUserToOrderColumns = true;
			this.gvKids.AllowUserToResizeColumns = false;
			this.gvKids.AutoGenerateColumns = false;
			this.gvKids.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gvKids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvKids.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.sexeDataGridViewTextBoxColumn,
            this.naissanceDataGridViewTextBoxColumn,
            this.accueilDataGridViewTextBoxColumn});
			this.gvKids.DataSource = this.bsDataKids;
			this.gvKids.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gvKids.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.gvKids.Location = new System.Drawing.Point(3, 3);
			this.gvKids.Name = "gvKids";
			this.gvKids.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvKids.Size = new System.Drawing.Size(910, 286);
			this.gvKids.TabIndex = 16;
			this.gvKids.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvKids_CellDoubleClick);
			// 
			// nomDataGridViewTextBoxColumn
			// 
			this.nomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
			this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
			this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
			// 
			// prenomDataGridViewTextBoxColumn
			// 
			this.prenomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
			this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
			this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
			// 
			// sexeDataGridViewTextBoxColumn
			// 
			this.sexeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.sexeDataGridViewTextBoxColumn.DataPropertyName = "Sexe";
			this.sexeDataGridViewTextBoxColumn.HeaderText = "Sexe";
			this.sexeDataGridViewTextBoxColumn.Name = "sexeDataGridViewTextBoxColumn";
			// 
			// naissanceDataGridViewTextBoxColumn
			// 
			this.naissanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.naissanceDataGridViewTextBoxColumn.DataPropertyName = "Naissance";
			this.naissanceDataGridViewTextBoxColumn.HeaderText = "Naissance";
			this.naissanceDataGridViewTextBoxColumn.Name = "naissanceDataGridViewTextBoxColumn";
			// 
			// accueilDataGridViewTextBoxColumn
			// 
			this.accueilDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.accueilDataGridViewTextBoxColumn.DataPropertyName = "Accueil";
			this.accueilDataGridViewTextBoxColumn.HeaderText = "Accueil";
			this.accueilDataGridViewTextBoxColumn.Name = "accueilDataGridViewTextBoxColumn";
			// 
			// bsDataKids
			// 
			this.bsDataKids.DataSource = typeof(ProjetMFTR.Entities.Enfants);
			// 
			// pageParents
			// 
			this.pageParents.Controls.Add(this.gvParents);
			this.pageParents.Location = new System.Drawing.Point(4, 22);
			this.pageParents.Name = "pageParents";
			this.pageParents.Padding = new System.Windows.Forms.Padding(3);
			this.pageParents.Size = new System.Drawing.Size(916, 292);
			this.pageParents.TabIndex = 0;
			this.pageParents.Text = "Parents";
			this.pageParents.UseVisualStyleBackColor = true;
			// 
			// gvParents
			// 
			this.gvParents.AllowUserToAddRows = false;
			this.gvParents.AllowUserToDeleteRows = false;
			this.gvParents.AllowUserToOrderColumns = true;
			this.gvParents.AllowUserToResizeRows = false;
			this.gvParents.AutoGenerateColumns = false;
			this.gvParents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gvParents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvParents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.SubName,
            this.sexeDataGridViewTextBoxColumn1,
            this.naissanceDataGridViewTextBoxColumn1,
            this.statutDataGridViewTextBoxColumn});
			this.gvParents.DataSource = this.bsDataParents;
			this.gvParents.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gvParents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.gvParents.Location = new System.Drawing.Point(3, 3);
			this.gvParents.Name = "gvParents";
			this.gvParents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvParents.Size = new System.Drawing.Size(910, 286);
			this.gvParents.TabIndex = 17;
			this.gvParents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvParents_CellDoubleClick);
			this.gvParents.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvParents_CellFormatting);
			this.gvParents.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.gvParents_RowContextMenuStripNeeded);
			// 
			// Nom
			// 
			this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Nom.HeaderText = "Nom";
			this.Nom.Name = "Nom";
			// 
			// SubName
			// 
			this.SubName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.SubName.HeaderText = "Prénom";
			this.SubName.Name = "SubName";
			// 
			// sexeDataGridViewTextBoxColumn1
			// 
			this.sexeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.sexeDataGridViewTextBoxColumn1.DataPropertyName = "Sexe";
			this.sexeDataGridViewTextBoxColumn1.HeaderText = "Sexe";
			this.sexeDataGridViewTextBoxColumn1.Name = "sexeDataGridViewTextBoxColumn1";
			this.sexeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// naissanceDataGridViewTextBoxColumn1
			// 
			this.naissanceDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.naissanceDataGridViewTextBoxColumn1.DataPropertyName = "Naissance";
			this.naissanceDataGridViewTextBoxColumn1.HeaderText = "Naissance";
			this.naissanceDataGridViewTextBoxColumn1.Name = "naissanceDataGridViewTextBoxColumn1";
			this.naissanceDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// statutDataGridViewTextBoxColumn
			// 
			this.statutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.statutDataGridViewTextBoxColumn.DataPropertyName = "Statut";
			this.statutDataGridViewTextBoxColumn.HeaderText = "Statut";
			this.statutDataGridViewTextBoxColumn.Name = "statutDataGridViewTextBoxColumn";
			this.statutDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// bsDataParents
			// 
			this.bsDataParents.DataSource = typeof(ProjetMFTR.Entities.Parent);
			// 
			// tb
			// 
			this.tb.Controls.Add(this.pageParents);
			this.tb.Controls.Add(this.pageKids);
			this.tb.Controls.Add(this.pageCommunication);
			this.tb.Location = new System.Drawing.Point(22, 398);
			this.tb.Name = "tb";
			this.tb.SelectedIndex = 0;
			this.tb.Size = new System.Drawing.Size(924, 318);
			this.tb.TabIndex = 14;
			// 
			// gvTelephones
			// 
			this.gvTelephones.AllowUserToAddRows = false;
			this.gvTelephones.AllowUserToDeleteRows = false;
			this.gvTelephones.AllowUserToOrderColumns = true;
			this.gvTelephones.AllowUserToResizeRows = false;
			this.gvTelephones.AutoGenerateColumns = false;
			this.gvTelephones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gvTelephones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvTelephones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TelNom,
            this.TelPrenom,
            this.typeDataGridViewTextBoxColumn1,
            this.telephone1DataGridViewTextBoxColumn,
            this.posteDataGridViewTextBoxColumn});
			this.gvTelephones.DataSource = this.bsTelephones;
			this.gvTelephones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.gvTelephones.Location = new System.Drawing.Point(963, 420);
			this.gvTelephones.Name = "gvTelephones";
			this.gvTelephones.ReadOnly = true;
			this.gvTelephones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvTelephones.Size = new System.Drawing.Size(528, 289);
			this.gvTelephones.TabIndex = 18;
			this.gvTelephones.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvTelephones_CellFormatting);
			// 
			// TelNom
			// 
			this.TelNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TelNom.HeaderText = "Nom";
			this.TelNom.Name = "TelNom";
			this.TelNom.ReadOnly = true;
			// 
			// TelPrenom
			// 
			this.TelPrenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TelPrenom.HeaderText = "Prénom";
			this.TelPrenom.Name = "TelPrenom";
			this.TelPrenom.ReadOnly = true;
			// 
			// typeDataGridViewTextBoxColumn1
			// 
			this.typeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
			this.typeDataGridViewTextBoxColumn1.HeaderText = "Type";
			this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
			this.typeDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// telephone1DataGridViewTextBoxColumn
			// 
			this.telephone1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.telephone1DataGridViewTextBoxColumn.DataPropertyName = "Telephone1";
			this.telephone1DataGridViewTextBoxColumn.HeaderText = "Téléphone";
			this.telephone1DataGridViewTextBoxColumn.Name = "telephone1DataGridViewTextBoxColumn";
			this.telephone1DataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// posteDataGridViewTextBoxColumn
			// 
			this.posteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.posteDataGridViewTextBoxColumn.DataPropertyName = "Poste";
			this.posteDataGridViewTextBoxColumn.HeaderText = "Poste";
			this.posteDataGridViewTextBoxColumn.Name = "posteDataGridViewTextBoxColumn";
			this.posteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bsTelephones
			// 
			this.bsTelephones.DataSource = typeof(ProjetMFTR.Entities.Telephone);
			// 
			// Dossier
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1503, 747);
			this.Controls.Add(this.gvTelephones);
			this.Controls.Add(this.btnSaveDossier);
			this.Controls.Add(this.btnReferents);
			this.Controls.Add(this.btnAddCommunication);
			this.Controls.Add(this.tb);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.gvList);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Dossier";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dossier";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsData)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.DossierContextMenu.ResumeLayout(false);
			this.CommunicationContextMenu.ResumeLayout(false);
			this.pageCommunication.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvCommunications)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsDataCommunication)).EndInit();
			this.pageKids.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvKids)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsDataKids)).EndInit();
			this.pageParents.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvParents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsDataParents)).EndInit();
			this.tb.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvTelephones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsTelephones)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtRechercheTelephone;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnClearFilters;
		private System.Windows.Forms.ComboBox cboFolders;
		private System.Windows.Forms.Button btnRecherche;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView gvList;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnAddCommunication;
		private System.Windows.Forms.TextBox txtDossier;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpDossier;
		private System.Windows.Forms.Button btnReferents;
		private System.Windows.Forms.RichTextBox rtxtRemarque;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cboType;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.BindingSource bsData;
		private System.Windows.Forms.BindingSource bsDataCommunication;
		private System.Windows.Forms.Button btnSaveDossier;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource bsDataKids;
		private System.Windows.Forms.BindingSource bsDataParents;
		private System.Windows.Forms.ContextMenuStrip DossierContextMenu;
		private System.Windows.Forms.ToolStripMenuItem Add_Folder;
		private System.Windows.Forms.ToolStripMenuItem Remove_Folder;
		private System.Windows.Forms.ContextMenuStrip CommunicationContextMenu;
		private System.Windows.Forms.ToolStripMenuItem Remove_Communication;
		private System.Windows.Forms.TabPage pageCommunication;
		private System.Windows.Forms.DataGridView gvCommunications;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Type;
		private System.Windows.Forms.DataGridViewTextBoxColumn Motif;
		private System.Windows.Forms.DataGridViewTextBoxColumn Interlocuteur;
		private System.Windows.Forms.DataGridViewTextBoxColumn EventDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.TabPage pageKids;
		private System.Windows.Forms.DataGridView gvKids;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sexeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn naissanceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn accueilDataGridViewTextBoxColumn;
		private System.Windows.Forms.TabPage pageParents;
		private System.Windows.Forms.DataGridView gvParents;
		private System.Windows.Forms.TabControl tb;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubName;
		private System.Windows.Forms.DataGridViewTextBoxColumn sexeDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn naissanceDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn statutDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView gvTelephones;
		private System.Windows.Forms.BindingSource bsTelephones;
		private System.Windows.Forms.DataGridViewTextBoxColumn TelNom;
		private System.Windows.Forms.DataGridViewTextBoxColumn TelPrenom;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn telephone1DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn posteDataGridViewTextBoxColumn;
	}
}