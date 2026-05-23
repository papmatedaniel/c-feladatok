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

namespace _20250205
{
	public partial class Tippek : Form
	{
		public Tippek()
		{
			InitializeComponent();
		}

		private void btnKilep_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			string tartalom = textBox2.Text;

			
			if (tartalom.Trim() == "")
			{
				lblDb.Text = $"{0} db";
			}
			else
			{
				int db = tartalom.Trim().Split(' ').Length;
				lblDb.Text = $"{db} db";
				if (int.Parse(tartalom.Trim().Split(' ')[db - 1]) > 99 || int.Parse(tartalom.Trim().Split(' ')[db - 1]) < 1)
				{
					MessageBox.Show("Nem megfelelő tartományt adtál meg", "Hiba");
				}
				if (db > 4)
				{
					btnHozzaad.Enabled = false;
					MessageBox.Show("A tippek száma nem megfelelő", "Hiba");
				}
				else
				{
					btnHozzaad.Enabled = true;
				}
			}
			


		}

		private void lblTipp_Click(object sender, EventArgs e)
		{

		}

		private void btnHozzaad_Click(object sender, EventArgs e)
		{
			if (File.Exists("tippek.txt"))
			{
				if (File.ReadAllText("tippek.txt").Contains(textBox1.Text))
				{
					MessageBox.Show("Van már ilyen nyelvű játékos", "hiba");
				}else
				{
					string nev = textBox1.Text.Trim();
					string tipp = textBox2.Text.Trim();

					MessageBox.Show("Az állomány bővítése sikeres volt");
					string[] beolvas = File.ReadAllLines("tippek.txt");
					List<string> kiir = new List<string>();
					foreach (var item in beolvas)
					{
						kiir.Add(item);
						
					}
					kiir.Add(nev + ' ' + tipp);
					File.WriteAllLines("tippek.txt", kiir);
				}
			}
			else
			{
				string nev = textBox1.Text.Trim();
				string tipp = textBox2.Text.Trim();
				string kiir = nev + ' ' + tipp;
				File.WriteAllText("tippek.txt", kiir);
				MessageBox.Show("Az állomány bővítése sikeres volt");

			}
		}
	}
}
