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

namespace Naptár
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			string[] beolvas = File.ReadAllLines("adatok.txt", Encoding.UTF8);
			if (beolvas.Length > 0)
			{
				foreach (var item in beolvas)
				{
					string[] sor = item.Split(';');
					if (sor[0].Trim() == monthCalendar1.SelectionRange.Start.ToString("yyyy.MM.dd"))
					{
						textBox1.Text = $"{sor[1]}";
						richTextBoxleiras.Text = $"{sor[2]}";
						break;
					}
					else
					{
						textBox1.Text = "";
						richTextBoxleiras.Text = "";
					}
				}
			}

			rtxboxdatumok.Text = "";
			string[] beolvas2 = File.ReadAllLines("adatok.txt", Encoding.UTF8);
			if (beolvas2.Length > 0)
			{
				foreach (var item in beolvas2)
				{
					rtxboxdatumok.Text += $"{item}\n";
				}
			}
			kovetkezodatum();
		}

		public void rtxmodosito()
		{
			rtxboxdatumok.Text = "";
			string[] beolvas2 = File.ReadAllLines("adatok.txt", Encoding.UTF8);
			if (beolvas2.Length > 0)
			{
				foreach (var item in beolvas2)
				{
					rtxboxdatumok.Text += $"{item}\n";
				}
			}
		}

		public void kovetkezodatum()
		{
			var list = new List<DateTime>();
			string[] beolvas2 = File.ReadAllLines("adatok.txt", Encoding.UTF8);

			/*beolvas2 rendezése dátum szerint undorító megoldás, de ezt találtam*/
			beolvas2 = beolvas2
			.OrderBy(sor =>
			{
				string datumStr = sor.Split(';')[0];
				var resz = datumStr.Split('.');
				int ev = Convert.ToInt32(resz[0]);
				int honap = Convert.ToInt32(resz[1]);
				int nap = Convert.ToInt32(resz[2]);
				return new DateTime(ev, honap, nap);
			})
			.ToArray();


			foreach (var item in beolvas2)
			{
				int ev = Convert.ToInt32(item.Split(';')[0].Split('.')[0]);
				int honap = Convert.ToInt32(item.Split(';')[0].Split('.')[1]);
				int nap = Convert.ToInt32(item.Split(';')[0].Split('.')[2]);
				list.Add(new DateTime(ev, honap, nap));
			}
			string maidatum = DateTime.Today.ToString("yyyy.MM.dd");
			int maiev = Convert.ToInt32(maidatum.Split('.')[0]);
			int maihonap = Convert.ToInt32(maidatum.Split('.')[1]);
			int manap = Convert.ToInt32(maidatum.Split('.')[2]);
			list.Add(new DateTime(maiev, maihonap, manap));
			list.Sort((a, b) => a.CompareTo(b));
			int maiindex = list.IndexOf(new DateTime(maiev, maihonap, manap));

			if (list.Count == 1)
			{
				lblKoviEsemenyDatuma.Text = "Nincs következő eemény";
				label2.Text = "Esemény neve: ";
				label3.Text = "Esemény leírása: ";
			}
			else
			{
				if (list.Count(n => n == list[maiindex]) == 1)
				{
					if (maiindex == list.Count() - 1)
					{
						lblKoviEsemenyDatuma.Text = $"Következő esemény dátuma: {list[maiindex - 1].ToString("yyyy.MM.dd")}";
						label2.Text = $"Következő esemény neve: {beolvas2[maiindex - 2].Split(';')[1]}";
						label3.Text = $"Esemény leírása: {beolvas2[maiindex - 2].Split(';')[2]}";
					}
					else
					{
						lblKoviEsemenyDatuma.Text = $"Következő esemény dátuma: {list[maiindex + 1].ToString("yyyy.MM.dd")}";
						label2.Text = $"Következő esemény neve: {beolvas2[maiindex].Split(';')[1]}";
						label3.Text = $"Esemény leírása: {beolvas2[maiindex].Split(';')[2]}";

					}
				}
				else
				{
					lblKoviEsemenyDatuma.Text = $"Következő esemény dátuma: {list[maiindex].ToString("yyyy.MM.dd")}";
					label2.Text = $"Következő esemény neve: {beolvas2[maiindex].Split(';')[1]}";
					label3.Text = $"Esemény leírása: {beolvas2[maiindex].Split(';')[2]}";


				}
			}


		}

		public int modositoEsTorlo(List<string> beolvas)
		{
			int indexe = -1;
			foreach (var item in beolvas)
			{
				string[] sor = item.Split(';');
				if (sor[0].Trim() == monthCalendar1.SelectionRange.Start.ToString("yyyy.MM.dd"))
				{
					indexe = beolvas.IndexOf(item);
					break;
				}
			}
			return indexe;
		}

		private void lblSzoveg_Click(object sender, EventArgs e)
		{
		}

		private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		{
			lblSzoveg.Text = $"Kijelölt dátum: {monthCalendar1.SelectionRange.Start.ToString("yyyy.MM.dd")}";
			string[] beolvas = File.ReadAllLines("adatok.txt", Encoding.UTF8);
			if (beolvas.Length > 0)
			{
				rtxboxdatumok.Text = "";
				foreach (var item in beolvas)
				{
					Console.WriteLine($"HAHÓÓ: {item}");
					string[] sor = item.Split(';');
					if (sor[0].Trim() == monthCalendar1.SelectionRange.Start.ToString("yyyy.MM.dd"))
					{
						textBox1.Text = $"{sor[1]}";
						richTextBoxleiras.Text = $"{sor[2]}";
						break;
					}
					else
					{
						textBox1.Text = "";
						richTextBoxleiras.Text = "";
					}
				}
			}
			rtxmodosito();
			kovetkezodatum();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lblSzoveg.Text = $"Kijelölt dátum: {monthCalendar1.SelectionRange.Start.ToString("yyyy.MM.dd")}";
			rtxmodosito();
			kovetkezodatum();
		}

		private void btnModosit_Click(object sender, EventArgs e)
		{

			if (textBox1.Text.Trim() != "" && richTextBoxleiras.Text.Trim() != "")
			{
				List<string> beolvas = new List<string>(File.ReadAllLines("adatok.txt"));
				int indexe = modositoEsTorlo(beolvas);
				if (indexe != -1)
				{
					beolvas[indexe] = $"{beolvas[indexe].Split(';')[0]};{textBox1.Text};{richTextBoxleiras.Text}";
					File.WriteAllLines("adatok.txt", beolvas);
					rtxmodosito();
					kovetkezodatum();
					MessageBox.Show("Az adatokat sikeresen elmentettük");

				}
				else
				{
					beolvas.Add($"{monthCalendar1.SelectionRange.Start.ToString("yyyy.MM.dd")};{textBox1.Text};{richTextBoxleiras.Text}");
					File.WriteAllLines("adatok.txt", beolvas);
					rtxmodosito();
					kovetkezodatum();
					MessageBox.Show("Az adatokat sikeresen elmentettük");
				}
			}
			else
			{
				MessageBox.Show("Add meg az eseménynevét és leírását!!");
			}


		}

		private void btnTorol_Click(object sender, EventArgs e)
		{
			if (textBox1.Text.Trim() != "" && richTextBoxleiras.Text.Trim() != "")
			{
				List<string> beolvas = new List<string>(File.ReadAllLines("adatok.txt"));
				int indexe = modositoEsTorlo(beolvas);
				if (indexe != -1)
				{
					beolvas[indexe] = $"{beolvas[indexe].Split(';')[0]};{textBox1.Text};{richTextBoxleiras.Text}";
					beolvas.RemoveAt(indexe);
					File.WriteAllLines("adatok.txt", beolvas);
					textBox1.Text = "";
					richTextBoxleiras.Text = "";
					rtxmodosito();
					kovetkezodatum();

					MessageBox.Show("Az adatokat sikeresen töröltük");
				}
				else
				{
					textBox1.Text = "";
					richTextBoxleiras.Text = "";
				}
			}
			else
			{
				MessageBox.Show("Nincs mit törölni.");
			}

		}

		private void rtxboxdatumok_TextChanged(object sender, EventArgs e)
		{
		}
	}
}
