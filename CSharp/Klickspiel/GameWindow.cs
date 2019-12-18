using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klickspiel
{
    public partial class GameWindow : Form
    {
        public int mouseX;
        public int mouseY;
        public int points= 0;
        double kreismitteX;
        double kreismitteY;
        List<Pen> pen = new List<Pen>();
        Pen p;
        static float kreisX = 100;
        static float kreisY = 100;
        float size = 50;


        public GameWindow()
        {
            InitializeComponent();
            scoreLb.Text = "Points: "+points.ToString()+"/100";
            pen.Add(new Pen(Color.Tomato, 3));
            pen.Add(new Pen(Color.DarkBlue, 2));
            pen.Add(new Pen(Color.LimeGreen, 4));
            pen.Add(new Pen(Color.Purple, 3));
            drawTimer.Start();
            bad.Hide();
            good.Hide();
        }

        private void randSize()
        {
            Random r = new Random();
            size = r.Next(10, 200);
        }

        private void randPen()
        {
            p = pen[new Random().Next(0,3)];
        }

        private void randPt()
        {
            Random random = new Random();
            kreisX = random.Next(5,game.Width-(int)size);
            kreisY = random.Next(5,game.Height-(int)size);
        }

        private void game_Click(object sender, EventArgs e)
        {
            bad.Hide();
            good.Hide();

            if (GetDistance(mouseX,mouseY,kreismitteX,kreismitteY)<=size/2/*&&p.Color.Name=="DarkBlue"*/)
            {
                good.Show();
                //pointCalc();
                points += 10;
                scoreLb.Text = "Points: " + points.ToString()+"/100";
                drawTimer.Interval -= 90;
                if (points >= 100)
                {
                    drawTimer.Stop();
                    MessageBox.Show("You won!");
                    Close();
                }
                game.Refresh();
            }
            /*else if(GetDistance(mouseX, mouseY, kreismitteX, kreismitteY) <= size / 2 && p.Color.Name != "DarkBlue")
            {
                bad.Show();
                pointCalc();
                scoreLb.Text = "Punkte: " + points.ToString()+"/100";
            }*/
        }

        private void game_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            randSize();
            randPt();
            randPen();
            g.DrawEllipse(p, kreisX, kreisY, size, size);
            kreismitteX = kreisX + size/2;
            kreismitteY = kreisY + size/2;
        }

        private void drawTimer_Tick(object sender, EventArgs e)
        {
            game.Refresh();
        }

        private void game_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            mousePos.Text = "X: " + e.X.ToString() + " Y: " + e.Y.ToString();
        }

        private static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mousePos.Text = "X: " + e.X.ToString() + " Y: " + e.Y.ToString();
        }

        /*private void pointCalc()
        {
            if (p.Color.Name == "DarkBlue")
            {
                points += 10;
                if (size <= 30)
                {
                    points += 10;
                }
            }
            else points -= 10;
        }*/
    }
}
