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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DossierNouveau));
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpDateOuverture = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.rtxtRemarque = new System.Windows.Forms.RichTextBox();
			this.txtNoDossier = new System.Windows.Forms.TextBox();
			this.btnSaveAndQuit = new System.Windows.Forms.Button();
			this.btnSaveAndNew = new System.Windows.Forms.Button();
			this.cboType = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tc = new System.Windows.Forms.TabControl();
			this.tbFamily = new System.Windows.Forms.TabPage();
			this.btnDelEnfant = new System.Windows.Forms.Button();
			this.btnDelParent = new System.Windows.Forms.Button();
			this.btnAjouterEnfant = new System.Windows.Forms.Button();
			this.btnAddParent = new System.Windows.Forms.Button();
			this.gbEnfants = new System.Windows.Forms.GroupBox();
			this.listEnfants = new System.Windows.Forms.DataGridView();
			this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sexeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.naissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.accueilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bsDataKids = new System.Windows.Forms.BindingSource(this.components);
			this.gbParent = new System.Windows.Forms.GroupBox();
			this.listParents = new System.Windows.Forms.DataGridView();
			this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sexeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.naissanceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bsDataParents = new System.Windows.Forms.BindingSource(this.components);
			this.tbServices = new System.Windows.Forms.TabPage();
			this.btnDelServices = new System.Windows.Forms.Button();
			this.btnAddService = new System.Windows.Forms.Button();
			this.gvServices = new System.Windows.Forms.DataGridView();
			this.nomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colFrequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colJournee = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dureeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bsServices = new System.Windows.Forms.BindingSource(this.components);
			this.tc.SuspendLayout();
			this.tbFamily.SuspendLayout();
			this.gbEnfants.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.listEnfants)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsDataKids)).BeginInit();
			this.gbParent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.listParents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsDataParents)).BeginInit();
			this.tbServices.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvServices)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsServices)).BeginInit();
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
			this.label1.Location = new System.Drawing.Point(630, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Date d\'ouverture";
			// 
			// dtpDateOuverture
			// 
			this.dtpDateOuverture.Location = new System.Drawing.Point(718, 30);
			this.dtpDateOuverture.Name = "dtpDateOuverture";
			this.dtpDateOuverture.Size = new System.Drawing.Size(146, 20);
			this.dtpDateOuverture.TabIndex = 3;
			this.dtpDateOuverture.Value = new System.DateTime(2018, 9, 2, 0, 0, 0, 0);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(35, 635);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "Remarques";
			// 
			// rtxtRemarque
			// 
			this.rtxtRemarque.Location = new System.Drawing.Point(38, 651);
			this.rtxtRemarque.Name = "rtxtRemarque";
			this.rtxtRemarque.Size = new System.Drawing.Size(565, 107);
			this.rtxtRemarque.TabIndex = 16;
			this.rtxtRemarque.Text = "";
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
			this.btnSaveAndQuit.Location = new System.Drawing.Point(984, 735);
			this.btnSaveAndQuit.Name = "btnSaveAndQuit";
			this.btnSaveAndQuit.Size = new System.Drawing.Size(144, 23);
			this.btnSaveAndQuit.TabIndex = 4;
			this.btnSaveAndQuit.Text = "Enregistrer";
			this.btnSaveAndQuit.UseVisualStyleBackColor = false;
			this.btnSaveAndQuit.Click += new System.EventHandler(this.btnSaveAndQuit_Click);
			// 
			// btnSaveAndNew
			// 
			this.btnSaveAndNew.BackColor = System.Drawing.Color.PaleGreen;
			this.btnSaveAndNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveAndNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveAndNew.Location = new System.Drawing.Point(1146, 735);
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
            "",
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
			// tc
			// 
			this.tc.Controls.Add(this.tbFamily);
			this.tc.Controls.Add(this.tbServices);
			this.tc.Location = new System.Drawing.Point(32, 110);
			this.tc.Name = "tc";
			this.tc.SelectedIndex = 0;
			this.tc.Size = new System.Drawing.Size(1293, 522);
			this.tc.TabIndex = 26;
			// 
			// tbFamily
			// 
			this.tbFamily.Controls.Add(this.btnDelEnfant);
			this.tbFamily.Controls.Add(this.btnDelParent);
			this.tbFamily.Controls.Add(this.btnAjouterEnfant);
			this.tbFamily.Controls.Add(this.btnAddParent);
			this.tbFamily.Controls.Add(this.gbEnfants);
			this.tbFamily.Controls.Add(this.gbParent);
			this.tbFamily.Location = new System.Drawing.Point(4, 22);
			this.tbFamily.Name = "tbFamily";
			this.tbFamily.Padding = new System.Windows.Forms.Padding(3);
			this.tbFamily.Size = new System.Drawing.Size(1285, 496);
			this.tbFamily.TabIndex = 0;
			this.tbFamily.Text = "Famille";
			this.tbFamily.UseVisualStyleBackColor = true;
			// 
			// btnDelEnfant
			// 
			this.btnDelEnfant.BackColor = System.Drawing.Color.LightCoral;
			this.btnDelEnfant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelEnfant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelEnfant.Location = new System.Drawing.Point(948, 467);
			this.btnDelEnfant.Name = "btnDelEnfant";
			this.btnDelEnfant.Size = new System.Drawing.Size(144, 23);
			this.btnDelEnfant.TabIndex = 31;
			this.btnDelEnfant.Text = "Supprimer";
			this.btnDelEnfant.UseVisualStyleBackColor = false;
			this.btnDelEnfant.Click += new System.EventHandler(this.btnDelEnfant_Click);
			// 
			// btnDelParent
			// 
			this.btnDelParent.BackColor = System.Drawing.Color.LightCoral;
			this.btnDelParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelParent.Location = new System.Drawing.Point(948, 203);
			this.btnDelParent.Name = "btnDelParent";
			this.btnDelParent.Size = new System.Drawing.Size(144, 23);
			this.btnDelParent.TabIndex = 30;
			this.btnDelParent.Text = "Supprimer";
			this.btnDelParent.UseVisualStyleBackColor = false;
			this.btnDelParent.Click += new System.EventHandler(this.btnDelParent_Click);
			// 
			// btnAjouterEnfant
			// 
			this.btnAjouterEnfant.BackColor = System.Drawing.Color.PaleGreen;
			this.btnAjouterEnfant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAjouterEnfant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAjouterEnfant.Location = new System.Drawing.Point(1110, 467);
			this.btnAjouterEnfant.Name = "btnAjouterEnfant";
			this.btnAjouterEnfant.Size = new System.Drawing.Size(136, 23);
			this.btnAjouterEnfant.TabIndex = 29;
			this.btnAjouterEnfant.Text = "Ajouter";
			this.btnAjouterEnfant.UseVisualStyleBackColor = false;
			this.btnAjouterEnfant.Click += new System.EventHandler(this.btnAjouterEnfant_Click);
			// 
			// btnAddParent
			// 
			this.btnAddParent.BackColor = System.Drawing.Color.PaleGreen;
			this.btnAddParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddParent.Location = new System.Drawing.Point(1110, 203);
			this.btnAddParent.Name = "btnAddParent";
			this.btnAddParent.Size = new System.Drawing.Size(136, 23);
			this.btnAddParent.TabIndex = 28;
			this.btnAddParent.Text = "Ajouter";
			this.btnAddParent.UseVisualStyleBackColor = false;
			this.btnAddParent.Click += new System.EventHandler(this.btnAddParent_Click);
			// 
			// gbEnfants
			// 
			this.gbEnfants.Controls.Add(this.listEnfants);
			this.gbEnfants.Location = new System.Drawing.Point(21, 232);
			this.gbEnfants.Name = "gbEnfants";
			this.gbEnfants.Size = new System.Drawing.Size(1225, 224);
			this.gbEnfants.TabIndex = 27;
			this.gbEnfants.TabStop = false;
			this.gbEnfants.Text = "Enfants";
			// 
			// listEnfants
			// 
			this.listEnfants.AllowUserToAddRows = false;
			this.listEnfants.AllowUserToDeleteRows = false;
			this.listEnfants.AllowUserToOrderColumns = true;
			this.listEnfants.AllowUserToResizeColumns = false;
			this.listEnfants.AutoGenerateColumns = false;
			this.listEnfants.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.listEnfants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.listEnfants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.sexeDataGridViewTextBoxColumn,
            this.naissanceDataGridViewTextBoxColumn,
            this.accueilDataGridViewTextBoxColumn});
			this.listEnfants.DataSource = this.bsDataKids;
			this.listEnfants.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listEnfants.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.listEnfants.Location = new System.Drawing.Point(3, 16);
			this.listEnfants.Name = "listEnfants";
			this.listEnfants.ReadOnly = true;
			this.listEnfants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.listEnfants.Size = new System.Drawing.Size(1219, 205);
			this.listEnfants.TabIndex = 24;
			this.listEnfants.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listEnfants_CellDoubleClick);
			// 
			// nomDataGridViewTextBoxColumn
			// 
			this.nomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
			this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
			this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
			this.nomDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// prenomDataGridViewTextBoxColumn
			// 
			this.prenomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
			this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
			this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
			this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// sexeDataGridViewTextBoxColumn
			// 
			this.sexeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.sexeDataGridViewTextBoxColumn.DataPropertyName = "Sexe";
			this.sexeDataGridViewTextBoxColumn.HeaderText = "Sexe";
			this.sexeDataGridViewTextBoxColumn.Name = "sexeDataGridViewTextBoxColumn";
			this.sexeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// naissanceDataGridViewTextBoxColumn
			// 
			this.naissanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.naissanceDataGridViewTextBoxColumn.DataPropertyName = "Naissance";
			this.naissanceDataGridViewTextBoxColumn.HeaderText = "Naissance";
			this.naissanceDataGridViewTextBoxColumn.Name = "naissanceDataGridViewTextBoxColumn";
			this.naissanceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// accueilDataGridViewTextBoxColumn
			// 
			this.accueilDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.accueilDataGridViewTextBoxColumn.DataPropertyName = "Accueil";
			this.accueilDataGridViewTextBoxColumn.HeaderText = "Accueil";
			this.accueilDataGridViewTextBoxColumn.Name = "accueilDataGridViewTextBoxColumn";
			this.accueilDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bsDataKids
			// 
			this.bsDataKids.DataSource = typeof(ProjetMFTR.Entities.Enfants);
			// 
			// gbParent
			// 
			this.gbParent.Controls.Add(this.listParents);
			this.gbParent.Location = new System.Drawing.Point(15, 6);
			this.gbParent.Name = "gbParent";
			this.gbParent.Size = new System.Drawing.Size(1234, 194);
			this.gbParent.TabIndex = 26;
			this.gbParent.TabStop = false;
			this.gbParent.Text = "Parents";
			// 
			// listParents
			// 
			this.listParents.AllowUserToAddRows = false;
			this.listParents.AllowUserToDeleteRows = false;
			this.listParents.AllowUserToOrderColumns = true;
			this.listParents.AllowUserToResizeRows = false;
			this.listParents.AutoGenerateColumns = false;
			this.listParents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.listParents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.listParents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.SubName,
            this.sexeDataGridViewTextBoxColumn1,
            this.naissanceDataGridViewTextBoxColumn1,
            this.statutDataGridViewTextBoxColumn});
			this.listParents.DataSource = this.bsDataParents;
			this.listParents.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listParents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.listParents.Location = new System.Drawing.Point(3, 16);
			this.listParents.Name = "listParents";
			this.listParents.ReadOnly = true;
			this.listParents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.listParents.Size = new System.Drawing.Size(1228, 175);
			this.listParents.TabIndex = 18;
			this.listParents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listParents_CellDoubleClick);
			this.listParents.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.listParents_CellFormatting);
			// 
			// Nom
			// 
			this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Nom.HeaderText = "Nom";
			this.Nom.Name = "Nom";
			this.Nom.ReadOnly = true;
			// 
			// SubName
			// 
			this.SubName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.SubName.HeaderText = "Prénom";
			this.SubName.Name = "SubName";
			this.SubName.ReadOnly = true;
			// 
			// sexeDataGridViewTextBoxColumn1
			// 
			this.sexeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.sexeDataGridViewTextBoxColumn1.DataPropertyName = "Sexe";
			this.sexeDataGridViewTextBoxColumn1.HeaderText = "Sexe";
			this.sexeDataGridViewTextBoxColumn1.Name = "sexeDataGridViewTextBoxColumn1";
			this.sexeDataGridViewTextBoxColumn1.ReadOnly = true;
			this.sexeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// naissanceDataGridViewTextBoxColumn1
			// 
			this.naissanceDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.naissanceDataGridViewTextBoxColumn1.DataPropertyName = "Naissance";
			this.naissanceDataGridViewTextBoxColumn1.HeaderText = "Naissance";
			this.naissanceDataGridViewTextBoxColumn1.Name = "naissanceDataGridViewTextBoxColumn1";
			this.naissanceDataGridViewTextBoxColumn1.ReadOnly = true;
			this.naissanceDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// statutDataGridViewTextBoxColumn
			// 
			this.statutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.statutDataGridViewTextBoxColumn.DataPropertyName = "Statut";
			this.statutDataGridViewTextBoxColumn.HeaderText = "Statut";
			this.statutDataGridViewTextBoxColumn.Name = "statutDataGridViewTextBoxColumn";
			this.statutDataGridViewTextBoxColumn.ReadOnly = true;
			this.statutDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// bsDataParents
			// 
			this.bsDataParents.DataSource = typeof(ProjetMFTR.Entities.Parent);
			// 
			// tbServices
			// 
			this.tbServices.Controls.Add(this.btnDelServices);
			this.tbServices.Controls.Add(this.btnAddService);
			this.tbServices.Controls.Add(this.gvServices);
			this.tbServices.Location = new System.Drawing.Point(4, 22);
			this.tbServices.Name = "tbServices";
			this.tbServices.Padding = new System.Windows.Forms.Padding(3);
			this.tbServices.Size = new System.Drawing.Size(1285, 496);
			this.tbServices.TabIndex = 1;
			this.tbServices.Text = "Services";
			this.tbServices.UseVisualStyleBackColor = true;
			// 
			// btnDelServices
			// 
			this.btnDelServices.BackColor = System.Drawing.Color.LightCoral;
			this.btnDelServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelServices.Location = new System.Drawing.Point(948, 271);
			this.btnDelServices.Name = "btnDelServices";
			this.btnDelServices.Size = new System.Drawing.Size(144, 23);
			this.btnDelServices.TabIndex = 31;
			this.btnDelServices.Text = "Supprimer";
			this.btnDelServices.UseVisualStyleBackColor = false;
			this.btnDelServices.Click += new System.EventHandler(this.btnDelServices_Click);
			// 
			// btnAddService
			// 
			this.btnAddService.BackColor = System.Drawing.Color.PaleGreen;
			this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddService.Location = new System.Drawing.Point(1128, 271);
			this.btnAddService.Name = "btnAddService";
			this.btnAddService.Size = new System.Drawing.Size(136, 23);
			this.btnAddService.TabIndex = 29;
			this.btnAddService.Text = "Ajouter";
			this.btnAddService.UseVisualStyleBackColor = false;
			this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
			// 
			// gvServices
			// 
			this.gvServices.AllowUserToAddRows = false;
			this.gvServices.AllowUserToDeleteRows = false;
			this.gvServices.AutoGenerateColumns = false;
			this.gvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn1,
            this.colFrequence,
            this.colJournee,
            this.dureeDataGridViewTextBoxColumn});
			this.gvServices.DataSource = this.bsServices;
			this.gvServices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.gvServices.Location = new System.Drawing.Point(3, 6);
			this.gvServices.Name = "gvServices";
			this.gvServices.ReadOnly = true;
			this.gvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvServices.Size = new System.Drawing.Size(1261, 247);
			this.gvServices.TabIndex = 25;
			this.gvServices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvServices_CellDoubleClick);
			// 
			// nomDataGridViewTextBoxColumn1
			// 
			this.nomDataGridViewTextBoxColumn1.DataPropertyName = "Nom";
			this.nomDataGridViewTextBoxColumn1.HeaderText = "Nom";
			this.nomDataGridViewTextBoxColumn1.Name = "nomDataGridViewTextBoxColumn1";
			this.nomDataGridViewTextBoxColumn1.ReadOnly = true;
			this.nomDataGridViewTextBoxColumn1.Width = 151;
			// 
			// colFrequence
			// 
			this.colFrequence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colFrequence.DataPropertyName = "Frequence";
			this.colFrequence.HeaderText = "Frequence";
			this.colFrequence.Name = "colFrequence";
			this.colFrequence.ReadOnly = true;
			this.colFrequence.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// colJournee
			// 
			this.colJournee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colJournee.DataPropertyName = "Journee";
			this.colJournee.HeaderText = "Journee";
			this.colJournee.Name = "colJournee";
			this.colJournee.ReadOnly = true;
			this.colJournee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// dureeDataGridViewTextBoxColumn
			// 
			this.dureeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dureeDataGridViewTextBoxColumn.DataPropertyName = "Duree";
			this.dureeDataGridViewTextBoxColumn.HeaderText = "Duree";
			this.dureeDataGridViewTextBoxColumn.Name = "dureeDataGridViewTextBoxColumn";
			this.dureeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bsServices
			// 
			this.bsServices.DataSource = typeof(ProjetMFTR.Entities.Services);
			// 
			// DossierNouveau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1352, 789);
			this.Controls.Add(this.tc);
			this.Controls.Add(this.cboType);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSaveAndNew);
			this.Controls.Add(this.btnSaveAndQuit);
			this.Controls.Add(this.txtNoDossier);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.rtxtRemarque);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpDateOuverture);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DossierNouveau";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nouveau Dossier";
			this.tc.ResumeLayout(false);
			this.tbFamily.ResumeLayout(false);
			this.gbEnfants.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.listEnfants)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsDataKids)).EndInit();
			this.gbParent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.listParents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsDataParents)).EndInit();
			this.tbServices.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvServices)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsServices)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpDateOuverture;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RichTextBox rtxtRemarque;
		private System.Windows.Forms.TextBox txtNoDossier;
		private System.Windows.Forms.Button btnSaveAndQuit;
		private System.Windows.Forms.Button btnSaveAndNew;
		private System.Windows.Forms.ComboBox cboType;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.BindingSource bsDataParents;
		private System.Windows.Forms.BindingSource bsDataKids;
		private System.Windows.Forms.TabControl tc;
		private System.Windows.Forms.TabPage tbFamily;
		private System.Windows.Forms.Button btnAjouterEnfant;
		private System.Windows.Forms.Button btnAddParent;
		private System.Windows.Forms.GroupBox gbEnfants;
		private System.Windows.Forms.DataGridView listEnfants;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sexeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn naissanceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn accueilDataGridViewTextBoxColumn;
		private System.Windows.Forms.GroupBox gbParent;
		private System.Windows.Forms.DataGridView listParents;
		private System.Windows.Forms.TabPage tbServices;
		private System.Windows.Forms.BindingSource bsServices;
		private System.Windows.Forms.DataGridView gvServices;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubName;
		private System.Windows.Forms.DataGridViewTextBoxColumn sexeDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn naissanceDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn statutDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFrequence;
		private System.Windows.Forms.DataGridViewTextBoxColumn colJournee;
		private System.Windows.Forms.DataGridViewTextBoxColumn dureeDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button btnAddService;
		private System.Windows.Forms.Button btnDelEnfant;
		private System.Windows.Forms.Button btnDelParent;
		private System.Windows.Forms.Button btnDelServices;
	}
}