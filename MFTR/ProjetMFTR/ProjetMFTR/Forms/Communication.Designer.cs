namespace ProjetMFTR.Forms
{
	partial class Communication
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Communication));
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.count = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSaveAndNew = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cboEmployes = new System.Windows.Forms.ComboBox();
			this.rtxtNotes = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cboFolders = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cboReferent = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cboTypeCommunication = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpDateCommunication = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.dtpDateEvent = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.dtpHours = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.cboMotif = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cboInterlocuteur = new System.Windows.Forms.ComboBox();
			this.bsData = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsData)).BeginInit();
			this.SuspendLayout();
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = null;
			this.bindingNavigator1.CountItem = null;
			this.bindingNavigator1.DeleteItem = null;
			this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.count,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
			this.bindingNavigator1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
			this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator1.Name = "bindingNavigator1";
			this.bindingNavigator1.PositionItem = null;
			this.bindingNavigator1.Size = new System.Drawing.Size(856, 23);
			this.bindingNavigator1.TabIndex = 15;
			this.bindingNavigator1.Text = "bindingNavigator1";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
			this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
			this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 23);
			// 
			// count
			// 
			this.count.Name = "count";
			this.count.Size = new System.Drawing.Size(10, 15);
			this.count.Text = " ";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 23);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
			this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
			this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 23);
			// 
			// btnSaveAndNew
			// 
			this.btnSaveAndNew.BackColor = System.Drawing.Color.PaleGreen;
			this.btnSaveAndNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveAndNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveAndNew.Location = new System.Drawing.Point(688, 607);
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
			this.btnSave.Location = new System.Drawing.Point(598, 607);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(84, 23);
			this.btnSave.TabIndex = 22;
			this.btnSave.Text = "Enregistrer";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(22, 231);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 27;
			this.label6.Text = "Notes";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 545);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 13);
			this.label5.TabIndex = 26;
			this.label5.Text = "Intervenant";
			// 
			// cboEmployes
			// 
			this.cboEmployes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cboEmployes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboEmployes.FormattingEnabled = true;
			this.cboEmployes.Location = new System.Drawing.Point(25, 572);
			this.cboEmployes.Name = "cboEmployes";
			this.cboEmployes.Size = new System.Drawing.Size(209, 21);
			this.cboEmployes.TabIndex = 19;
			// 
			// rtxtNotes
			// 
			this.rtxtNotes.Location = new System.Drawing.Point(25, 247);
			this.rtxtNotes.Name = "rtxtNotes";
			this.rtxtNotes.Size = new System.Drawing.Size(796, 258);
			this.rtxtNotes.TabIndex = 21;
			this.rtxtNotes.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 13);
			this.label4.TabIndex = 25;
			this.label4.Text = "Numéro dossier";
			// 
			// cboFolders
			// 
			this.cboFolders.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cboFolders.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboFolders.FormattingEnabled = true;
			this.cboFolders.Location = new System.Drawing.Point(25, 63);
			this.cboFolders.Name = "cboFolders";
			this.cboFolders.Size = new System.Drawing.Size(163, 21);
			this.cboFolders.TabIndex = 16;
			this.cboFolders.SelectedIndexChanged += new System.EventHandler(this.cboFolders_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 13);
			this.label3.TabIndex = 23;
			this.label3.Text = "Numéro de référent";
			// 
			// cboReferent
			// 
			this.cboReferent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cboReferent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboReferent.FormattingEnabled = true;
			this.cboReferent.Location = new System.Drawing.Point(25, 116);
			this.cboReferent.Name = "cboReferent";
			this.cboReferent.Size = new System.Drawing.Size(420, 21);
			this.cboReferent.TabIndex = 18;
			this.cboReferent.SelectedIndexChanged += new System.EventHandler(this.cboReferent_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 156);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 13);
			this.label2.TabIndex = 20;
			this.label2.Text = "Type de communication";
			// 
			// cboTypeCommunication
			// 
			this.cboTypeCommunication.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cboTypeCommunication.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboTypeCommunication.FormattingEnabled = true;
			this.cboTypeCommunication.Items.AddRange(new object[] {
            "Appel fait",
            "Appel reçu",
            "Boîte vocale",
            "Courriel envoyé",
            "Courriel reçu",
            "Facebook",
            "En personne"});
			this.cboTypeCommunication.Location = new System.Drawing.Point(25, 172);
			this.cboTypeCommunication.Name = "cboTypeCommunication";
			this.cboTypeCommunication.Size = new System.Drawing.Size(209, 21);
			this.cboTypeCommunication.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(502, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 13);
			this.label1.TabIndex = 29;
			this.label1.Text = "Date de la communication";
			// 
			// dtpDateCommunication
			// 
			this.dtpDateCommunication.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateCommunication.Location = new System.Drawing.Point(505, 64);
			this.dtpDateCommunication.Name = "dtpDateCommunication";
			this.dtpDateCommunication.Size = new System.Drawing.Size(145, 20);
			this.dtpDateCommunication.TabIndex = 28;
			this.dtpDateCommunication.ValueChanged += new System.EventHandler(this.dtpDateCommunication_ValueChanged);
			this.dtpDateCommunication.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDateCommunication_KeyDown);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(502, 100);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(105, 13);
			this.label7.TabIndex = 31;
			this.label7.Text = "Date de l\'évènement";
			// 
			// dtpDateEvent
			// 
			this.dtpDateEvent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateEvent.Location = new System.Drawing.Point(505, 117);
			this.dtpDateEvent.Name = "dtpDateEvent";
			this.dtpDateEvent.Size = new System.Drawing.Size(145, 20);
			this.dtpDateEvent.TabIndex = 30;
			this.dtpDateEvent.ValueChanged += new System.EventHandler(this.dtpDateEvent_ValueChanged);
			this.dtpDateEvent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDateEvent_KeyDown);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(683, 47);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(36, 13);
			this.label8.TabIndex = 32;
			this.label8.Text = "Heure";
			// 
			// dtpHours
			// 
			this.dtpHours.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpHours.Location = new System.Drawing.Point(686, 64);
			this.dtpHours.Name = "dtpHours";
			this.dtpHours.Size = new System.Drawing.Size(81, 20);
			this.dtpHours.TabIndex = 33;
			this.dtpHours.ValueChanged += new System.EventHandler(this.dtpHours_ValueChanged);
			this.dtpHours.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpHours_KeyDown);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(294, 156);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(30, 13);
			this.label9.TabIndex = 35;
			this.label9.Text = "Motif";
			// 
			// cboMotif
			// 
			this.cboMotif.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cboMotif.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboMotif.FormattingEnabled = true;
			this.cboMotif.Items.AddRange(new object[] {
            "É-Confirmation",
            "É-Annulation",
            "VS-Confirmation",
            "VS-Annulation",
            "RV-Ouverture de dossier",
            "RV-Mise à jour de dossier",
            "RV-Confirmation",
            "RV-Annulation",
            "Demande d\'information",
            "Transmission d\'information",
            "Suivi",
            "Autre"});
			this.cboMotif.Location = new System.Drawing.Point(297, 172);
			this.cboMotif.Name = "cboMotif";
			this.cboMotif.Size = new System.Drawing.Size(148, 21);
			this.cboMotif.TabIndex = 34;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(502, 156);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(66, 13);
			this.label10.TabIndex = 37;
			this.label10.Text = "Interlocuteur";
			// 
			// cboInterlocuteur
			// 
			this.cboInterlocuteur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cboInterlocuteur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboInterlocuteur.FormattingEnabled = true;
			this.cboInterlocuteur.Location = new System.Drawing.Point(505, 172);
			this.cboInterlocuteur.Name = "cboInterlocuteur";
			this.cboInterlocuteur.Size = new System.Drawing.Size(262, 21);
			this.cboInterlocuteur.TabIndex = 36;
			// 
			// bsData
			// 
			this.bsData.DataSource = typeof(ProjetMFTR.Entities.Communication);
			this.bsData.Sort = "Communication_ID desc";
			// 
			// Communication
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(856, 639);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.cboInterlocuteur);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.cboMotif);
			this.Controls.Add(this.dtpHours);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dtpDateEvent);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpDateCommunication);
			this.Controls.Add(this.btnSaveAndNew);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cboEmployes);
			this.Controls.Add(this.rtxtNotes);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cboFolders);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cboReferent);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboTypeCommunication);
			this.Controls.Add(this.bindingNavigator1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Communication";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Communication";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Communication_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingNavigator bindingNavigator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.Button btnSaveAndNew;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboEmployes;
		private System.Windows.Forms.RichTextBox rtxtNotes;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cboFolders;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboReferent;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboTypeCommunication;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpDateCommunication;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dtpDateEvent;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker dtpHours;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cboMotif;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cboInterlocuteur;
		private System.Windows.Forms.BindingSource bsData;
		private System.Windows.Forms.ToolStripLabel count;
	}
}