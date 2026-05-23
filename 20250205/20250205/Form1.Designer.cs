namespace _20250205
{
	partial class Tippek
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
			this.btnHozzaad = new System.Windows.Forms.Button();
			this.lblJatekos = new System.Windows.Forms.Label();
			this.lblTipp = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.lblDb = new System.Windows.Forms.Label();
			this.btnKilep = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnHozzaad
			// 
			this.btnHozzaad.Location = new System.Drawing.Point(317, 309);
			this.btnHozzaad.Name = "btnHozzaad";
			this.btnHozzaad.Size = new System.Drawing.Size(114, 23);
			this.btnHozzaad.TabIndex = 0;
			this.btnHozzaad.Text = "Játékos hozzáadása";
			this.btnHozzaad.UseVisualStyleBackColor = true;
			this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
			// 
			// lblJatekos
			// 
			this.lblJatekos.AutoSize = true;
			this.lblJatekos.Location = new System.Drawing.Point(179, 184);
			this.lblJatekos.Name = "lblJatekos";
			this.lblJatekos.Size = new System.Drawing.Size(71, 13);
			this.lblJatekos.TabIndex = 1;
			this.lblJatekos.Text = "Játékos neve";
			// 
			// lblTipp
			// 
			this.lblTipp.AutoSize = true;
			this.lblTipp.Location = new System.Drawing.Point(183, 242);
			this.lblTipp.Name = "lblTipp";
			this.lblTipp.Size = new System.Drawing.Size(74, 13);
			this.lblTipp.TabIndex = 2;
			this.lblTipp.Text = "Játékos tippjei";
			this.lblTipp.Click += new System.EventHandler(this.lblTipp_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(284, 177);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(137, 20);
			this.textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(284, 234);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(136, 20);
			this.textBox2.TabIndex = 4;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// lblDb
			// 
			this.lblDb.AutoSize = true;
			this.lblDb.Location = new System.Drawing.Point(615, 242);
			this.lblDb.Name = "lblDb";
			this.lblDb.Size = new System.Drawing.Size(28, 13);
			this.lblDb.TabIndex = 5;
			this.lblDb.Text = "0 db";
			// 
			// btnKilep
			// 
			this.btnKilep.Location = new System.Drawing.Point(481, 308);
			this.btnKilep.Name = "btnKilep";
			this.btnKilep.Size = new System.Drawing.Size(75, 23);
			this.btnKilep.TabIndex = 6;
			this.btnKilep.Text = "Kilépés";
			this.btnKilep.UseVisualStyleBackColor = true;
			this.btnKilep.Click += new System.EventHandler(this.btnKilep_Click);
			// 
			// Tippek
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnKilep);
			this.Controls.Add(this.lblDb);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblTipp);
			this.Controls.Add(this.lblJatekos);
			this.Controls.Add(this.btnHozzaad);
			this.Name = "Tippek";
			this.Text = "Já";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnHozzaad;
		private System.Windows.Forms.Label lblJatekos;
		private System.Windows.Forms.Label lblTipp;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label lblDb;
		private System.Windows.Forms.Button btnKilep;
	}
}

