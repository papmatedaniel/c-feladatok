using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20250130szamolasok
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnSzamol_Click(object sender, EventArgs e)
		{

			try
			{
				double a = Convert.ToDouble(txtOldal.Text);
				if (0 < a)
				{
					double A, V;
					A = 6 * Math.Pow(a, 2);
					V = Math.Pow(a, 3);
					lblFelszin.Text = $"A kocka felszíne: {A}";
					lblTerfogat.Text = $"A kocka térfogata: {V}";
					lblFelszin.Visible = true;
					lblTerfogat.Visible = true;
				}
				else
				{
					MessageBox.Show("A megadott számból nem tudunk kockát készíteni");
				}

			}
			catch (Exception)
			{

				MessageBox.Show("Nem számot adtál meg");
			}
		}

		private void txtOldal_TextChanged(object sender, EventArgs e)
		{
			lblFelszin.Visible = false;
			lblTerfogat.Visible = false;
			if (txtOldal.Text == "")
			{

				btnSzamol.Enabled = false;
			}
			else
			{

				btnSzamol.Enabled = true;
			}
		}

		private void btnTorol_Click(object sender, EventArgs e)
		{
			txtOldal.Text = "";
		}
	}
}
