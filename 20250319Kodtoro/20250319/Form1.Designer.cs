namespace _20250319
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.txtTipp = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnTipp = new System.Windows.Forms.Button();
			this.lblSzam = new System.Windows.Forms.Label();
			this.lblTalalatok = new System.Windows.Forms.Label();
			this.lblSzabaly = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtTipp
			// 
			this.txtTipp.Location = new System.Drawing.Point(150, 61);
			this.txtTipp.Name = "txtTipp";
			this.txtTipp.Size = new System.Drawing.Size(100, 20);
			this.txtTipp.TabIndex = 0;
			this.txtTipp.TextChanged += new System.EventHandler(this.txtTipp_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Írd be a tipped";
			// 
			// btnTipp
			// 
			this.btnTipp.Location = new System.Drawing.Point(336, 57);
			this.btnTipp.Name = "btnTipp";
			this.btnTipp.Size = new System.Drawing.Size(75, 23);
			this.btnTipp.TabIndex = 2;
			this.btnTipp.Text = "Tipp";
			this.btnTipp.UseVisualStyleBackColor = true;
			this.btnTipp.Click += new System.EventHandler(this.btnTipp_Click);
			// 
			// lblSzam
			// 
			this.lblSzam.AutoSize = true;
			this.lblSzam.Location = new System.Drawing.Point(35, 13);
			this.lblSzam.Name = "lblSzam";
			this.lblSzam.Size = new System.Drawing.Size(29, 13);
			this.lblSzam.TabIndex = 3;
			this.lblSzam.Text = "label";
			this.lblSzam.Click += new System.EventHandler(this.lblSzam_Click);
			// 
			// lblTalalatok
			// 
			this.lblTalalatok.AutoSize = true;
			this.lblTalalatok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblTalalatok.Location = new System.Drawing.Point(606, 13);
			this.lblTalalatok.Name = "lblTalalatok";
			this.lblTalalatok.Size = new System.Drawing.Size(0, 24);
			this.lblTalalatok.TabIndex = 4;
			// 
			// lblSzabaly
			// 
			this.lblSzabaly.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblSzabaly.Location = new System.Drawing.Point(12, 136);
			this.lblSzabaly.Name = "lblSzabaly";
			this.lblSzabaly.Size = new System.Drawing.Size(571, 253);
			this.lblSzabaly.TabIndex = 5;
			this.lblSzabaly.Text = resources.GetString("lblSzabaly.Text");
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblSzabaly);
			this.Controls.Add(this.lblTalalatok);
			this.Controls.Add(this.lblSzam);
			this.Controls.Add(this.btnTipp);
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
		private System.Windows.Forms.Button btnTipp;
		private System.Windows.Forms.Label lblSzam;
		private System.Windows.Forms.Label lblTalalatok;
		private System.Windows.Forms.Label lblSzabaly;
	}
}

