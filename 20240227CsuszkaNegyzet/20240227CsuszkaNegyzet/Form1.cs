using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20240227CsuszkaNegyzet
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

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void hScrollBarOldal_Scroll(object sender, ScrollEventArgs e)
		{
			lblNegyzet.Width = hScrollBarOldal.Value;
			lblNegyzet.Height = hScrollBarOldal.Value;
			label1.Text = $"A négyzet oldala: {hScrollBarOldal.Value}";
		}

		private void lblNegyzet_Click(object sender, EventArgs e)
		{
		}

		private void hScrollBarPiros_Scroll(object sender, ScrollEventArgs e)
		{
			lblNegyzet.BackColor = Color.FromArgb(hScrollBarPiros.Value, hScrollBarZöld.Value, hScrollBarKék.Value);

		}

		private void hScrollBarKék_Scroll(object sender, ScrollEventArgs e)
		{
			lblNegyzet.BackColor = Color.FromArgb(hScrollBarPiros.Value, hScrollBarZöld.Value, hScrollBarKék.Value);

		}

		private void hScrollBarZöld_Scroll(object sender, ScrollEventArgs e)
		{
			lblNegyzet.BackColor = Color.FromArgb(hScrollBarPiros.Value, hScrollBarZöld.Value, hScrollBarKék.Value);

		}
	}
}
