namespace _2025._03._05
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
			this.richTextBoxSzamok = new System.Windows.Forms.RichTextBox();
			this.btnSzamgeneralas = new System.Windows.Forms.Button();
			this.btnKilep = new System.Windows.Forms.Button();
			this.btnAtlag = new System.Windows.Forms.Button();
			this.btnOsszeg = new System.Windows.Forms.Button();
			this.btnParosOsszeg = new System.Windows.Forms.Button();
			this.btnMin = new System.Windows.Forms.Button();
			this.btnMax = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// richTextBoxSzamok
			// 
			this.richTextBoxSzamok.Location = new System.Drawing.Point(12, 68);
			this.richTextBoxSzamok.Name = "richTextBoxSzamok";
			this.richTextBoxSzamok.Size = new System.Drawing.Size(100, 96);
			this.richTextBoxSzamok.TabIndex = 4;
			this.richTextBoxSzamok.Text = "";
			// 
			// btnSzamgeneralas
			// 
			this.btnSzamgeneralas.Location = new System.Drawing.Point(157, 68);
			this.btnSzamgeneralas.Name = "btnSzamgeneralas";
			this.btnSzamgeneralas.Size = new System.Drawing.Size(163, 23);
			this.btnSzamgeneralas.TabIndex = 5;
			this.btnSzamgeneralas.Text = "Számok generálása";
			this.btnSzamgeneralas.UseVisualStyleBackColor = true;
			this.btnSzamgeneralas.Click += new System.EventHandler(this.btnSzamgeneralas_Click);
			// 
			// btnKilep
			// 
			this.btnKilep.Location = new System.Drawing.Point(1, 12);
			this.btnKilep.Name = "btnKilep";
			this.btnKilep.Size = new System.Drawing.Size(75, 23);
			this.btnKilep.TabIndex = 6;
			this.btnKilep.Text = "Kilépés";
			this.btnKilep.UseVisualStyleBackColor = true;
			this.btnKilep.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnAtlag
			// 
			this.btnAtlag.Location = new System.Drawing.Point(169, 229);
			this.btnAtlag.Name = "btnAtlag";
			this.btnAtlag.Size = new System.Drawing.Size(115, 23);
			this.btnAtlag.TabIndex = 7;
			this.btnAtlag.Text = "Számok átlaga";
			this.btnAtlag.UseVisualStyleBackColor = true;
			this.btnAtlag.Click += new System.EventHandler(this.btnAtlag_Click);
			// 
			// btnOsszeg
			// 
			this.btnOsszeg.Location = new System.Drawing.Point(169, 275);
			this.btnOsszeg.Name = "btnOsszeg";
			this.btnOsszeg.Size = new System.Drawing.Size(115, 23);
			this.btnOsszeg.TabIndex = 8;
			this.btnOsszeg.Text = "Számok összege";
			this.btnOsszeg.UseVisualStyleBackColor = true;
			this.btnOsszeg.Click += new System.EventHandler(this.btnOsszeg_Click);
			// 
			// btnParosOsszeg
			// 
			this.btnParosOsszeg.Location = new System.Drawing.Point(169, 320);
			this.btnParosOsszeg.Name = "btnParosOsszeg";
			this.btnParosOsszeg.Size = new System.Drawing.Size(131, 23);
			this.btnParosOsszeg.TabIndex = 9;
			this.btnParosOsszeg.Text = "Páros számok összege";
			this.btnParosOsszeg.UseVisualStyleBackColor = true;
			this.btnParosOsszeg.Click += new System.EventHandler(this.btnParosOsszeg_Click);
			// 
			// btnMin
			// 
			this.btnMin.Location = new System.Drawing.Point(169, 368);
			this.btnMin.Name = "btnMin";
			this.btnMin.Size = new System.Drawing.Size(162, 23);
			this.btnMin.TabIndex = 10;
			this.btnMin.Text = "Legkisebb szám";
			this.btnMin.UseVisualStyleBackColor = true;
			this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
			// 
			// btnMax
			// 
			this.btnMax.Location = new System.Drawing.Point(169, 407);
			this.btnMax.Name = "btnMax";
			this.btnMax.Size = new System.Drawing.Size(162, 23);
			this.btnMax.TabIndex = 11;
			this.btnMax.Text = "Legnagyobb szám";
			this.btnMax.UseVisualStyleBackColor = true;
			this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnMax);
			this.Controls.Add(this.btnMin);
			this.Controls.Add(this.btnParosOsszeg);
			this.Controls.Add(this.btnOsszeg);
			this.Controls.Add(this.btnAtlag);
			this.Controls.Add(this.btnKilep);
			this.Controls.Add(this.btnSzamgeneralas);
			this.Controls.Add(this.richTextBoxSzamok);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.RichTextBox richTextBoxSzamok;
		private System.Windows.Forms.Button btnSzamgeneralas;
		private System.Windows.Forms.Button btnKilep;
		private System.Windows.Forms.Button btnAtlag;
		private System.Windows.Forms.Button btnOsszeg;
		private System.Windows.Forms.Button btnParosOsszeg;
		private System.Windows.Forms.Button btnMin;
		private System.Windows.Forms.Button btnMax;
	}
}

