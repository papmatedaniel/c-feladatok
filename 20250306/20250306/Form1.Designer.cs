namespace _20250306
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.btnFelulre = new System.Windows.Forms.Button();
			this.btnFel = new System.Windows.Forms.Button();
			this.btnLe = new System.Windows.Forms.Button();
			this.btnAlulra = new System.Windows.Forms.Button();
			this.txtSzoveg = new System.Windows.Forms.TextBox();
			this.btnHozzaad = new System.Windows.Forms.Button();
			this.btnTorol = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(134, 128);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 95);
			this.listBox1.TabIndex = 0;
			// 
			// btnFelulre
			// 
			this.btnFelulre.Location = new System.Drawing.Point(322, 138);
			this.btnFelulre.Name = "btnFelulre";
			this.btnFelulre.Size = new System.Drawing.Size(75, 23);
			this.btnFelulre.TabIndex = 1;
			this.btnFelulre.Text = "Felülre";
			this.btnFelulre.UseVisualStyleBackColor = true;
			this.btnFelulre.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnFel
			// 
			this.btnFel.Location = new System.Drawing.Point(322, 181);
			this.btnFel.Name = "btnFel";
			this.btnFel.Size = new System.Drawing.Size(75, 23);
			this.btnFel.TabIndex = 2;
			this.btnFel.Text = "Fel";
			this.btnFel.UseVisualStyleBackColor = true;
			// 
			// btnLe
			// 
			this.btnLe.Location = new System.Drawing.Point(322, 226);
			this.btnLe.Name = "btnLe";
			this.btnLe.Size = new System.Drawing.Size(75, 23);
			this.btnLe.TabIndex = 3;
			this.btnLe.Text = "Le";
			this.btnLe.UseVisualStyleBackColor = true;
			// 
			// btnAlulra
			// 
			this.btnAlulra.Location = new System.Drawing.Point(322, 267);
			this.btnAlulra.Name = "btnAlulra";
			this.btnAlulra.Size = new System.Drawing.Size(75, 23);
			this.btnAlulra.TabIndex = 4;
			this.btnAlulra.Text = "Alulra";
			this.btnAlulra.UseVisualStyleBackColor = true;
			// 
			// txtSzoveg
			// 
			this.txtSzoveg.Location = new System.Drawing.Point(134, 87);
			this.txtSzoveg.Name = "txtSzoveg";
			this.txtSzoveg.Size = new System.Drawing.Size(120, 20);
			this.txtSzoveg.TabIndex = 5;
			// 
			// btnHozzaad
			// 
			this.btnHozzaad.Location = new System.Drawing.Point(322, 83);
			this.btnHozzaad.Name = "btnHozzaad";
			this.btnHozzaad.Size = new System.Drawing.Size(75, 23);
			this.btnHozzaad.TabIndex = 6;
			this.btnHozzaad.Text = "Hozzáad";
			this.btnHozzaad.UseVisualStyleBackColor = true;
			this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
			// 
			// btnTorol
			// 
			this.btnTorol.Enabled = false;
			this.btnTorol.Location = new System.Drawing.Point(322, 318);
			this.btnTorol.Name = "btnTorol";
			this.btnTorol.Size = new System.Drawing.Size(75, 23);
			this.btnTorol.TabIndex = 7;
			this.btnTorol.Text = "Törlés";
			this.btnTorol.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnTorol);
			this.Controls.Add(this.btnHozzaad);
			this.Controls.Add(this.txtSzoveg);
			this.Controls.Add(this.btnAlulra);
			this.Controls.Add(this.btnLe);
			this.Controls.Add(this.btnFel);
			this.Controls.Add(this.btnFelulre);
			this.Controls.Add(this.listBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button btnFelulre;
		private System.Windows.Forms.Button btnFel;
		private System.Windows.Forms.Button btnLe;
		private System.Windows.Forms.Button btnAlulra;
		private System.Windows.Forms.TextBox txtSzoveg;
		private System.Windows.Forms.Button btnHozzaad;
		private System.Windows.Forms.Button btnTorol;
	}
}

