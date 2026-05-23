using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20250313kodfeltoro
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		public Random veletlen = new Random();
		public string randomszam;
		public int tippekszama = 0;


		private void txtTipp_TextChanged(object sender, EventArgs e)
		{
			if (txtTipp.Text.Trim().Length == 4)
			{
				btnTipp.Enabled = true;
			}
			else
			{
				btnTipp.Enabled = false;
			}
		}

		private void btnTipp_Click(object sender, EventArgs e)
		{
			tippekszama++;
			lblprobalkozasok.Text = $"Próbálkozások száma: {tippekszama}";
			if (randomszam == txtTipp.Text)
			{
				MessageBox.Show("Eltaláltad a tippet");
			}
			else
			{
				int hanyjo = 0;
				for (int i = 0; i < 3; i++)
				{
					if (txtTipp.Text[i] == randomszam[i])
					{
						hanyjo++;
					}
				}
				MessageBox.Show($"Nem találtad el a véletlenszámot, {hanyjo}db számjegyet találtál el");
				
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			randomszam = veletlen.Next(1000, 9999).ToString();
			label2.Text = randomszam;
		}
	}
}
