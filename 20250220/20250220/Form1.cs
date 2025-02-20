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

namespace _20250220
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			List<string> elemek = new List<string>();
			elemek.Add("Étel");
			elemek.Add("Egyébb");
			comboKategoria.DataSource = elemek;
			comboKategoria.SelectedIndex = 0;
			string[] beolvas = File.ReadAllLines("termekek.txt", Encoding.UTF8);
			listBox1.DataSource = beolvas;

		}

		private void btnHozzaad_Click(object sender, EventArgs e)
		{
			if (txtTermek.Text == "")
			{
				MessageBox.Show("Nem adtál meg terméket");
			}
			else
			{
				string filenev = "termekek.txt";
				string ujsor = $"{txtTermek.Text};{comboKategoria.Text}\n";

				try
				{
					File.AppendAllText(filenev, ujsor);
				}
				catch (Exception)
				{

					using (FileStream fs = File.Create(filenev)) { }
					File.AppendAllText(filenev, ujsor);
				}
				string[] beolvas = File.ReadAllLines("termekek.txt", Encoding.UTF8);
				listBox1.DataSource = beolvas;
				MessageBox.Show("Új étel sikeresen hozzáadva a listához");
			}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			/*
			string[] beolvas = File.ReadAllLines("termekek.txt", Encoding.UTF8);
			listBox1.DataSource = beolvas;
			*/
		}


		private void comboKategoria_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnElemTorlese_Click(object sender, EventArgs e)
		{
			//MessageBox.Show($"Ezt az elemet akartad törölni: {listBox1.SelectedItem.ToString()}");
			List<string> beolvas = new List<string>(File.ReadAllLines("termekek.txt"));
			/*int indexe = Array.IndexOf(beolvas, listBox1.SelectedItem.ToString());*/
			beolvas.Remove(listBox1.SelectedItem.ToString());
			File.WriteAllLines("termekek.txt", beolvas);
			listBox1.DataSource = beolvas;



		}

		private void btnOsszestorles_Click(object sender, EventArgs e)
		{
			List<string> uj = new List<string>();
			File.WriteAllLines("termekek.txt", uj);
			listBox1.DataSource = uj;
		}
	}
}
