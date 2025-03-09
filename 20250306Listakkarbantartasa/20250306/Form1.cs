using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20250306
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			List<string> sorok = new List<string>();
			foreach (var item in listBox1.Text.Split('\n'))
			{
				if (item != "")
				{
					sorok.Add(item);
					btnTorol.Enabled = true;
				}
			}


			if (listBox1.Items.Count < 2)
			{
				btnAlulra.Enabled = false;
				btnFel.Enabled = false;
				btnFelulre.Enabled = false;
				btnLe.Enabled = false;
			}
			else
			{
				btnAlulra.Enabled = true;
				btnFel.Enabled = true;
				btnFelulre.Enabled = true;
				btnLe.Enabled = true;
			}


		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnHozzaad_Click(object sender, EventArgs e)
		{
			if (txtSzoveg.Text.Trim() == "")
			{
				MessageBox.Show("Nem adtál meg elemet");
			}
			else
			{
				listBox1.Items.Add(txtSzoveg.Text.Trim());
			}
		}
	}
}
