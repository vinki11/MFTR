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
			this.SuspendLayout();
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(47, 28);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(170, 20);
			this.txtNom.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "Nom";
			// 
			// txtPrenom
			// 
			this.txtPrenom.Location = new System.Drawing.Point(289, 28);
			this.txtPrenom.Name = "txtPrenom";
			this.txtPrenom.Size = new System.Drawing.Size(170, 20);
			this.txtPrenom.TabIndex = 18;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(240, 31);
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
			this.cboSexe.Location = new System.Drawing.Point(43, 67);
			this.cboSexe.Name = "cboSexe";
			this.cboSexe.Size = new System.Drawing.Size(174, 21);
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
			this.cboStatut.Location = new System.Drawing.Point(285, 70);
			this.cboStatut.Name = "cboStatut";
			this.cboStatut.Size = new System.Drawing.Size(174, 21);
			this.cboStatut.TabIndex = 22;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(248, 73);
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
			this.dtpNaissance.Location = new System.Drawing.Point(73, 106);
			this.dtpNaissance.Name = "dtpNaissance";
			this.dtpNaissance.Size = new System.Drawing.Size(144, 20);
			this.dtpNaissance.TabIndex = 24;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(323, 160);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(136, 23);
			this.btnSave.TabIndex = 25;
			this.btnSave.Text = "Enregistrer";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// Parent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(477, 200);
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
    }
}