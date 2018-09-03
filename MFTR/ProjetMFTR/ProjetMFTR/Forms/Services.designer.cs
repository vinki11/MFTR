namespace ProjetMFTR.Forms
{
	partial class Services
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services));
			this.btnSave = new System.Windows.Forms.Button();
			this.cboJournée = new System.Windows.Forms.ComboBox();
			this.Fréquence = new System.Windows.Forms.Label();
			this.cboFrequence = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDuree = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(350, 117);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(136, 23);
			this.btnSave.TabIndex = 36;
			this.btnSave.Text = "Enregistrer";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// cboJournée
			// 
			this.cboJournée.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboJournée.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboJournée.FormattingEnabled = true;
			this.cboJournée.Items.AddRange(new object[] {
            "",
            "Dimanche",
            "Lundi",
            "Mardi",
            "Mercredi",
            "Jeudi",
            "Vendredi",
            "Samedi"});
			this.cboJournée.Location = new System.Drawing.Point(73, 62);
			this.cboJournée.Name = "cboJournée";
			this.cboJournée.Size = new System.Drawing.Size(170, 21);
			this.cboJournée.TabIndex = 33;
			// 
			// Fréquence
			// 
			this.Fréquence.AutoSize = true;
			this.Fréquence.Location = new System.Drawing.Point(252, 68);
			this.Fréquence.Name = "Fréquence";
			this.Fréquence.Size = new System.Drawing.Size(58, 13);
			this.Fréquence.TabIndex = 32;
			this.Fréquence.Text = "Fréquence";
			// 
			// cboFrequence
			// 
			this.cboFrequence.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboFrequence.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboFrequence.FormattingEnabled = true;
			this.cboFrequence.Items.AddRange(new object[] {
            "",
            "Bimensuel                                         ",
            "Hebdomadaire                                      ",
            "Mensuel                                           ",
            "Sur demande                                       "});
			this.cboFrequence.Location = new System.Drawing.Point(316, 62);
			this.cboFrequence.Name = "cboFrequence";
			this.cboFrequence.Size = new System.Drawing.Size(170, 21);
			this.cboFrequence.TabIndex = 31;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(22, 65);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 13);
			this.label6.TabIndex = 30;
			this.label6.Text = "Journée";
			// 
			// txtDuree
			// 
			this.txtDuree.Location = new System.Drawing.Point(316, 23);
			this.txtDuree.Name = "txtDuree";
			this.txtDuree.Size = new System.Drawing.Size(170, 20);
			this.txtDuree.TabIndex = 29;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(252, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 28;
			this.label1.Text = "Durée";
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(73, 23);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(170, 20);
			this.txtNom.TabIndex = 27;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(24, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 13);
			this.label5.TabIndex = 26;
			this.label5.Text = "Nom";
			// 
			// Services
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 152);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.cboJournée);
			this.Controls.Add(this.Fréquence);
			this.Controls.Add(this.cboFrequence);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtDuree);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNom);
			this.Controls.Add(this.label5);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Services";
			this.Text = "Services";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ComboBox cboJournée;
		private System.Windows.Forms.Label Fréquence;
		private System.Windows.Forms.ComboBox cboFrequence;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtDuree;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.Label label5;
	}
}