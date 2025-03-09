namespace _20250220
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
			this.txtTermek = new System.Windows.Forms.TextBox();
			this.comboKategoria = new System.Windows.Forms.ComboBox();
			this.btnHozzaad = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.btnElemTorlese = new System.Windows.Forms.Button();
			this.btnOsszestorles = new System.Windows.Forms.Button();
			this.radioButtonEtel = new System.Windows.Forms.RadioButton();
			this.radioButtonEgyebb = new System.Windows.Forms.RadioButton();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.btnSzures = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtTermek
			// 
			this.txtTermek.Location = new System.Drawing.Point(258, 91);
			this.txtTermek.Name = "txtTermek";
			this.txtTermek.Size = new System.Drawing.Size(100, 20);
			this.txtTermek.TabIndex = 0;
			// 
			// comboKategoria
			// 
			this.comboKategoria.FormattingEnabled = true;
			this.comboKategoria.Location = new System.Drawing.Point(258, 140);
			this.comboKategoria.Name = "comboKategoria";
			this.comboKategoria.Size = new System.Drawing.Size(121, 21);
			this.comboKategoria.TabIndex = 1;
			this.comboKategoria.SelectedIndexChanged += new System.EventHandler(this.comboKategoria_SelectedIndexChanged);
			// 
			// btnHozzaad
			// 
			this.btnHozzaad.Location = new System.Drawing.Point(381, 88);
			this.btnHozzaad.Name = "btnHozzaad";
			this.btnHozzaad.Size = new System.Drawing.Size(75, 23);
			this.btnHozzaad.TabIndex = 2;
			this.btnHozzaad.Text = "Hozzáad";
			this.btnHozzaad.UseVisualStyleBackColor = true;
			this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(76, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Add meg a termék nevét";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(76, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Válaszd ki a kategóriát";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(484, 64);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 95);
			this.listBox1.TabIndex = 5;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// btnElemTorlese
			// 
			this.btnElemTorlese.Location = new System.Drawing.Point(655, 64);
			this.btnElemTorlese.Name = "btnElemTorlese";
			this.btnElemTorlese.Size = new System.Drawing.Size(75, 23);
			this.btnElemTorlese.TabIndex = 6;
			this.btnElemTorlese.Text = "Elem törlése";
			this.btnElemTorlese.UseVisualStyleBackColor = true;
			this.btnElemTorlese.Click += new System.EventHandler(this.btnElemTorlese_Click);
			// 
			// btnOsszestorles
			// 
			this.btnOsszestorles.Location = new System.Drawing.Point(598, 12);
			this.btnOsszestorles.Name = "btnOsszestorles";
			this.btnOsszestorles.Size = new System.Drawing.Size(132, 23);
			this.btnOsszestorles.TabIndex = 7;
			this.btnOsszestorles.Text = "Összes elem törlése";
			this.btnOsszestorles.UseVisualStyleBackColor = true;
			this.btnOsszestorles.Click += new System.EventHandler(this.btnOsszestorles_Click);
			// 
			// radioButtonEtel
			// 
			this.radioButtonEtel.AutoSize = true;
			this.radioButtonEtel.Location = new System.Drawing.Point(655, 329);
			this.radioButtonEtel.Name = "radioButtonEtel";
			this.radioButtonEtel.Size = new System.Drawing.Size(43, 17);
			this.radioButtonEtel.TabIndex = 8;
			this.radioButtonEtel.TabStop = true;
			this.radioButtonEtel.Text = "Étel";
			this.radioButtonEtel.UseVisualStyleBackColor = true;
			// 
			// radioButtonEgyebb
			// 
			this.radioButtonEgyebb.AutoSize = true;
			this.radioButtonEgyebb.Location = new System.Drawing.Point(655, 363);
			this.radioButtonEgyebb.Name = "radioButtonEgyebb";
			this.radioButtonEgyebb.Size = new System.Drawing.Size(61, 17);
			this.radioButtonEgyebb.TabIndex = 9;
			this.radioButtonEgyebb.TabStop = true;
			this.radioButtonEgyebb.Text = "Egyébb";
			this.radioButtonEgyebb.UseVisualStyleBackColor = true;
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(484, 319);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(120, 95);
			this.listBox2.TabIndex = 10;
			// 
			// btnSzures
			// 
			this.btnSzures.Location = new System.Drawing.Point(655, 409);
			this.btnSzures.Name = "btnSzures";
			this.btnSzures.Size = new System.Drawing.Size(75, 23);
			this.btnSzures.TabIndex = 11;
			this.btnSzures.Text = "Szűrés";
			this.btnSzures.UseVisualStyleBackColor = true;
			this.btnSzures.Click += new System.EventHandler(this.btnSzures_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSzures);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.radioButtonEgyebb);
			this.Controls.Add(this.radioButtonEtel);
			this.Controls.Add(this.btnOsszestorles);
			this.Controls.Add(this.btnElemTorlese);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnHozzaad);
			this.Controls.Add(this.comboKategoria);
			this.Controls.Add(this.txtTermek);
			this.Name = "Form1";
			this.Text = "Bevásárló lista";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtTermek;
		private System.Windows.Forms.ComboBox comboKategoria;
		private System.Windows.Forms.Button btnHozzaad;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button btnElemTorlese;
		private System.Windows.Forms.Button btnOsszestorles;
		private System.Windows.Forms.RadioButton radioButtonEtel;
		private System.Windows.Forms.RadioButton radioButtonEgyebb;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Button btnSzures;
	}
}

