﻿namespace ProjetMFTR.Forms
{
	partial class frmSplashScreen
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
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			// 
			// metroPanel1
			// 
			this.metroPanel1.BackgroundImage = global::ProjetMFTR.Properties.Resources.images;
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 10;
			this.metroPanel1.Location = new System.Drawing.Point(171, 77);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Size = new System.Drawing.Size(329, 156);
			this.metroPanel1.TabIndex = 2;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			// 
			// metroProgressBar1
			// 
			this.metroProgressBar1.Location = new System.Drawing.Point(171, 266);
			this.metroProgressBar1.Name = "metroProgressBar1";
			this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.metroProgressBar1.Size = new System.Drawing.Size(329, 10);
			this.metroProgressBar1.TabIndex = 3;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(23, 306);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(91, 19);
			this.metroLabel1.TabIndex = 4;
			this.metroLabel1.Text = "Chargement...";
			// 
			// frmSplashScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(712, 345);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.metroProgressBar1);
			this.Controls.Add(this.metroPanel1);
			this.Name = "frmSplashScreen";
			this.Text = "Maison de la famille - Trois-Rivières";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroPanel metroPanel1;
		private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
		private MetroFramework.Controls.MetroLabel metroLabel1;
	}
}