namespace Naptár
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
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.lblSzoveg = new System.Windows.Forms.Label();
			this.btnModosit = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lblNev = new System.Windows.Forms.Label();
			this.lblLeiras = new System.Windows.Forms.Label();
			this.richTextBoxleiras = new System.Windows.Forms.RichTextBox();
			this.btnTorol = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.rtxboxdatumok = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblKoviEsemenyDatuma = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.BackColor = System.Drawing.SystemColors.Window;
			this.monthCalendar1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.monthCalendar1.Location = new System.Drawing.Point(258, 81);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 0;
			this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.ControlText;
			this.monthCalendar1.TitleForeColor = System.Drawing.Color.White;
			this.monthCalendar1.TrailingForeColor = System.Drawing.SystemColors.Desktop;
			this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
			// 
			// lblSzoveg
			// 
			this.lblSzoveg.AutoSize = true;
			this.lblSzoveg.Location = new System.Drawing.Point(584, 110);
			this.lblSzoveg.Name = "lblSzoveg";
			this.lblSzoveg.Size = new System.Drawing.Size(35, 13);
			this.lblSzoveg.TabIndex = 1;
			this.lblSzoveg.Text = "label1";
			this.lblSzoveg.Click += new System.EventHandler(this.lblSzoveg_Click);
			// 
			// btnModosit
			// 
			this.btnModosit.Location = new System.Drawing.Point(587, 320);
			this.btnModosit.Name = "btnModosit";
			this.btnModosit.Size = new System.Drawing.Size(75, 23);
			this.btnModosit.TabIndex = 2;
			this.btnModosit.Text = "Mentés";
			this.btnModosit.UseVisualStyleBackColor = true;
			this.btnModosit.Click += new System.EventHandler(this.btnModosit_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(587, 152);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(201, 20);
			this.textBox1.TabIndex = 3;
			// 
			// lblNev
			// 
			this.lblNev.AutoSize = true;
			this.lblNev.Location = new System.Drawing.Point(487, 155);
			this.lblNev.Name = "lblNev";
			this.lblNev.Size = new System.Drawing.Size(80, 13);
			this.lblNev.TabIndex = 4;
			this.lblNev.Text = "Esemény neve:";
			// 
			// lblLeiras
			// 
			this.lblLeiras.AutoSize = true;
			this.lblLeiras.Location = new System.Drawing.Point(490, 199);
			this.lblLeiras.Name = "lblLeiras";
			this.lblLeiras.Size = new System.Drawing.Size(37, 13);
			this.lblLeiras.TabIndex = 5;
			this.lblLeiras.Text = "Leírás";
			// 
			// richTextBoxleiras
			// 
			this.richTextBoxleiras.Location = new System.Drawing.Point(587, 196);
			this.richTextBoxleiras.Name = "richTextBoxleiras";
			this.richTextBoxleiras.Size = new System.Drawing.Size(205, 96);
			this.richTextBoxleiras.TabIndex = 6;
			this.richTextBoxleiras.Text = "";
			// 
			// btnTorol
			// 
			this.btnTorol.Location = new System.Drawing.Point(587, 359);
			this.btnTorol.Name = "btnTorol";
			this.btnTorol.Size = new System.Drawing.Size(75, 23);
			this.btnTorol.TabIndex = 7;
			this.btnTorol.Text = "Törlés";
			this.btnTorol.UseVisualStyleBackColor = true;
			this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
			// 
			// rtxboxdatumok
			// 
			this.rtxboxdatumok.Location = new System.Drawing.Point(12, 147);
			this.rtxboxdatumok.Name = "rtxboxdatumok";
			this.rtxboxdatumok.ReadOnly = true;
			this.rtxboxdatumok.Size = new System.Drawing.Size(205, 96);
			this.rtxboxdatumok.TabIndex = 8;
			this.rtxboxdatumok.Text = "";
			this.rtxboxdatumok.TextChanged += new System.EventHandler(this.rtxboxdatumok_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Hozzáadott események";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblKoviEsemenyDatuma
			// 
			this.lblKoviEsemenyDatuma.AutoSize = true;
			this.lblKoviEsemenyDatuma.Location = new System.Drawing.Point(16, 338);
			this.lblKoviEsemenyDatuma.Name = "lblKoviEsemenyDatuma";
			this.lblKoviEsemenyDatuma.Size = new System.Drawing.Size(0, 13);
			this.lblKoviEsemenyDatuma.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 382);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "esemény neve";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 425);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "esemény leírása";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblKoviEsemenyDatuma);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rtxboxdatumok);
			this.Controls.Add(this.btnTorol);
			this.Controls.Add(this.richTextBoxleiras);
			this.Controls.Add(this.lblLeiras);
			this.Controls.Add(this.lblNev);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnModosit);
			this.Controls.Add(this.lblSzoveg);
			this.Controls.Add(this.monthCalendar1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Label lblSzoveg;
		private System.Windows.Forms.Button btnModosit;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblNev;
		private System.Windows.Forms.Label lblLeiras;
		private System.Windows.Forms.RichTextBox richTextBoxleiras;
		private System.Windows.Forms.Button btnTorol;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.RichTextBox rtxboxdatumok;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblKoviEsemenyDatuma;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}

