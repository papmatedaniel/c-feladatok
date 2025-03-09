using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025._03._05
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

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSzamgeneralas_Click(object sender, EventArgs e)
		{
			Random veletlen = new Random();
			richTextBoxSzamok.Text = "";
			for (int i = 0; i < veletlen.Next(1, 20); i++)
			{
				richTextBoxSzamok.Text += $"{Convert.ToString(veletlen.Next(1, 99))}\n";
			}
		}

		private void btnAtlag_Click(object sender, EventArgs e)
		{
			List<int> szamok = new List<int>();
			foreach (var item in richTextBoxSzamok.Text.Split('\n'))
			{
				if (item.Trim() != "")
				{
					szamok.Add(Convert.ToInt32(item));
				}
			}
			if (szamok.Count() != 0)
			{
				MessageBox.Show($"A számok átlaga: {szamok.Sum() / szamok.Count()}");
			}
			else
			{
				MessageBox.Show($"Nem adtál meg számot!");

			}
		}

		private void btnOsszeg_Click(object sender, EventArgs e)
		{
			List<int> szamok = new List<int>();
			foreach (var item in richTextBoxSzamok.Text.Split('\n'))
			{
				if (item.Trim() != "")
				{
					szamok.Add(Convert.ToInt32(item));
				}
			}
			if (szamok.Count() != 0)
			{
				MessageBox.Show($"A számok összege: {szamok.Sum()}");
			}
			else
			{
				MessageBox.Show($"Nem adtál meg számot!");

			}
		}

		private void btnParosOsszeg_Click(object sender, EventArgs e)
		{
			List<int> szamok = new List<int>();
			foreach (var item in richTextBoxSzamok.Text.Split('\n'))
			{
				if (item.Trim() != "")
				{
					szamok.Add(Convert.ToInt32(item));
				}
			}
			if (szamok.Count() != 0)
			{
				int osszeg = 0;
				foreach (var item in szamok)
				{
					if (item % 2 == 0)
					{
						osszeg += item;
					}
				}
				MessageBox.Show($"A páros számok összege: {osszeg}");
			}
			else
			{
				MessageBox.Show($"Nem adtál meg számot!");

			}
		}

		private void btnMin_Click(object sender, EventArgs e)
		{
			List<int> szamok = new List<int>();
			foreach (var item in richTextBoxSzamok.Text.Split('\n'))
			{
				if (item.Trim() != "")
				{
					szamok.Add(Convert.ToInt32(item));
				}
			}
			if (szamok.Count() != 0)
			{
				MessageBox.Show($"A legkisebb szám: {szamok.Min()}");
			}
			else
			{
				MessageBox.Show($"Nem adtál meg számot!");

			}
		}

		private void btnMax_Click(object sender, EventArgs e)
		{
			List<int> szamok = new List<int>();
			foreach (var item in richTextBoxSzamok.Text.Split('\n'))
			{
				if (item.Trim() != "")
				{
					szamok.Add(Convert.ToInt32(item));
				}
			}
			if (szamok.Count() != 0)
			{
				MessageBox.Show($"A legnagyobb szám: {szamok.Max()}");
			}
			else
			{
				MessageBox.Show($"Nem adtál meg számot!");

			}
		}
	}
}
