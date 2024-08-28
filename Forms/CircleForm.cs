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
    public partial class CircleForm : Form
    {
        private Circle[] circles;

        private Circle circle;

        private Graphics g;
        private Pen pen;

        private Random random;
        public CircleForm()
        {
            InitializeComponent();
            circles = new Circle[5];
            g = pictureBox1.CreateGraphics();
            pen = new Pen(Color.Black, 3f);
            random = new Random();
        }

        private void buttonCreateCircle_Click(object sender, EventArgs e)
        {
            for(int i=0; i<5;i++)
            {
                circles[i] = null;
            }

            bool ax = int.TryParse(textBox1.Text, out int x);
            bool ay = int.TryParse(textBox2.Text, out int y);
            bool ar = int.TryParse(textBox9.Text, out int r);

            if (ax && ay && ar)
            {
                    circle = new Circle(x, y, r);
                    g.Clear(Color.White);
                    circle.Show(g, pen);
            }
            else if (ax && ay)
            {
                circle = new Circle(x, y, random);
                g.Clear(Color.White);
                circle.Show(g, pen);
            }
            else
            {
                circle = new Circle(random);
                g.Clear(Color.White);
                circle.Show(g, pen); ;
            }
        }

        private void buttonMoveToCircle_Click(object sender, EventArgs e)
        {
            if (circle != null)
            {
                var ax = int.TryParse(textBox3.Text, out int x);
                var ay = int.TryParse(textBox4.Text, out int y);

                if (ax && ay)
                {
                    circle.MoveTo(g, pen, x, y);
                }
                else if (ax && !ay)
                {
                    circle.MoveTo(g, pen, x, 0);
                }
                else if (!ax && ay)
                {
                    circle.MoveTo(g, pen, 0, y);
                }
                else
                {
                    circle.MoveTo(g, pen, random.Next(-100, 100), random.Next(-100, 100));
                }
            }
        }

        private void buttonRadCircle_Click(object sender, EventArgs e)
        {
            if (circle != null)
            {
                var ar = int.TryParse(textBox5.Text, out int r);

                if (ar)
                {
                    g.Clear(Color.White);
                    circle.SetR(circle.GetR() + r);
                    circle.Show(g, pen);
                }
                else
                {
                    label10.Text = "Некорректный ввод радиуса!";
                }
            }
        }

        private void buttonCreateMassCircle_Click(object sender, EventArgs e)
        {
            circle = null;

            g.Clear(Color.White);
            for (int i = 0; i < 5; i++)
            {
                circles[i] = new Circle(random);
                circles[i].Show(g, pen);
            }
        }

        private void buttonMoveToMassCircle_Click(object sender, EventArgs e)
        {
            if (circles[1] != null)
            {
                var ax = int.TryParse(textBox6.Text, out int x);
                var ay = int.TryParse(textBox7.Text, out int y);
                
                if (ax && ay)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        circles[i].MoveTo(g, pen, x, y);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        circles[i].Show(g, pen);
                    }
                }
                else if (ax && !ay)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        circles[i].MoveTo(g, pen, x, 0);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        circles[i].Show(g, pen);
                    }
                }
                else if (!ax && ay)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        circles[i].MoveTo(g, pen, 0, y);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        circles[i].Show(g, pen);
                    }
                }
                else
                {
                    label10.Text = "Некорректный ввод координат!";
                }
            }
        }

        private void buttonRadMassCircle_Click(object sender, EventArgs e)
        {
            if (circles[1] != null)
            {
                var ar = int.TryParse(textBox8.Text, out int r);
          
                if (ar)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        circles[i].SetR(circles[i].GetR() + r);
                        circles[i].Show(g, pen);
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
