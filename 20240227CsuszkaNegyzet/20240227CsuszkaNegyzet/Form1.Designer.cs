namespace _20240227CsuszkaNegyzet
{
	partial class Form1
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
			this.hScrollBarOldal = new System.Windows.Forms.HScrollBar();
			this.hScrollBarPiros = new System.Windows.Forms.HScrollBar();
			this.hScrollBarKék = new System.Windows.Forms.HScrollBar();
			this.hScrollBarZöld = new System.Windows.Forms.HScrollBar();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblNegyzet = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(190, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "A négyzet oldala: 0";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// hScrollBarOldal
			// 
			this.hScrollBarOldal.Location = new System.Drawing.Point(193, 87);
			this.hScrollBarOldal.Maximum = 300;
			this.hScrollBarOldal.Minimum = 10;
			this.hScrollBarOldal.Name = "hScrollBarOldal";
			this.hScrollBarOldal.Size = new System.Drawing.Size(402, 30);
			this.hScrollBarOldal.TabIndex = 2;
			this.hScrollBarOldal.Value = 10;
			this.hScrollBarOldal.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarOldal_Scroll);
			// 
			// hScrollBarPiros
			// 
			this.hScrollBarPiros.Location = new System.Drawing.Point(182, 473);
			this.hScrollBarPiros.Name = "hScrollBarPiros";
			this.hScrollBarPiros.Size = new System.Drawing.Size(422, 14);
			this.hScrollBarPiros.TabIndex = 3;
			this.hScrollBarPiros.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarPiros_Scroll);
			// 
			// hScrollBarKék
			// 
			this.hScrollBarKék.Location = new System.Drawing.Point(182, 548);
			this.hScrollBarKék.Name = "hScrollBarKék";
			this.hScrollBarKék.Size = new System.Drawing.Size(422, 14);
			this.hScrollBarKék.TabIndex = 4;
			this.hScrollBarKék.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarKék_Scroll);
			// 
			// hScrollBarZöld
			// 
			this.hScrollBarZöld.Location = new System.Drawing.Point(182, 511);
			this.hScrollBarZöld.Name = "hScrollBarZöld";
			this.hScrollBarZöld.Size = new System.Drawing.Size(422, 14);
			this.hScrollBarZöld.TabIndex = 5;
			this.hScrollBarZöld.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarZöld_Scroll);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(97, 473);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Piros";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(97, 548);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Kék";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(97, 511);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(28, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Zöld";
			// 
			// lblNegyzet
			// 
			this.lblNegyzet.BackColor = System.Drawing.Color.DarkRed;
			this.lblNegyzet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblNegyzet.Location = new System.Drawing.Point(199, 144);
			this.lblNegyzet.Name = "lblNegyzet";
			this.lblNegyzet.Size = new System.Drawing.Size(300, 300);
			this.lblNegyzet.TabIndex = 9;
			this.lblNegyzet.Click += new System.EventHandler(this.lblNegyzet_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 628);
			this.Controls.Add(this.lblNegyzet);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.hScrollBarZöld);
			this.Controls.Add(this.hScrollBarKék);
			this.Controls.Add(this.hScrollBarPiros);
			this.Controls.Add(this.hScrollBarOldal);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.HScrollBar hScrollBarOldal;
		private System.Windows.Forms.HScrollBar hScrollBarPiros;
		private System.Windows.Forms.HScrollBar hScrollBarKék;
		private System.Windows.Forms.HScrollBar hScrollBarZöld;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblNegyzet;
	}
}

