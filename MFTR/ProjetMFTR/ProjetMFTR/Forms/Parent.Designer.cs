namespace ProjetMFTR.Forms
{
	partial class Parent
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parent));
			this.txtNom = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPrenom = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cboSexe = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cboStatut = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtUnite = new System.Windows.Forms.TextBox();
			this.txtPostalCode = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtPays = new System.Windows.Forms.TextBox();
			this.txtProvince = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtTown = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtAdresse = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.gvPhone = new System.Windows.Forms.DataGridView();
			this.ParentContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.remove_phone = new System.Windows.Forms.ToolStripMenuItem();
			this.bsTelephone = new System.Windows.Forms.BindingSource(this.components);
			this.bsAdresse = new System.Windows.Forms.BindingSource(this.components);
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telephone1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.posteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvPhone)).BeginInit();
			this.ParentContextMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsTelephone)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsAdresse)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(75, 28);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(170, 20);
			this.txtNom.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "Nom";
			// 
			// txtPrenom
			// 
			this.txtPrenom.Location = new System.Drawing.Point(338, 28);
			this.txtPrenom.Name = "txtPrenom";
			this.txtPrenom.Size = new System.Drawing.Size(194, 20);
			this.txtPrenom.TabIndex = 18;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(271, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 17;
			this.label1.Text = "Prénom";
			// 
			// cboSexe
			// 
			this.cboSexe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboSexe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboSexe.FormattingEnabled = true;
			this.cboSexe.Items.AddRange(new object[] {
            "",
            "Père",
            "Mère",
            "Grand-mère",
            "Grand-père"});
			this.cboSexe.Location = new System.Drawing.Point(75, 67);
			this.cboSexe.Name = "cboSexe";
			this.cboSexe.Size = new System.Drawing.Size(170, 21);
			this.cboSexe.TabIndex = 20;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 70);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 19;
			this.label6.Text = "Sexe";
			// 
			// cboStatut
			// 
			this.cboStatut.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboStatut.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboStatut.FormattingEnabled = true;
			this.cboStatut.Items.AddRange(new object[] {
            "",
            "Garde partagée",
            "Parent gardien",
            "Parent non gardien "});
			this.cboStatut.Location = new System.Drawing.Point(338, 67);
			this.cboStatut.Name = "cboStatut";
			this.cboStatut.Size = new System.Drawing.Size(194, 21);
			this.cboStatut.TabIndex = 22;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(271, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 21;
			this.label2.Text = "Statut";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 13);
			this.label4.TabIndex = 23;
			this.label4.Text = "Naissance";
			// 
			// dtpNaissance
			// 
			this.dtpNaissance.Location = new System.Drawing.Point(75, 106);
			this.dtpNaissance.Name = "dtpNaissance";
			this.dtpNaissance.Size = new System.Drawing.Size(170, 20);
			this.dtpNaissance.TabIndex = 24;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(1143, 443);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(136, 23);
			this.btnSave.TabIndex = 25;
			this.btnSave.Text = "Enregistrer";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtUnite);
			this.groupBox1.Controls.Add(this.txtPostalCode);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.txtPays);
			this.groupBox1.Controls.Add(this.txtProvince);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtTown);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtAdresse);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtNumero);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(9, 155);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(523, 265);
			this.groupBox1.TabIndex = 26;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Adresse";
			// 
			// txtUnite
			// 
			this.txtUnite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdresse, "Unite", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtUnite.Location = new System.Drawing.Point(265, 64);
			this.txtUnite.Name = "txtUnite";
			this.txtUnite.Size = new System.Drawing.Size(50, 20);
			this.txtUnite.TabIndex = 31;
			// 
			// txtPostalCode
			// 
			this.txtPostalCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdresse, "CodePostal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtPostalCode.Location = new System.Drawing.Point(75, 177);
			this.txtPostalCode.Name = "txtPostalCode";
			this.txtPostalCode.Size = new System.Drawing.Size(88, 20);
			this.txtPostalCode.TabIndex = 30;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 180);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(63, 13);
			this.label11.TabIndex = 29;
			this.label11.Text = "Code postal";
			// 
			// txtPays
			// 
			this.txtPays.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdresse, "Pays", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtPays.Location = new System.Drawing.Point(75, 215);
			this.txtPays.Name = "txtPays";
			this.txtPays.Size = new System.Drawing.Size(170, 20);
			this.txtPays.TabIndex = 28;
			// 
			// txtProvince
			// 
			this.txtProvince.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdresse, "Province", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtProvince.Location = new System.Drawing.Point(75, 139);
			this.txtProvince.Name = "txtProvince";
			this.txtProvince.Size = new System.Drawing.Size(88, 20);
			this.txtProvince.TabIndex = 24;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 218);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(30, 13);
			this.label10.TabIndex = 27;
			this.label10.Text = "Pays";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 142);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(49, 13);
			this.label9.TabIndex = 23;
			this.label9.Text = "Province";
			// 
			// txtTown
			// 
			this.txtTown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdresse, "Ville", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtTown.Location = new System.Drawing.Point(75, 101);
			this.txtTown.Name = "txtTown";
			this.txtTown.Size = new System.Drawing.Size(170, 20);
			this.txtTown.TabIndex = 22;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 104);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(26, 13);
			this.label8.TabIndex = 21;
			this.label8.Text = "Ville";
			// 
			// txtAdresse
			// 
			this.txtAdresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdresse, "Rue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtAdresse.Location = new System.Drawing.Point(75, 64);
			this.txtAdresse.Name = "txtAdresse";
			this.txtAdresse.Size = new System.Drawing.Size(170, 20);
			this.txtAdresse.TabIndex = 20;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 67);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 13);
			this.label7.TabIndex = 19;
			this.label7.Text = "Adresse";
			// 
			// txtNumero
			// 
			this.txtNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdresse, "Civic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtNumero.Location = new System.Drawing.Point(75, 28);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(72, 20);
			this.txtNumero.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 17;
			this.label3.Text = "Numéro";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.gvPhone);
			this.groupBox2.Location = new System.Drawing.Point(558, 155);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(721, 265);
			this.groupBox2.TabIndex = 32;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Téléphone";
			// 
			// gvPhone
			// 
			this.gvPhone.AllowUserToDeleteRows = false;
			this.gvPhone.AllowUserToOrderColumns = true;
			this.gvPhone.AllowUserToResizeRows = false;
			this.gvPhone.AutoGenerateColumns = false;
			this.gvPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gvPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvPhone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.telephone1DataGridViewTextBoxColumn,
            this.posteDataGridViewTextBoxColumn,
            this.precisionDataGridViewTextBoxColumn});
			this.gvPhone.DataSource = this.bsTelephone;
			this.gvPhone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gvPhone.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.gvPhone.Location = new System.Drawing.Point(3, 16);
			this.gvPhone.Name = "gvPhone";
			this.gvPhone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvPhone.Size = new System.Drawing.Size(715, 246);
			this.gvPhone.TabIndex = 19;
			this.gvPhone.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.listParents_RowContextMenuStripNeeded);
			this.gvPhone.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gvPhone_RowsAdded);
			// 
			// ParentContextMenu
			// 
			this.ParentContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remove_phone});
			this.ParentContextMenu.Name = "contextMenu";
			this.ParentContextMenu.Size = new System.Drawing.Size(182, 26);
			// 
			// remove_phone
			// 
			this.remove_phone.Name = "remove_phone";
			this.remove_phone.Size = new System.Drawing.Size(181, 22);
			this.remove_phone.Text = "Retirer un téléphone";
			this.remove_phone.Click += new System.EventHandler(this.remove_phone_Click);
			// 
			// bsTelephone
			// 
			this.bsTelephone.DataSource = typeof(ProjetMFTR.Entities.Telephone);
			// 
			// bsAdresse
			// 
			this.bsAdresse.DataSource = typeof(ProjetMFTR.Entities.Adresse);
			// 
			// typeDataGridViewTextBoxColumn
			// 
			this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
			this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
			this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			this.typeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// telephone1DataGridViewTextBoxColumn
			// 
			this.telephone1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.telephone1DataGridViewTextBoxColumn.DataPropertyName = "Telephone1";
			this.telephone1DataGridViewTextBoxColumn.HeaderText = "Téléphone";
			this.telephone1DataGridViewTextBoxColumn.Name = "telephone1DataGridViewTextBoxColumn";
			// 
			// posteDataGridViewTextBoxColumn
			// 
			this.posteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.posteDataGridViewTextBoxColumn.DataPropertyName = "Poste";
			this.posteDataGridViewTextBoxColumn.HeaderText = "Poste";
			this.posteDataGridViewTextBoxColumn.Name = "posteDataGridViewTextBoxColumn";
			// 
			// precisionDataGridViewTextBoxColumn
			// 
			this.precisionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.precisionDataGridViewTextBoxColumn.DataPropertyName = "Precision";
			this.precisionDataGridViewTextBoxColumn.HeaderText = "Précision";
			this.precisionDataGridViewTextBoxColumn.Name = "precisionDataGridViewTextBoxColumn";
			// 
			// Parent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1282, 478);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
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
			this.Name = "Parent";
			this.Text = "Parent";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvPhone)).EndInit();
			this.ParentContextMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bsTelephone)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsAdresse)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPrenom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboSexe;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cboStatut;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpNaissance;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtUnite;
		private System.Windows.Forms.TextBox txtPostalCode;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtPays;
		private System.Windows.Forms.TextBox txtProvince;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtTown;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtAdresse;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.BindingSource bsAdresse;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView gvPhone;
		private System.Windows.Forms.BindingSource bsTelephone;
		private System.Windows.Forms.ContextMenuStrip ParentContextMenu;
		private System.Windows.Forms.ToolStripMenuItem remove_phone;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telephone1DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn posteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn precisionDataGridViewTextBoxColumn;
	}
}