using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PaintApp
{
    public partial class Form1 : Form
    {    
        Bitmap bm; //Declarálni kell, mert arajzolatot el kell menteni
        Graphics g; // Itt vannak a grafikai eszközök
        bool paint = false; // Szabad e rajzolni
        Point px, py; // átmeneti pont koordináták
        Pen p = new Pen(Color.Black, 1); // Eszköz a rajzoláshoz
        Pen Eraser = new Pen(Color.White, 10); 
        int DrawTool = 1; // A rajzolás típusa
        int x, y, sx, sy, cx, cy; // átmeneti koordináták
        // bool saved = false;
        Color New_Color; // Rajzolás színe
        ColorDialog cd = new ColorDialog(); // Színválaszték
       
        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(Pic.Width, Pic.Height); // Bimap példány
            g = Graphics.FromImage(bm); //új rajzot hoz létre képből (bm)
            g.Clear(Color.White); // tőrlés: háttérszínnel kitöltés
            Pic.Image = bm; // Image mentésa a paintboxból
            p.Width = (float)numericUpDown1.Value; //rajzoló eszköz vastagsága
        }

        private void BtnPencil_Click(object sender, EventArgs e)
        {
            DrawTool = 1; //Rajzeszköz ceruza
        }

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            
            paint = true; // engedélyezem a rajzolást
            py = e.Location; //elmentem az egérkurzor aktuális állapotát
            cx = e.X; 
            cy = e.Y;
            label5.Text = Convert.ToString(e.Location);
            label6.Text = Convert.ToString(e.Location);
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            label5.Text = Convert.ToString(px);
            label6.Text = Convert.ToString(py);
            if (paint) //ha rajzolás közben mozog a kurzor
            {
                if (DrawTool == 1) //ha eszköz ceruza
                {
                    px = e.Location; //elmentem az egérkurzor új koordinátáit
                    g.DrawLine(p, px, py); //rövidke vonalat húzok
                    py = px; //egér startkoordináta csere
                }
               if (DrawTool == 2)  //ha eszköz radír, mint 1
                {
                    px = e.Location;
                    g.DrawLine(Eraser, px, py);
                    py = px;
                }
                if (DrawTool == 7)
                {
                    px = e.Location;                    
                    g.DrawEllipse(p, px.X , py.Y , (float)numericUpDown2.Value, (float) numericUpDown2.Value);
                    g.DrawEllipse(Eraser, px.X, py.Y, (float)numericUpDown2.Value-2, (float)numericUpDown2.Value-2);
                    py = px;
                }
            }
            Pic.Refresh();
            x = e.X;
            y = e.Y;
            sx = e.X - cx;
            sy = e.Y - cy;
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sx = x - cx;
            sy = y - cy;
            if (DrawTool == 3)
            {
                g.DrawEllipse(p, cx, cy, sx, sy);
            }
            if (DrawTool == 4)
            {
                g.DrawRectangle(p, cx, cy, sx, sy);
            }
            if (DrawTool == 5)
            {
                g.DrawLine(p, cx, cy, x, y);
            }
        }

        private void BtnEraser_Click(object sender, EventArgs e)
        {
            DrawTool = 2; //Rajzeszköz radír
        }

        private void BtnEllipse_Click(object sender, EventArgs e)
        {
            DrawTool = 3;  //Rajzeszköz elipszis, spec kör
        }

        private void BtnRectangle_Click(object sender, EventArgs e)
        {
            DrawTool = 4;  //Rajzeszköz négyzet
        }

        private void BtnLine_Click(object sender, EventArgs e)
        {
            DrawTool = 5;  //Rajzeszköz vonalhúzás
        }

        private void Pic_Paint(object sender, PaintEventArgs e)
        {
            //Kirajzolása azalakzatnak
            Graphics g = e.Graphics;
            if (paint)
            {
                if (DrawTool == 3)
                {
                    g.DrawEllipse(p, cx, cy, sx, sy);
                }
                if (DrawTool == 4)
                {
                    g.DrawRectangle(p, cx, cy, sx, sy);
                }
                if (DrawTool == 5)
                {
                    g.DrawLine(p, cx, cy, x, y);
                }
                if (DrawTool == 7)
                {
                        //megírni
                }
            }
        }

       

        private void BtnClear_Click(object sender, EventArgs e)
        {
            // Vászon törlése
            g.Clear(Color.White);
            Pic.Image = bm;
            DrawTool = 0;
        }

        private void BtnPaint_Click(object sender, EventArgs e)
        {
            DrawTool = 6; // Zárt alakzat kifestése eszköz
        }

 
       

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Eszköz vonalvastagsága
            p.Width = (float)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawTool = 7;  //Rajzeszköz szórópisztoly
        }

       


        static Point set_Point(PictureBox pb, Point pt)
        {
            // Zárt alakzat keresése a kitöltéséhez algoritmus
            float px = 1f * pb.Width / pb.Width;
            float py = 1f * pb.Height / pb.Height;
            return new Point((int)(pt.X * px), (int)(pt.Y * py));
        }
        private void Validate(Bitmap bm, Stack<Point> sp, int x, int y, Color Old_Color, Color New_Color)
        {  
            // Zárt alakzat keresése a kitöltéséhez algoritmus
            Color cx = bm.GetPixel(x, y);
            if (cx == Old_Color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, New_Color);
            }
        }

        public void Fill(Bitmap bm, int x, int y, Color New_Clr)
        {
            // Zárt alakzat kitöltéséhez algoritmus
            Color Old_Color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, New_Clr);
            if (Old_Color == New_Clr) { return; }

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    Validate(bm, pixel, pt.X - 1, pt.Y, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X, pt.Y - 1, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X + 1, pt.Y, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X, pt.Y + 1, Old_Color, New_Clr);
                }
            }
        }

        private void Pic_MouseClick(object sender, MouseEventArgs e)
        {
            // Zárt alakzat kitöltése

            if (DrawTool == 6)
            {
                Point point = set_Point(Pic, e.Location);
                Fill(bm, point.X, point.Y, New_Color);
            }
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            // //Rajzeszköz színének megváltoztatása
            cd.ShowDialog();
            New_Color = cd.Color;
            Pic.BackColor = cd.Color;
            p.Color = cd.Color;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Kép mentése
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, Pic.Width, Pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }
    }
}

