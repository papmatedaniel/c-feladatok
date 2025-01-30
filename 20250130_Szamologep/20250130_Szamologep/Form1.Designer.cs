namespace _20250130_Szamologep
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtAdat1 = new System.Windows.Forms.TextBox();
			this.txtAdat2 = new System.Windows.Forms.TextBox();
			this.lblMuvelet = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEredmeny = new System.Windows.Forms.TextBox();
			this.btnOsszead = new System.Windows.Forms.Button();
			this.btnKivon = new System.Windows.Forms.Button();
			this.btnSzoroz = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(101, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Adat1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(101, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Adat2";
			// 
			// txtAdat1
			// 
			this.txtAdat1.Location = new System.Drawing.Point(166, 86);
			this.txtAdat1.Name = "txtAdat1";
			this.txtAdat1.Size = new System.Drawing.Size(100, 20);
			this.txtAdat1.TabIndex = 2;
			this.txtAdat1.TextChanged += new System.EventHandler(this.txtAdat1_TextChanged);
			// 
			// txtAdat2
			// 
			this.txtAdat2.Location = new System.Drawing.Point(166, 133);
			this.txtAdat2.Name = "txtAdat2";
			this.txtAdat2.Size = new System.Drawing.Size(100, 20);
			this.txtAdat2.TabIndex = 3;
			this.txtAdat2.TextChanged += new System.EventHandler(this.txtAdat2_TextChanged);
			// 
			// lblMuvelet
			// 
			this.lblMuvelet.AutoSize = true;
			this.lblMuvelet.Location = new System.Drawing.Point(369, 218);
			this.lblMuvelet.Name = "lblMuvelet";
			this.lblMuvelet.Size = new System.Drawing.Size(51, 13);
			this.lblMuvelet.TabIndex = 4;
			this.lblMuvelet.Text = "Művelet: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(287, 267);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Eredmény";
			// 
			// txtEredmeny
			// 
			this.txtEredmeny.Location = new System.Drawing.Point(356, 264);
			this.txtEredmeny.Name = "txtEredmeny";
			this.txtEredmeny.Size = new System.Drawing.Size(100, 20);
			this.txtEredmeny.TabIndex = 6;
			// 
			// btnOsszead
			// 
			this.btnOsszead.Location = new System.Drawing.Point(135, 189);
			this.btnOsszead.Name = "btnOsszead";
			this.btnOsszead.Size = new System.Drawing.Size(75, 23);
			this.btnOsszead.TabIndex = 7;
			this.btnOsszead.Text = "Összeadás";
			this.btnOsszead.UseVisualStyleBackColor = true;
			this.btnOsszead.Click += new System.EventHandler(this.btnOsszead_Click);
			// 
			// btnKivon
			// 
			this.btnKivon.Location = new System.Drawing.Point(135, 238);
			this.btnKivon.Name = "btnKivon";
			this.btnKivon.Size = new System.Drawing.Size(75, 23);
			this.btnKivon.TabIndex = 8;
			this.btnKivon.Text = "Kivonás";
			this.btnKivon.UseVisualStyleBackColor = true;
			this.btnKivon.Click += new System.EventHandler(this.btnKivon_Click);
			// 
			// btnSzoroz
			// 
			this.btnSzoroz.Location = new System.Drawing.Point(135, 286);
			this.btnSzoroz.Name = "btnSzoroz";
			this.btnSzoroz.Size = new System.Drawing.Size(75, 23);
			this.btnSzoroz.TabIndex = 9;
			this.btnSzoroz.Text = "Szorzás";
			this.btnSzoroz.UseVisualStyleBackColor = true;
			this.btnSzoroz.Click += new System.EventHandler(this.btnSzoroz_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSzoroz);
			this.Controls.Add(this.btnKivon);
			this.Controls.Add(this.btnOsszead);
			this.Controls.Add(this.txtEredmeny);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblMuvelet);
			this.Controls.Add(this.txtAdat2);
			this.Controls.Add(this.txtAdat1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Műveletek";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAdat1;
		private System.Windows.Forms.TextBox txtAdat2;
		private System.Windows.Forms.Label lblMuvelet;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEredmeny;
		private System.Windows.Forms.Button btnOsszead;
		private System.Windows.Forms.Button btnKivon;
		private System.Windows.Forms.Button btnSzoroz;
	}
}

