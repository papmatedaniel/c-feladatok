using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kepforgatas
{
	public partial class Form1 : Form
	{
		public List<string> kepek = new List<string> { "kep1.png", "kep2.png", "kep3.png", "kep4.png" };
		public List<string> ujkepek = new List<string> { "", "", "", "" };
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			pictureBox1.Image = Image.FromFile("kep1.png");
			pictureBox2.Image = Image.FromFile("kep2.png");
			pictureBox3.Image = Image.FromFile("kep3.png");
			pictureBox4.Image = Image.FromFile("kep4.png");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 3; i++)
			{
				ujkepek[i + 1] = kepek[i];
			}
			ujkepek[0] = kepek[3];
			pictureBox1.Image = Image.FromFile(ujkepek[0]);
			pictureBox2.Image = Image.FromFile(ujkepek[1]);
			pictureBox3.Image = Image.FromFile(ujkepek[2]);
			pictureBox4.Image = Image.FromFile(ujkepek[3]);
			kepek = new List<string>(ujkepek);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			for (int i = 3; i > 0; i--)
			{
				ujkepek[i - 1] = kepek[i];
			}
			ujkepek[ujkepek.Count-1] = kepek[0];
			pictureBox1.Image = Image.FromFile(ujkepek[0]);
			pictureBox2.Image = Image.FromFile(ujkepek[1]);
			pictureBox3.Image = Image.FromFile(ujkepek[2]);
			pictureBox4.Image = Image.FromFile(ujkepek[3]);
			kepek = new List<string>(ujkepek);
		}
	}
}
