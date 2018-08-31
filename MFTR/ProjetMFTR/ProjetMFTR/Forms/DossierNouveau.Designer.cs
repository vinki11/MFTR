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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateOuverture = new System.Windows.Forms.DateTimePicker();
            this.gbParent = new System.Windows.Forms.GroupBox();
            this.btnAddParent = new System.Windows.Forms.Button();
            this.gbEnfants = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxtRemarque = new System.Windows.Forms.RichTextBox();
            this.txtNoDossier = new System.Windows.Forms.TextBox();
            this.btnSaveAndQuit = new System.Windows.Forms.Button();
            this.btnSaveAndNew = new System.Windows.Forms.Button();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listEnfants = new System.Windows.Forms.DataGridView();
            this.btnAjouterEnfant = new System.Windows.Forms.Button();
            this.listParents = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accueilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDataKids = new System.Windows.Forms.BindingSource(this.components);
            this.sexeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naissanceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transporteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDataParents = new System.Windows.Forms.BindingSource(this.components);
            this.gbParent.SuspendLayout();
            this.gbEnfants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listEnfants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listParents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataKids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataParents)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(29, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Date d\'ouverture";
            // 
            // dtpDateOuverture
            // 
            this.dtpDateOuverture.Location = new System.Drawing.Point(117, 70);
            this.dtpDateOuverture.Name = "dtpDateOuverture";
            this.dtpDateOuverture.Size = new System.Drawing.Size(146, 20);
            this.dtpDateOuverture.TabIndex = 3;
            // 
            // gbParent
            // 
            this.gbParent.Controls.Add(this.listParents);
            this.gbParent.Location = new System.Drawing.Point(32, 116);
            this.gbParent.Name = "gbParent";
            this.gbParent.Size = new System.Drawing.Size(610, 194);
            this.gbParent.TabIndex = 14;
            this.gbParent.TabStop = false;
            this.gbParent.Text = "Parents";
            // 
            // btnAddParent
            // 
            this.btnAddParent.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddParent.Location = new System.Drawing.Point(494, 316);
            this.btnAddParent.Name = "btnAddParent";
            this.btnAddParent.Size = new System.Drawing.Size(136, 23);
            this.btnAddParent.TabIndex = 24;
            this.btnAddParent.Text = "Ajouter";
            this.btnAddParent.UseVisualStyleBackColor = false;
            this.btnAddParent.Click += new System.EventHandler(this.btnAddParent_Click);
            // 
            // gbEnfants
            // 
            this.gbEnfants.Controls.Add(this.listEnfants);
            this.gbEnfants.Location = new System.Drawing.Point(32, 330);
            this.gbEnfants.Name = "gbEnfants";
            this.gbEnfants.Size = new System.Drawing.Size(604, 224);
            this.gbEnfants.TabIndex = 15;
            this.gbEnfants.TabStop = false;
            this.gbEnfants.Text = "Enfants";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 565);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Remarques";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // rtxtRemarque
            // 
            this.rtxtRemarque.Location = new System.Drawing.Point(38, 590);
            this.rtxtRemarque.Name = "rtxtRemarque";
            this.rtxtRemarque.Size = new System.Drawing.Size(598, 78);
            this.rtxtRemarque.TabIndex = 16;
            this.rtxtRemarque.Text = "";
            this.rtxtRemarque.TextChanged += new System.EventHandler(this.rtxtRemarque_TextChanged);
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
            this.btnSaveAndQuit.Location = new System.Drawing.Point(335, 686);
            this.btnSaveAndQuit.Name = "btnSaveAndQuit";
            this.btnSaveAndQuit.Size = new System.Drawing.Size(136, 23);
            this.btnSaveAndQuit.TabIndex = 4;
            this.btnSaveAndQuit.Text = "Enregistrer et Fermer";
            this.btnSaveAndQuit.UseVisualStyleBackColor = false;
            this.btnSaveAndQuit.Click += new System.EventHandler(this.btnSaveAndQuit_Click);
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSaveAndNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAndNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndNew.Location = new System.Drawing.Point(482, 686);
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
            this.listEnfants.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.listEnfants.Location = new System.Drawing.Point(3, 16);
            this.listEnfants.Name = "listEnfants";
            this.listEnfants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listEnfants.Size = new System.Drawing.Size(598, 205);
            this.listEnfants.TabIndex = 24;
            // 
            // btnAjouterEnfant
            // 
            this.btnAjouterEnfant.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAjouterEnfant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterEnfant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterEnfant.Location = new System.Drawing.Point(482, 561);
            this.btnAjouterEnfant.Name = "btnAjouterEnfant";
            this.btnAjouterEnfant.Size = new System.Drawing.Size(136, 23);
            this.btnAjouterEnfant.TabIndex = 25;
            this.btnAjouterEnfant.Text = "Ajouter";
            this.btnAjouterEnfant.UseVisualStyleBackColor = false;
            this.btnAjouterEnfant.Click += new System.EventHandler(this.btnAjouterEnfant_Click);
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
            this.statutDataGridViewTextBoxColumn,
            this.transporteurDataGridViewTextBoxColumn});
            this.listParents.DataSource = this.bsDataParents;
            this.listParents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listParents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.listParents.Location = new System.Drawing.Point(3, 16);
            this.listParents.Name = "listParents";
            this.listParents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listParents.Size = new System.Drawing.Size(604, 175);
            this.listParents.TabIndex = 18;
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
            // DossierNouveau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 717);
            this.Controls.Add(this.btnAjouterEnfant);
            this.Controls.Add(this.btnAddParent);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveAndNew);
            this.Controls.Add(this.btnSaveAndQuit);
            this.Controls.Add(this.txtNoDossier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtxtRemarque);
            this.Controls.Add(this.gbEnfants);
            this.Controls.Add(this.gbParent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateOuverture);
            this.Name = "DossierNouveau";
            this.Text = "Nouveau Dossier";
            this.gbParent.ResumeLayout(false);
            this.gbEnfants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listEnfants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listParents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataKids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataParents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateOuverture;
        private System.Windows.Forms.GroupBox gbParent;
        private System.Windows.Forms.GroupBox gbEnfants;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxtRemarque;
        private System.Windows.Forms.TextBox txtNoDossier;
        private System.Windows.Forms.Button btnSaveAndQuit;
        private System.Windows.Forms.Button btnSaveAndNew;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.BindingSource bsDataParents;
		private System.Windows.Forms.BindingSource bsDataKids;
        private System.Windows.Forms.Button btnAddParent;
        private System.Windows.Forms.DataGridView listEnfants;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accueilDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAjouterEnfant;
        private System.Windows.Forms.DataGridView listParents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn naissanceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transporteurDataGridViewTextBoxColumn;
    }
}