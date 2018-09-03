namespace ProjetMFTR.Forms
{
	partial class DeleteFolder
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteFolder));
			this.gvList = new System.Windows.Forms.DataGridView();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnDeleteFolder = new System.Windows.Forms.Button();
			this.cboFolders = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dossierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bsData = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.lblFolderCount = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsData)).BeginInit();
			this.SuspendLayout();
			// 
			// gvList
			// 
			this.gvList.AllowUserToAddRows = false;
			this.gvList.AllowUserToOrderColumns = true;
			this.gvList.AutoGenerateColumns = false;
			this.gvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dossierIDDataGridViewTextBoxColumn,
            this.Date});
			this.gvList.DataSource = this.bsData;
			this.gvList.Location = new System.Drawing.Point(37, 81);
			this.gvList.Name = "gvList";
			this.gvList.ReadOnly = true;
			this.gvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvList.Size = new System.Drawing.Size(469, 461);
			this.gvList.TabIndex = 3;
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
			// btnDeleteFolder
			// 
			this.btnDeleteFolder.BackColor = System.Drawing.Color.LightCoral;
			this.btnDeleteFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteFolder.Location = new System.Drawing.Point(362, 606);
			this.btnDeleteFolder.Name = "btnDeleteFolder";
			this.btnDeleteFolder.Size = new System.Drawing.Size(144, 23);
			this.btnDeleteFolder.TabIndex = 11;
			this.btnDeleteFolder.Text = "Supprimer";
			this.btnDeleteFolder.UseVisualStyleBackColor = false;
			this.btnDeleteFolder.Click += new System.EventHandler(this.btnDeleteFolder_Click);
			// 
			// cboFolders
			// 
			this.cboFolders.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cboFolders.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboFolders.FormattingEnabled = true;
			this.cboFolders.Location = new System.Drawing.Point(157, 32);
			this.cboFolders.Name = "cboFolders";
			this.cboFolders.Size = new System.Drawing.Size(170, 21);
			this.cboFolders.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Numéro dossier";
			// 
			// dossierIDDataGridViewTextBoxColumn
			// 
			this.dossierIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dossierIDDataGridViewTextBoxColumn.DataPropertyName = "Dossier_ID";
			this.dossierIDDataGridViewTextBoxColumn.HeaderText = "Dossier";
			this.dossierIDDataGridViewTextBoxColumn.Name = "dossierIDDataGridViewTextBoxColumn";
			this.dossierIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bsData
			// 
			this.bsData.DataSource = typeof(ProjetMFTR.Entities.Dossier);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 564);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Nombre : ";
			// 
			// lblFolderCount
			// 
			this.lblFolderCount.AutoSize = true;
			this.lblFolderCount.Location = new System.Drawing.Point(93, 564);
			this.lblFolderCount.Name = "lblFolderCount";
			this.lblFolderCount.Size = new System.Drawing.Size(10, 13);
			this.lblFolderCount.TabIndex = 15;
			this.lblFolderCount.Text = " ";
			// 
			// DeleteFolder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 638);
			this.Controls.Add(this.lblFolderCount);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cboFolders);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnDeleteFolder);
			this.Controls.Add(this.gvList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DeleteFolder";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Suppression des dossiers (datant de plus de 5 ans)";
			((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gvList;
		private System.Windows.Forms.BindingSource bsData;
		private System.Windows.Forms.DataGridViewTextBoxColumn dossierIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private System.Windows.Forms.Button btnDeleteFolder;
		private System.Windows.Forms.ComboBox cboFolders;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblFolderCount;
	}
}