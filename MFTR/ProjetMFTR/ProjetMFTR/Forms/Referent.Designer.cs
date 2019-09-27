namespace ProjetMFTR.Forms
{
	partial class Referent
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Referent));
			this.btnSaveAndNew = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.tabControl = new MetroFramework.Controls.MetroTabControl();
			this.tbInfo = new System.Windows.Forms.TabPage();
			this.txtCourriel = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtOrganisation = new System.Windows.Forms.TextBox();
			this.txtReferentId = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cboType = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPrenom = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.rtxtNotes = new System.Windows.Forms.RichTextBox();
			this.tbTel = new System.Windows.Forms.TabPage();
			this.gvPhone = new System.Windows.Forms.DataGridView();
			this.PhoneContext = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.remove_ = new System.Windows.Forms.ToolStripMenuItem();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telephone1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.posteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bsTelephone = new System.Windows.Forms.BindingSource(this.components);
			this.bsData = new System.Windows.Forms.BindingSource(this.components);
			this.tabControl.SuspendLayout();
			this.tbInfo.SuspendLayout();
			this.tbTel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvPhone)).BeginInit();
			this.PhoneContext.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsTelephone)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsData)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSaveAndNew
			// 
			this.btnSaveAndNew.BackColor = System.Drawing.Color.PaleGreen;
			this.btnSaveAndNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveAndNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveAndNew.Location = new System.Drawing.Point(574, 476);
			this.btnSaveAndNew.Name = "btnSaveAndNew";
			this.btnSaveAndNew.Size = new System.Drawing.Size(154, 23);
			this.btnSaveAndNew.TabIndex = 24;
			this.btnSaveAndNew.Text = "Enregistrer et nouvelle";
			this.btnSaveAndNew.UseVisualStyleBackColor = false;
			this.btnSaveAndNew.Click += new System.EventHandler(this.btnSaveAndNew_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(477, 476);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(84, 23);
			this.btnSave.TabIndex = 22;
			this.btnSave.Text = "Enregistrer";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tbInfo);
			this.tabControl.Controls.Add(this.tbTel);
			this.tabControl.Location = new System.Drawing.Point(12, 12);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(716, 446);
			this.tabControl.TabIndex = 42;
			this.tabControl.UseSelectable = true;
			// 
			// tbInfo
			// 
			this.tbInfo.Controls.Add(this.txtCourriel);
			this.tbInfo.Controls.Add(this.label4);
			this.tbInfo.Controls.Add(this.txtOrganisation);
			this.tbInfo.Controls.Add(this.txtReferentId);
			this.tbInfo.Controls.Add(this.label8);
			this.tbInfo.Controls.Add(this.cboType);
			this.tbInfo.Controls.Add(this.label2);
			this.tbInfo.Controls.Add(this.label1);
			this.tbInfo.Controls.Add(this.txtPrenom);
			this.tbInfo.Controls.Add(this.label3);
			this.tbInfo.Controls.Add(this.txtNom);
			this.tbInfo.Controls.Add(this.label7);
			this.tbInfo.Controls.Add(this.label6);
			this.tbInfo.Controls.Add(this.rtxtNotes);
			this.tbInfo.Location = new System.Drawing.Point(4, 38);
			this.tbInfo.Name = "tbInfo";
			this.tbInfo.Size = new System.Drawing.Size(708, 404);
			this.tbInfo.TabIndex = 0;
			this.tbInfo.Text = "Informations";
			// 
			// txtCourriel
			// 
			this.txtCourriel.Location = new System.Drawing.Point(160, 98);
			this.txtCourriel.Name = "txtCourriel";
			this.txtCourriel.Size = new System.Drawing.Size(170, 20);
			this.txtCourriel.TabIndex = 45;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(91, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 55;
			this.label4.Text = "Courriel";
			// 
			// txtOrganisation
			// 
			this.txtOrganisation.Location = new System.Drawing.Point(160, 130);
			this.txtOrganisation.Name = "txtOrganisation";
			this.txtOrganisation.Size = new System.Drawing.Size(457, 20);
			this.txtOrganisation.TabIndex = 46;
			// 
			// txtReferentId
			// 
			this.txtReferentId.Location = new System.Drawing.Point(160, 26);
			this.txtReferentId.Name = "txtReferentId";
			this.txtReferentId.Size = new System.Drawing.Size(170, 20);
			this.txtReferentId.TabIndex = 42;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(91, 29);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 13);
			this.label8.TabIndex = 54;
			this.label8.Text = "Référent";
			// 
			// cboType
			// 
			this.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboType.FormattingEnabled = true;
			this.cboType.Items.AddRange(new object[] {
            "",
            "Avocat(e)",
            "Curateur public",
            "Famille d\'accueil",
            "Intervenant(e)"});
			this.cboType.Location = new System.Drawing.Point(158, 168);
			this.cboType.Name = "cboType";
			this.cboType.Size = new System.Drawing.Size(194, 21);
			this.cboType.TabIndex = 47;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(91, 171);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 53;
			this.label2.Text = "Type";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(91, 133);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 52;
			this.label1.Text = "Organisation";
			// 
			// txtPrenom
			// 
			this.txtPrenom.Location = new System.Drawing.Point(423, 65);
			this.txtPrenom.Name = "txtPrenom";
			this.txtPrenom.Size = new System.Drawing.Size(194, 20);
			this.txtPrenom.TabIndex = 44;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(357, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 51;
			this.label3.Text = "Prénom";
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(160, 65);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(170, 20);
			this.txtNom.TabIndex = 43;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(91, 68);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 13);
			this.label7.TabIndex = 50;
			this.label7.Text = "Nom";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(91, 217);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 49;
			this.label6.Text = "Notes";
			// 
			// rtxtNotes
			// 
			this.rtxtNotes.Location = new System.Drawing.Point(94, 233);
			this.rtxtNotes.Name = "rtxtNotes";
			this.rtxtNotes.Size = new System.Drawing.Size(523, 145);
			this.rtxtNotes.TabIndex = 48;
			this.rtxtNotes.Text = "";
			// 
			// tbTel
			// 
			this.tbTel.Controls.Add(this.gvPhone);
			this.tbTel.Location = new System.Drawing.Point(4, 38);
			this.tbTel.Name = "tbTel";
			this.tbTel.Size = new System.Drawing.Size(708, 404);
			this.tbTel.TabIndex = 1;
			this.tbTel.Text = "Téléphones";
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
			this.gvPhone.Location = new System.Drawing.Point(0, 0);
			this.gvPhone.Name = "gvPhone";
			this.gvPhone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvPhone.Size = new System.Drawing.Size(708, 404);
			this.gvPhone.TabIndex = 21;
			this.gvPhone.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.gvPhone_RowContextMenuStripNeeded);
			this.gvPhone.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gvPhone_RowsAdded);
			// 
			// PhoneContext
			// 
			this.PhoneContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remove_});
			this.PhoneContext.Name = "PhoneContext";
			this.PhoneContext.Size = new System.Drawing.Size(130, 26);
			// 
			// remove_
			// 
			this.remove_.Name = "remove_";
			this.remove_.Size = new System.Drawing.Size(129, 22);
			this.remove_.Text = "Supprimer";
			this.remove_.Click += new System.EventHandler(this.remove__Click);
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
			// bsTelephone
			// 
			this.bsTelephone.DataSource = typeof(ProjetMFTR.Entities.Telephone);
			// 
			// bsData
			// 
			this.bsData.DataSource = typeof(ProjetMFTR.Entities.Communication);
			// 
			// Referent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(745, 510);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.btnSaveAndNew);
			this.Controls.Add(this.btnSave);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Referent";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Référent";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Referent_FormClosing);
			this.tabControl.ResumeLayout(false);
			this.tbInfo.ResumeLayout(false);
			this.tbInfo.PerformLayout();
			this.tbTel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvPhone)).EndInit();
			this.PhoneContext.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bsTelephone)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsData)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnSaveAndNew;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.BindingSource bsData;
		private MetroFramework.Controls.MetroTabControl tabControl;
		private System.Windows.Forms.TabPage tbInfo;
		private System.Windows.Forms.TextBox txtCourriel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtOrganisation;
		private System.Windows.Forms.TextBox txtReferentId;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cboType;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPrenom;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RichTextBox rtxtNotes;
		private System.Windows.Forms.TabPage tbTel;
		private System.Windows.Forms.BindingSource bsTelephone;
		private System.Windows.Forms.DataGridView gvPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telephone1DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn posteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn precisionDataGridViewTextBoxColumn;
		private MetroFramework.Controls.MetroContextMenu PhoneContext;
		private System.Windows.Forms.ToolStripMenuItem remove_;
	}
}