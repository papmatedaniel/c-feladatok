using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20250319
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
		public string talalatok = "";
		

		private void Form1_Load(object sender, EventArgs e)
		{
			string random1 = veletlen.Next(0, 9).ToString();
			string random2 = veletlen.Next(0, 9).ToString();
			string random3 = veletlen.Next(0, 9).ToString();
			string random4 = veletlen.Next(0, 9).ToString();
			randomszam = $"{random1}{random2}{random3}{random4}";
			lblSzam.Text = randomszam;

		}

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
			if (randomszam == txtTipp.Text)
			{
				MessageBox.Show("Eltaláltad a tippet");
			}
			/*
			else
			{
				MessageBox.Show($"Nem találtad el a véletlenszámot");
			}
			*/
			string eltaltak = "";
			List<char> egyebb1 = new List<char>();
			List<char> egyebb2 = new List<char>();
			for (int i = 0; i < 4; i++)
			{
				if (randomszam[i] == txtTipp.Text[i])
				{
					eltaltak += "!";
				}
				else
				{
					egyebb1.Add(randomszam[i]);
					egyebb2.Add(txtTipp.Text[i]);
				}
			}
			egyebb1.Sort();
			egyebb2.Sort();
			for (int i = 0; i < egyebb1.Count; i++)
			{
				if (egyebb1[i] == egyebb2[i])
				{
					eltaltak += "|";
				}
			}
			talalatok += $"{txtTipp.Text} - {eltaltak}\n";
			lblTalalatok.Text = talalatok;
		}

		private void lblSzam_Click(object sender, EventArgs e)
		{

		}
	}
}
