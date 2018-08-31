namespace ProjetMFTR.Forms
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
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tb = new System.Windows.Forms.TabControl();
            this.pageParents = new System.Windows.Forms.TabPage();
            this.gvParents = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageKids = new System.Windows.Forms.TabPage();
            this.gvKids = new System.Windows.Forms.DataGridView();
            this.pageCommunication = new System.Windows.Forms.TabPage();
            this.gvCommunications = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interlocuteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabReferent = new System.Windows.Forms.TabPage();
            this.tabServices = new System.Windows.Forms.TabPage();
            this.btnAddCommunication = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.addRow = new System.Windows.Forms.ToolStripMenuItem();
            this.sexeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naissanceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transporteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDataParents = new System.Windows.Forms.BindingSource(this.components);
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accueilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDataKids = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDataCommunication = new System.Windows.Forms.BindingSource(this.components);
            this.bsData = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsServices = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tb.SuspendLayout();
            this.pageParents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvParents)).BeginInit();
            this.pageKids.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvKids)).BeginInit();
            this.pageCommunication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCommunications)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataParents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataKids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataCommunication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServices)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(1206, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Critères de recherche";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(373, 34);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(170, 20);
            this.txtFirstName.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Prénom";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(640, 34);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(170, 20);
            this.txtLastName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nom";
            // 
            // txtRechercheTelephone
            // 
            this.txtRechercheTelephone.Location = new System.Drawing.Point(1017, 34);
            this.txtRechercheTelephone.Name = "txtRechercheTelephone";
            this.txtRechercheTelephone.Size = new System.Drawing.Size(170, 20);
            this.txtRechercheTelephone.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(876, 37);
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
            this.cboFolders.TabIndex = 6;
            // 
            // btnRecherche
            // 
            this.btnRecherche.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecherche.Location = new System.Drawing.Point(1060, 67);
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
            this.label2.Location = new System.Drawing.Point(17, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numéro dossier";
            // 
            // gvList
            // 
            this.gvList.AllowUserToAddRows = false;
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
            this.gvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvList_CellContentClick);
            this.gvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvList_CellDoubleClick);
            this.gvList.SelectionChanged += new System.EventHandler(this.gvList_SelectionChanged);
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
            this.groupBox2.Size = new System.Drawing.Size(697, 231);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dossier";
            // 
            // rtxtRemarque
            // 
            this.rtxtRemarque.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsData, "Remarque", true));
            this.rtxtRemarque.Location = new System.Drawing.Point(121, 87);
            this.rtxtRemarque.Name = "rtxtRemarque";
            this.rtxtRemarque.Size = new System.Drawing.Size(538, 96);
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
            this.cboType.Location = new System.Drawing.Point(440, 22);
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
            this.label6.Location = new System.Drawing.Point(382, 25);
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
            this.btnSaveDossier.Location = new System.Drawing.Point(1101, 718);
            this.btnSaveDossier.Name = "btnSaveDossier";
            this.btnSaveDossier.Size = new System.Drawing.Size(127, 23);
            this.btnSaveDossier.TabIndex = 13;
            this.btnSaveDossier.Text = "Enregistrer";
            this.btnSaveDossier.UseVisualStyleBackColor = false;
            this.btnSaveDossier.Visible = false;
            this.btnSaveDossier.Click += new System.EventHandler(this.btnSaveDossier_Click);
            // 
            // tb
            // 
            this.tb.Controls.Add(this.pageParents);
            this.tb.Controls.Add(this.pageKids);
            this.tb.Controls.Add(this.pageCommunication);
            this.tb.Controls.Add(this.tabReferent);
            this.tb.Controls.Add(this.tabServices);
            this.tb.Location = new System.Drawing.Point(22, 398);
            this.tb.Name = "tb";
            this.tb.SelectedIndex = 0;
            this.tb.Size = new System.Drawing.Size(1206, 318);
            this.tb.TabIndex = 14;
            // 
            // pageParents
            // 
            this.pageParents.Controls.Add(this.gvParents);
            this.pageParents.Location = new System.Drawing.Point(4, 22);
            this.pageParents.Name = "pageParents";
            this.pageParents.Padding = new System.Windows.Forms.Padding(3);
            this.pageParents.Size = new System.Drawing.Size(1198, 292);
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
            this.statutDataGridViewTextBoxColumn,
            this.transporteurDataGridViewTextBoxColumn});
            this.gvParents.DataSource = this.bsDataParents;
            this.gvParents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvParents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvParents.Location = new System.Drawing.Point(3, 3);
            this.gvParents.Name = "gvParents";
            this.gvParents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvParents.Size = new System.Drawing.Size(1192, 286);
            this.gvParents.TabIndex = 17;
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
            // pageKids
            // 
            this.pageKids.Controls.Add(this.gvKids);
            this.pageKids.Location = new System.Drawing.Point(4, 22);
            this.pageKids.Name = "pageKids";
            this.pageKids.Padding = new System.Windows.Forms.Padding(3);
            this.pageKids.Size = new System.Drawing.Size(1198, 292);
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
            this.gvKids.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gvKids.Location = new System.Drawing.Point(3, 3);
            this.gvKids.Name = "gvKids";
            this.gvKids.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvKids.Size = new System.Drawing.Size(1192, 286);
            this.gvKids.TabIndex = 16;
            // 
            // pageCommunication
            // 
            this.pageCommunication.Controls.Add(this.gvCommunications);
            this.pageCommunication.Location = new System.Drawing.Point(4, 22);
            this.pageCommunication.Name = "pageCommunication";
            this.pageCommunication.Size = new System.Drawing.Size(1198, 292);
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
            this.gvCommunications.Location = new System.Drawing.Point(0, 0);
            this.gvCommunications.Name = "gvCommunications";
            this.gvCommunications.ReadOnly = true;
            this.gvCommunications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCommunications.Size = new System.Drawing.Size(1198, 292);
            this.gvCommunications.TabIndex = 15;
            this.gvCommunications.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCommunications_CellDoubleClick);
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
            // tabReferent
            // 
            this.tabReferent.Location = new System.Drawing.Point(4, 22);
            this.tabReferent.Name = "tabReferent";
            this.tabReferent.Size = new System.Drawing.Size(1198, 292);
            this.tabReferent.TabIndex = 3;
            this.tabReferent.Text = "Référent";
            this.tabReferent.UseVisualStyleBackColor = true;
            // 
            // tabServices
            // 
            this.tabServices.Location = new System.Drawing.Point(4, 22);
            this.tabServices.Name = "tabServices";
            this.tabServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabServices.Size = new System.Drawing.Size(1198, 292);
            this.tabServices.TabIndex = 4;
            this.tabServices.Text = "Services";
            this.tabServices.UseVisualStyleBackColor = true;
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
            // btnAddFolder
            // 
            this.btnAddFolder.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFolder.Location = new System.Drawing.Point(212, 722);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(164, 23);
            this.btnAddFolder.TabIndex = 15;
            this.btnAddFolder.Text = "Nouveau dossier";
            this.btnAddFolder.UseVisualStyleBackColor = false;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRow,
            this.addRow});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(130, 48);
            // 
            // deleteRow
            // 
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(129, 22);
            this.deleteRow.Text = "Supprimer";
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // addRow
            // 
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(129, 22);
            this.addRow.Text = "Ajouter";
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
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
            // transporteurDataGridViewTextBoxColumn
            // 
            this.transporteurDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.transporteurDataGridViewTextBoxColumn.DataPropertyName = "Transporteur";
            this.transporteurDataGridViewTextBoxColumn.HeaderText = "Transporteur";
            this.transporteurDataGridViewTextBoxColumn.Name = "transporteurDataGridViewTextBoxColumn";
            // 
            // bsDataParents
            // 
            this.bsDataParents.DataSource = typeof(ProjetMFTR.Entities.Parent);
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
            // bsData
            // 
            this.bsData.DataSource = typeof(ProjetMFTR.Entities.Dossier);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Dossier_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Dossier";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsServices
            // 
            this.bsServices.DataSource = typeof(ProjetMFTR.Entities.Services);
            // 
            // Dossier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 757);
            this.Controls.Add(this.btnSaveDossier);
            this.Controls.Add(this.btnAddFolder);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tb.ResumeLayout(false);
            this.pageParents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvParents)).EndInit();
            this.pageKids.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvKids)).EndInit();
            this.pageCommunication.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCommunications)).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsDataParents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataKids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataCommunication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServices)).EndInit();
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
		private System.Windows.Forms.TabControl tb;
		private System.Windows.Forms.TabPage pageParents;
		private System.Windows.Forms.TabPage pageKids;
		private System.Windows.Forms.TabPage pageCommunication;
		private System.Windows.Forms.Button btnAddCommunication;
		private System.Windows.Forms.TextBox txtDossier;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpDossier;
		private System.Windows.Forms.DataGridView gvCommunications;
		private System.Windows.Forms.Button btnAddFolder;
		private System.Windows.Forms.RichTextBox rtxtRemarque;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cboType;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.BindingSource bsData;
		private System.Windows.Forms.BindingSource bsDataCommunication;
		private System.Windows.Forms.Button btnSaveDossier;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Type;
		private System.Windows.Forms.DataGridViewTextBoxColumn Motif;
		private System.Windows.Forms.DataGridViewTextBoxColumn Interlocuteur;
		private System.Windows.Forms.DataGridViewTextBoxColumn EventDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private System.Windows.Forms.TabPage tabReferent;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource bsDataKids;
		private System.Windows.Forms.DataGridView gvKids;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sexeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn naissanceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn accueilDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView gvParents;
		private System.Windows.Forms.BindingSource bsDataParents;
		private System.Windows.Forms.TabPage tabServices;
		private System.Windows.Forms.BindingSource bsServices;
		private System.Windows.Forms.ContextMenuStrip contextMenu;
		private System.Windows.Forms.ToolStripMenuItem deleteRow;
		private System.Windows.Forms.ToolStripMenuItem addRow;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubName;
		private System.Windows.Forms.DataGridViewTextBoxColumn sexeDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn naissanceDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn statutDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn transporteurDataGridViewTextBoxColumn;
	}
}