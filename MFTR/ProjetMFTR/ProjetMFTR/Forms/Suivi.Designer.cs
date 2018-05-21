namespace ProjetMFTR
{
    partial class Suivi
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
			this.label1 = new System.Windows.Forms.Label();
			this.dtpDateSuivi = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.cboKids = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cboMoment = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cboFolders = new System.Windows.Forms.ComboBox();
			this.rtxtRemarque = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cboEmployes = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnSaveAndNew = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Date";
			// 
			// dtpDateSuivi
			// 
			this.dtpDateSuivi.Location = new System.Drawing.Point(98, 28);
			this.dtpDateSuivi.Name = "dtpDateSuivi";
			this.dtpDateSuivi.Size = new System.Drawing.Size(126, 20);
			this.dtpDateSuivi.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(401, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Nom de l\'enfant";
			// 
			// cboKids
			// 
			this.cboKids.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboKids.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboKids.FormattingEnabled = true;
			this.cboKids.Location = new System.Drawing.Point(491, 78);
			this.cboKids.Name = "cboKids";
			this.cboKids.Size = new System.Drawing.Size(180, 21);
			this.cboKids.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(437, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Moment";
			// 
			// cboMoment
			// 
			this.cboMoment.FormattingEnabled = true;
			this.cboMoment.Items.AddRange(new object[] {
            "Avant(VS)",
            "Après(VS)",
            "Départ(ÉG)",
            "Retour(ÉG)"});
			this.cboMoment.Location = new System.Drawing.Point(491, 123);
			this.cboMoment.Name = "cboMoment";
			this.cboMoment.Size = new System.Drawing.Size(180, 21);
			this.cboMoment.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Numéro dossier";
			// 
			// cboFolders
			// 
			this.cboFolders.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboFolders.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboFolders.FormattingEnabled = true;
			this.cboFolders.Location = new System.Drawing.Point(98, 78);
			this.cboFolders.Name = "cboFolders";
			this.cboFolders.Size = new System.Drawing.Size(209, 21);
			this.cboFolders.TabIndex = 2;
			this.cboFolders.SelectedIndexChanged += new System.EventHandler(this.cboFolders_SelectedIndexChanged);
			// 
			// rtxtRemarque
			// 
			this.rtxtRemarque.Location = new System.Drawing.Point(15, 201);
			this.rtxtRemarque.Name = "rtxtRemarque";
			this.rtxtRemarque.Size = new System.Drawing.Size(656, 258);
			this.rtxtRemarque.TabIndex = 6;
			this.rtxtRemarque.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 126);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Intervenant";
			// 
			// cboEmployes
			// 
			this.cboEmployes.FormattingEnabled = true;
			this.cboEmployes.Location = new System.Drawing.Point(98, 123);
			this.cboEmployes.Name = "cboEmployes";
			this.cboEmployes.Size = new System.Drawing.Size(209, 21);
			this.cboEmployes.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 176);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(160, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Attitude de l\'enfant / Remarques";
			// 
			// btnSaveAndNew
			// 
			this.btnSaveAndNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveAndNew.Location = new System.Drawing.Point(544, 480);
			this.btnSaveAndNew.Name = "btnSaveAndNew";
			this.btnSaveAndNew.Size = new System.Drawing.Size(127, 23);
			this.btnSaveAndNew.TabIndex = 8;
			this.btnSaveAndNew.Text = "Enregistrer et nouvelle";
			this.btnSaveAndNew.UseVisualStyleBackColor = true;
			this.btnSaveAndNew.Click += new System.EventHandler(this.btnSaveAndNew_Click);
			// 
			// btnSave
			// 
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Location = new System.Drawing.Point(440, 481);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(72, 23);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Enregistrer";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// Suivi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(683, 516);
			this.Controls.Add(this.btnSaveAndNew);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cboEmployes);
			this.Controls.Add(this.rtxtRemarque);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cboFolders);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cboMoment);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboKids);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpDateSuivi);
			this.Name = "Suivi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Déroulement de la période d’attente dans la salle (30 minutes)";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateSuivi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboKids;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMoment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboFolders;
        private System.Windows.Forms.RichTextBox rtxtRemarque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboEmployes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveAndNew;
        private System.Windows.Forms.Button btnSave;
    }
}