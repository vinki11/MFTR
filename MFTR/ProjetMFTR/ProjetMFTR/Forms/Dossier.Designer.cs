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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsData = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveDossier = new System.Windows.Forms.Button();
            this.rtxtRemarque = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtDossier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDossier = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageParents = new System.Windows.Forms.TabPage();
            this.pageKids = new System.Windows.Forms.TabPage();
            this.pageCommunication = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interlocuteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDataCommunication = new System.Windows.Forms.BindingSource(this.components);
            this.tabReferent = new System.Windows.Forms.TabPage();
            this.btnAddCommunication = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pageCommunication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataCommunication)).BeginInit();
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
            this.gvList.Size = new System.Drawing.Size(484, 231);
            this.gvList.TabIndex = 2;
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
            this.groupBox2.Controls.Add(this.btnSaveDossier);
            this.groupBox2.Controls.Add(this.rtxtRemarque);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cboType);
            this.groupBox2.Controls.Add(this.txtDossier);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpDossier);
            this.groupBox2.Location = new System.Drawing.Point(531, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 231);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dossier";
            // 
            // btnSaveDossier
            // 
            this.btnSaveDossier.BackColor = System.Drawing.Color.LightGreen;
            this.btnSaveDossier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDossier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDossier.Location = new System.Drawing.Point(532, 189);
            this.btnSaveDossier.Name = "btnSaveDossier";
            this.btnSaveDossier.Size = new System.Drawing.Size(127, 23);
            this.btnSaveDossier.TabIndex = 13;
            this.btnSaveDossier.Text = "Enregistrer";
            this.btnSaveDossier.UseVisualStyleBackColor = false;
            this.btnSaveDossier.Click += new System.EventHandler(this.btnSaveDossier_Click);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageParents);
            this.tabControl1.Controls.Add(this.pageKids);
            this.tabControl1.Controls.Add(this.pageCommunication);
            this.tabControl1.Controls.Add(this.tabReferent);
            this.tabControl1.Location = new System.Drawing.Point(22, 398);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1206, 318);
            this.tabControl1.TabIndex = 14;
            // 
            // pageParents
            // 
            this.pageParents.Location = new System.Drawing.Point(4, 22);
            this.pageParents.Name = "pageParents";
            this.pageParents.Padding = new System.Windows.Forms.Padding(3);
            this.pageParents.Size = new System.Drawing.Size(1198, 292);
            this.pageParents.TabIndex = 0;
            this.pageParents.Text = "Parents";
            this.pageParents.UseVisualStyleBackColor = true;
            // 
            // pageKids
            // 
            this.pageKids.Location = new System.Drawing.Point(4, 22);
            this.pageKids.Name = "pageKids";
            this.pageKids.Padding = new System.Windows.Forms.Padding(3);
            this.pageKids.Size = new System.Drawing.Size(1198, 292);
            this.pageKids.TabIndex = 1;
            this.pageKids.Text = "Enfants";
            this.pageKids.UseVisualStyleBackColor = true;
            // 
            // pageCommunication
            // 
            this.pageCommunication.Controls.Add(this.dataGridView1);
            this.pageCommunication.Location = new System.Drawing.Point(4, 22);
            this.pageCommunication.Name = "pageCommunication";
            this.pageCommunication.Size = new System.Drawing.Size(1198, 292);
            this.pageCommunication.TabIndex = 2;
            this.pageCommunication.Text = "Communications";
            this.pageCommunication.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.Type,
            this.Motif,
            this.Interlocuteur,
            this.EventDate,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.bsDataCommunication;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1198, 292);
            this.dataGridView1.TabIndex = 15;
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
            // tabReferent
            // 
            this.tabReferent.Location = new System.Drawing.Point(4, 22);
            this.tabReferent.Name = "tabReferent";
            this.tabReferent.Size = new System.Drawing.Size(1198, 292);
            this.tabReferent.TabIndex = 3;
            this.tabReferent.Text = "Référent";
            this.tabReferent.UseVisualStyleBackColor = true;
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
            // Dossier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 757);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.btnAddCommunication);
            this.Controls.Add(this.tabControl1);
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
            this.tabControl1.ResumeLayout(false);
            this.pageCommunication.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataCommunication)).EndInit();
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
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage pageParents;
		private System.Windows.Forms.TabPage pageKids;
		private System.Windows.Forms.TabPage pageCommunication;
		private System.Windows.Forms.Button btnAddCommunication;
		private System.Windows.Forms.TextBox txtDossier;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpDossier;
		private System.Windows.Forms.DataGridView dataGridView1;
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
	}
}