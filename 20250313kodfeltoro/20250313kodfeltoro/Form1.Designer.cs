namespace _20250313kodfeltoro
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
			this.txtTipp = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblprobalkozasok = new System.Windows.Forms.Label();
			this.btnTipp = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtTipp
			// 
			this.txtTipp.Location = new System.Drawing.Point(185, 85);
			this.txtTipp.Name = "txtTipp";
			this.txtTipp.Size = new System.Drawing.Size(100, 20);
			this.txtTipp.TabIndex = 0;
			this.txtTipp.TextChanged += new System.EventHandler(this.txtTipp_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(62, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Írd be a tipped: ";
			// 
			// lblprobalkozasok
			// 
			this.lblprobalkozasok.AutoSize = true;
			this.lblprobalkozasok.Location = new System.Drawing.Point(62, 144);
			this.lblprobalkozasok.Name = "lblprobalkozasok";
			this.lblprobalkozasok.Size = new System.Drawing.Size(122, 13);
			this.lblprobalkozasok.TabIndex = 2;
			this.lblprobalkozasok.Text = "Próbálkozások száma: 0";
			// 
			// btnTipp
			// 
			this.btnTipp.Enabled = false;
			this.btnTipp.Location = new System.Drawing.Point(371, 82);
			this.btnTipp.Name = "btnTipp";
			this.btnTipp.Size = new System.Drawing.Size(75, 23);
			this.btnTipp.TabIndex = 3;
			this.btnTipp.Text = "Tipp";
			this.btnTipp.UseVisualStyleBackColor = true;
			this.btnTipp.Click += new System.EventHandler(this.btnTipp_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(441, 287);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "label2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnTipp);
			this.Controls.Add(this.lblprobalkozasok);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtTipp);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtTipp;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblprobalkozasok;
		private System.Windows.Forms.Button btnTipp;
		private System.Windows.Forms.Label label2;
	}
}

