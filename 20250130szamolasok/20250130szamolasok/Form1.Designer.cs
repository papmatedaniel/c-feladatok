namespace _20250130szamolasok
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
			this.txtOldal = new System.Windows.Forms.TextBox();
			this.btnSzamol = new System.Windows.Forms.Button();
			this.lblOldal = new System.Windows.Forms.Label();
			this.btnTorol = new System.Windows.Forms.Button();
			this.btnKilep = new System.Windows.Forms.Button();
			this.lblFelszin = new System.Windows.Forms.Label();
			this.lblTerfogat = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtOldal
			// 
			this.txtOldal.Location = new System.Drawing.Point(339, 55);
			this.txtOldal.Name = "txtOldal";
			this.txtOldal.Size = new System.Drawing.Size(100, 20);
			this.txtOldal.TabIndex = 0;
			this.txtOldal.TextChanged += new System.EventHandler(this.txtOldal_TextChanged);
			// 
			// btnSzamol
			// 
			this.btnSzamol.Enabled = false;
			this.btnSzamol.Location = new System.Drawing.Point(168, 248);
			this.btnSzamol.Name = "btnSzamol";
			this.btnSzamol.Size = new System.Drawing.Size(153, 102);
			this.btnSzamol.TabIndex = 1;
			this.btnSzamol.Text = "Számolás";
			this.btnSzamol.UseVisualStyleBackColor = true;
			this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
			// 
			// lblOldal
			// 
			this.lblOldal.AutoSize = true;
			this.lblOldal.Location = new System.Drawing.Point(199, 58);
			this.lblOldal.Name = "lblOldal";
			this.lblOldal.Size = new System.Drawing.Size(78, 13);
			this.lblOldal.TabIndex = 2;
			this.lblOldal.Text = "A kocka oldala";
			// 
			// btnTorol
			// 
			this.btnTorol.Location = new System.Drawing.Point(327, 248);
			this.btnTorol.Name = "btnTorol";
			this.btnTorol.Size = new System.Drawing.Size(153, 102);
			this.btnTorol.TabIndex = 3;
			this.btnTorol.Text = "Törlés";
			this.btnTorol.UseVisualStyleBackColor = true;
			this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
			// 
			// btnKilep
			// 
			this.btnKilep.Location = new System.Drawing.Point(486, 248);
			this.btnKilep.Name = "btnKilep";
			this.btnKilep.Size = new System.Drawing.Size(153, 102);
			this.btnKilep.TabIndex = 4;
			this.btnKilep.Text = "Kilép";
			this.btnKilep.UseVisualStyleBackColor = true;
			this.btnKilep.Click += new System.EventHandler(this.button3_Click);
			// 
			// lblFelszin
			// 
			this.lblFelszin.AutoSize = true;
			this.lblFelszin.Enabled = false;
			this.lblFelszin.Location = new System.Drawing.Point(199, 94);
			this.lblFelszin.Name = "lblFelszin";
			this.lblFelszin.Size = new System.Drawing.Size(35, 13);
			this.lblFelszin.TabIndex = 5;
			this.lblFelszin.Text = "label2";
			this.lblFelszin.Visible = false;
			// 
			// lblTerfogat
			// 
			this.lblTerfogat.AutoSize = true;
			this.lblTerfogat.Location = new System.Drawing.Point(199, 141);
			this.lblTerfogat.Name = "lblTerfogat";
			this.lblTerfogat.Size = new System.Drawing.Size(35, 13);
			this.lblTerfogat.TabIndex = 6;
			this.lblTerfogat.Text = "label3";
			this.lblTerfogat.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblTerfogat);
			this.Controls.Add(this.lblFelszin);
			this.Controls.Add(this.btnKilep);
			this.Controls.Add(this.btnTorol);
			this.Controls.Add(this.lblOldal);
			this.Controls.Add(this.btnSzamol);
			this.Controls.Add(this.txtOldal);
			this.Name = "Form1";
			this.Text = "Kocka";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtOldal;
		private System.Windows.Forms.Button btnSzamol;
		private System.Windows.Forms.Label lblOldal;
		private System.Windows.Forms.Button btnTorol;
		private System.Windows.Forms.Button btnKilep;
		private System.Windows.Forms.Label lblFelszin;
		private System.Windows.Forms.Label lblTerfogat;
	}
}

