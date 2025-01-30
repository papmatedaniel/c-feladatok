using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20250130_Szamologep
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnOsszead_Click(object sender, EventArgs e)
		{

			
			try
			{
			double a = Convert.ToDouble(txtAdat1.Text);
			double b = Convert.ToDouble(txtAdat2.Text);
			txtEredmeny.Text = $"{a + b}";
			lblMuvelet.Text = "Művelet: Összeadás";

			}
			catch (Exception)
			{

				MessageBox.Show("Nem számot adtál meg");
			}
		}
		private void btnKivon_Click(object sender, EventArgs e)
		{
			try
			{
				double a = Convert.ToDouble(txtAdat1.Text);
				double b = Convert.ToDouble(txtAdat2.Text);
				txtEredmeny.Text = $"{a - b}";
				lblMuvelet.Text = "Művelet: Kivonás";


			}
			catch (Exception)
			{

				MessageBox.Show("Nem számot adtál meg");
			}
		}

		private void btnSzoroz_Click(object sender, EventArgs e)
		{
			try
			{
				double a = Convert.ToDouble(txtAdat1.Text);
				double b = Convert.ToDouble(txtAdat2.Text);
				txtEredmeny.Text = $"{a * b}";
				lblMuvelet.Text = "Művelet: Szorzás";

			}
			catch (Exception)
			{

				MessageBox.Show("Nem számot adtál meg");
			}
		}


		private void txtAdat1_TextChanged(object sender, EventArgs e)
		{
			txtEredmeny.Text = "";
			lblMuvelet.Text = "Művelet:";
		}

		private void txtAdat2_TextChanged(object sender, EventArgs e)
		{
			txtEredmeny.Text = "";
			lblMuvelet.Text = "Művelet:";

		}


	}
}
