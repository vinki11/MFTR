namespace ProjetMFTR.Forms
{
    partial class Intervenant
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
			this.cboIntervenant = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.btnAjouter = new System.Windows.Forms.Button();
			this.btnEnregistrer = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chbActif = new System.Windows.Forms.CheckBox();
			this.chkInactifs = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cboIntervenant
			// 
			this.cboIntervenant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboIntervenant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboIntervenant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboIntervenant.FormattingEnabled = true;
			this.cboIntervenant.Location = new System.Drawing.Point(79, 26);
			this.cboIntervenant.Name = "cboIntervenant";
			this.cboIntervenant.Size = new System.Drawing.Size(272, 21);
			this.cboIntervenant.TabIndex = 8;
			this.cboIntervenant.SelectionChangeCommitted += new System.EventHandler(this.cboIntervenant_SelectionChangeCommitted);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Intervenant";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Nom";
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(41, 31);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(295, 20);
			this.txtNom.TabIndex = 14;
			// 
			// btnAjouter
			// 
			this.btnAjouter.Location = new System.Drawing.Point(339, 223);
			this.btnAjouter.Name = "btnAjouter";
			this.btnAjouter.Size = new System.Drawing.Size(75, 23);
			this.btnAjouter.TabIndex = 15;
			this.btnAjouter.Text = "Ajouter";
			this.btnAjouter.UseVisualStyleBackColor = true;
			this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
			// 
			// btnEnregistrer
			// 
			this.btnEnregistrer.Location = new System.Drawing.Point(420, 223);
			this.btnEnregistrer.Name = "btnEnregistrer";
			this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
			this.btnEnregistrer.TabIndex = 16;
			this.btnEnregistrer.Text = "Enregistrer";
			this.btnEnregistrer.UseVisualStyleBackColor = true;
			this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chbActif);
			this.groupBox1.Controls.Add(this.txtNom);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(15, 65);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(451, 97);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Informations de l\'intervenant";
			// 
			// chbActif
			// 
			this.chbActif.AutoSize = true;
			this.chbActif.Location = new System.Drawing.Point(9, 67);
			this.chbActif.Name = "chbActif";
			this.chbActif.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chbActif.Size = new System.Drawing.Size(47, 17);
			this.chbActif.TabIndex = 15;
			this.chbActif.Text = "Actif";
			this.chbActif.UseVisualStyleBackColor = true;
			// 
			// chkInactifs
			// 
			this.chkInactifs.AutoSize = true;
			this.chkInactifs.Location = new System.Drawing.Point(368, 28);
			this.chkInactifs.Name = "chkInactifs";
			this.chkInactifs.Size = new System.Drawing.Size(98, 17);
			this.chkInactifs.TabIndex = 19;
			this.chkInactifs.Text = "Afficher inactifs";
			this.chkInactifs.UseVisualStyleBackColor = true;
			this.chkInactifs.CheckedChanged += new System.EventHandler(this.chkInactifs_CheckedChanged);
			// 
			// Intervenant
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 258);
			this.Controls.Add(this.chkInactifs);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnEnregistrer);
			this.Controls.Add(this.btnAjouter);
			this.Controls.Add(this.cboIntervenant);
			this.Controls.Add(this.label2);
			this.Name = "Intervenant";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gestion des intervenants";
			this.Load += new System.EventHandler(this.Intervenant_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboIntervenant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkInactifs;
        private System.Windows.Forms.CheckBox chbActif;
    }
}