using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB
{
    public partial class CircleSquareForm : Form
    {
        private CircleSquare[] circlesquares;

        private CircleSquare circlesquare;

        private Graphics g;
        private Pen pen;

        private Random random;
        public CircleSquareForm()
        {
            InitializeComponent();
            circlesquares = new CircleSquare[5];

            g = pictureBox1.CreateGraphics();
            pen = new Pen(Color.Black, 3f);
            random = new Random();
        }

        private void buttonCreateCircleSquare_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                circlesquares[i] = null;
            }

            bool ax = int.TryParse(textBox1.Text, out int x);
            bool ay = int.TryParse(textBox2.Text, out int y);
            bool ar = int.TryParse(textBox9.Text, out int r);

            if (ax && ay && ar)
            {
                circlesquare = new CircleSquare(x, y, r, random);
                g.Clear(Color.White);
                circlesquare.Show(g, pen);
            }
            else if (ax && ay)
            {
                circlesquare = new CircleSquare(x, y, random);
                g.Clear(Color.White);
                circlesquare.Show(g, pen);
            }
            else
            {
                circlesquare = new CircleSquare(random);
                g.Clear(Color.White);
                circlesquare.Show(g, pen); ;
            }
        }

        private void buttonMoveToCircleSquare_Click(object sender, EventArgs e)
        {
            if (circlesquare != null)
            {
                var ax = int.TryParse(textBox3.Text, out int x);
                var ay = int.TryParse(textBox4.Text, out int y);

                if (ax && ay)
                {
                    circlesquare.MoveTo(g, pen, x, y);
                    circlesquare.Show(g, pen);
                }
                else if (ax && !ay)
                {
                    circlesquare.MoveTo(g, pen, x, 0);
                    circlesquare.Show(g, pen);
                }
                else if (!ax && ay)
                {
                    circlesquare.MoveTo(g, pen, 0, y);
                    circlesquare.Show(g, pen);
                }
                else
                {
                    circlesquare.MoveTo(g, pen, random.Next(-100, 100), random.Next(-100, 100));
                    circlesquare.Show(g, pen);
                }
            }
        }

        private void buttonRadCircleSquare_Click(object sender, EventArgs e)
        {
            if (circlesquare != null)
            {
                var ar = int.TryParse(textBox5.Text, out int r);

                if (ar)
                {
                    g.Clear(Color.White);
                    circlesquare.SetR(circlesquare.GetR() + r);
                    circlesquare.Show(g, pen);
                }
                else
                {
                    label10.Text = "Некорректный ввод радиуса!";
                }
            }
        }

        private void buttonCreateMassCircleSquare_Click(object sender, EventArgs e)
        {
            circlesquare = null;

            g.Clear(Color.White);
            for (int i = 0; i < 5; i++)
            {
                circlesquares[i] = new CircleSquare(random);
                circlesquares[i].Show(g, pen);
            }
        }

        private void buttonMoveToMassCircleSquare_Click(object sender, EventArgs e)
        {
            if (circlesquares[1] != null)
            {
                var ax = int.TryParse(textBox6.Text, out int x);
                var ay = int.TryParse(textBox7.Text, out int y);
                if (ax && ay)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        circlesquares[i].MoveTo(g, pen, x, y);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        circlesquares[i].Show(g, pen);
                    }
                }
                else if (ax && !ay)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        circlesquares[i].MoveTo(g, pen, x, 0);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        circlesquares[i].Show(g, pen);
                    }
                }
                else if (!ax && ay)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        circlesquares[i].MoveTo(g, pen, 0, y);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        circlesquares[i].Show(g, pen);
                    }
                }
                else
                {
                    label10.Text = "Некорректный ввод координат!";
                }
            }
        }

        private void buttonRadMassCircleSquare_Click(object sender, EventArgs e)
        {
            if (circlesquares[1] != null)
            {
                var ar = int.TryParse(textBox8.Text, out int r);
                if (ar)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        circlesquares[i].SetR(circlesquares[i].GetR() + r);
                        circlesquares[i].Show(g, pen);
                    }
                }
                else
                {
                    label10.Text = "Некорректный ввод координат!";
                }
            }
        }
    }
}
