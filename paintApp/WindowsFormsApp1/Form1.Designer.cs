
namespace PaintApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.BtnEraser = new System.Windows.Forms.Button();
            this.BtnPaint = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnErase = new System.Windows.Forms.Button();
            this.BtnRectangle = new System.Windows.Forms.Button();
            this.BtnElipse = new System.Windows.Forms.Button();
            this.BtnLine = new System.Windows.Forms.Button();
            this.BtnPencil = new System.Windows.Forms.Button();
            this.BtnColor = new System.Windows.Forms.Button();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.BtnEraser);
            this.panel1.Controls.Add(this.BtnPaint);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.BtnErase);
            this.panel1.Controls.Add(this.BtnRectangle);
            this.panel1.Controls.Add(this.BtnElipse);
            this.panel1.Controls.Add(this.BtnLine);
            this.panel1.Controls.Add(this.BtnPencil);
            this.panel1.Controls.Add(this.BtnColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 68);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 56);
            this.button1.TabIndex = 13;
            this.button1.Text = "Airbrush";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ecset";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Vonal";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(63, 42);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown2.TabIndex = 10;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(63, 6);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // BtnEraser
            // 
            this.BtnEraser.Location = new System.Drawing.Point(517, 6);
            this.BtnEraser.Name = "BtnEraser";
            this.BtnEraser.Size = new System.Drawing.Size(59, 56);
            this.BtnEraser.TabIndex = 8;
            this.BtnEraser.Text = "Radír";
            this.BtnEraser.UseVisualStyleBackColor = true;
            this.BtnEraser.Click += new System.EventHandler(this.BtnEraser_Click);
            // 
            // BtnPaint
            // 
            this.BtnPaint.Location = new System.Drawing.Point(452, 6);
            this.BtnPaint.Name = "BtnPaint";
            this.BtnPaint.Size = new System.Drawing.Size(59, 56);
            this.BtnPaint.TabIndex = 7;
            this.BtnPaint.Text = "Kitöétés";
            this.BtnPaint.UseVisualStyleBackColor = true;
            this.BtnPaint.Click += new System.EventHandler(this.BtnPaint_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(729, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(59, 56);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Kép mentése";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnErase
            // 
            this.BtnErase.Location = new System.Drawing.Point(664, 6);
            this.BtnErase.Name = "BtnErase";
            this.BtnErase.Size = new System.Drawing.Size(59, 56);
            this.BtnErase.TabIndex = 5;
            this.BtnErase.Text = "Vászon Törlés";
            this.BtnErase.UseVisualStyleBackColor = true;
            this.BtnErase.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnRectangle
            // 
            this.BtnRectangle.Location = new System.Drawing.Point(387, 6);
            this.BtnRectangle.Name = "BtnRectangle";
            this.BtnRectangle.Size = new System.Drawing.Size(59, 56);
            this.BtnRectangle.TabIndex = 4;
            this.BtnRectangle.Text = "Négyszög";
            this.BtnRectangle.UseVisualStyleBackColor = true;
            this.BtnRectangle.Click += new System.EventHandler(this.BtnRectangle_Click);
            // 
            // BtnElipse
            // 
            this.BtnElipse.Location = new System.Drawing.Point(322, 6);
            this.BtnElipse.Name = "BtnElipse";
            this.BtnElipse.Size = new System.Drawing.Size(59, 56);
            this.BtnElipse.TabIndex = 3;
            this.BtnElipse.Text = "Elipszis";
            this.BtnElipse.UseVisualStyleBackColor = true;
            this.BtnElipse.Click += new System.EventHandler(this.BtnEllipse_Click);
            // 
            // BtnLine
            // 
            this.BtnLine.Location = new System.Drawing.Point(257, 6);
            this.BtnLine.Name = "BtnLine";
            this.BtnLine.Size = new System.Drawing.Size(59, 56);
            this.BtnLine.TabIndex = 2;
            this.BtnLine.Text = "Vonal";
            this.BtnLine.UseVisualStyleBackColor = true;
            this.BtnLine.Click += new System.EventHandler(this.BtnLine_Click);
            // 
            // BtnPencil
            // 
            this.BtnPencil.Location = new System.Drawing.Point(192, 6);
            this.BtnPencil.Name = "BtnPencil";
            this.BtnPencil.Size = new System.Drawing.Size(59, 56);
            this.BtnPencil.TabIndex = 1;
            this.BtnPencil.Text = "Ceruza";
            this.BtnPencil.UseVisualStyleBackColor = true;
            this.BtnPencil.Click += new System.EventHandler(this.BtnPencil_Click);
            // 
            // BtnColor
            // 
            this.BtnColor.Location = new System.Drawing.Point(127, 6);
            this.BtnColor.Margin = new System.Windows.Forms.Padding(5);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Padding = new System.Windows.Forms.Padding(2);
            this.BtnColor.Size = new System.Drawing.Size(59, 56);
            this.BtnColor.TabIndex = 0;
            this.BtnColor.Text = "Eszköz színe";
            this.BtnColor.UseVisualStyleBackColor = true;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // Pic
            // 
            this.Pic.BackColor = System.Drawing.Color.White;
            this.Pic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pic.Location = new System.Drawing.Point(0, 135);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(798, 382);
            this.Pic.TabIndex = 1;
            this.Pic.TabStop = false;
            this.Pic.Paint += new System.Windows.Forms.PaintEventHandler(this.Pic_Paint);
            this.Pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseClick);
            this.Pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseDown);
            this.Pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseMove);
            this.Pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Egér X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Egér Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 517);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pic);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnErase;
        private System.Windows.Forms.Button BtnRectangle;
        private System.Windows.Forms.Button BtnElipse;
        private System.Windows.Forms.Button BtnLine;
        private System.Windows.Forms.Button BtnPencil;
        private System.Windows.Forms.Button BtnPaint;
        private System.Windows.Forms.Button BtnEraser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

