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
    public partial class RingForm : Form
    {
        private Ring[] rings;

        private Ring ring;

        private Graphics g;
        private Pen pen;

        private Random random;
        public RingForm()
        {
            InitializeComponent();
            rings = new Ring[5];

            g = pictureBox1.CreateGraphics();
            pen = new Pen(Color.Black, 3f);
            random = new Random();
        }

        private void buttonCreateRing_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                rings[i] = null;
            }

            bool ax = int.TryParse(textBox1.Text, out int x);
            bool ay = int.TryParse(textBox2.Text, out int y);
            bool ar = int.TryParse(textBox10.Text, out int r);
            bool aR = int.TryParse(textBox9.Text, out int R);

            if (ax && ay && ar && aR)
            {
                ring = new Ring(x, y, r, R);
                g.Clear(Color.White);
                ring.Show(g, pen);
            }
            else 
            {
                ring = new Ring(random);
                g.Clear(Color.White);
                ring.Show(g, pen);
            }
        }

        private void buttonMoveToRing_Click(object sender, EventArgs e)
        {
            if (ring != null)
            {
                var ax = int.TryParse(textBox3.Text, out int x);
                var ay = int.TryParse(textBox4.Text, out int y);

                if (ax && ay)
                {
                    ring.MoveTo(g, pen, x, y);
                }
                else if (ax && !ay)
                {
                    ring.MoveTo(g, pen, x, 0);
                }
                else if (!ax && ay)
                {
                    ring.MoveTo(g, pen, 0, y);
                }
                else
                {
                    ring.MoveTo(g, pen, random.Next(-100, 100), random.Next(-100, 100));
                }
            }
        }

        private void buttonRadRing_Click(object sender, EventArgs e)
        {
            if (ring != null)
            {
                var ar = int.TryParse(textBox11.Text, out int r);
                var aR = int.TryParse(textBox5.Text, out int R);

                if (ar && aR)
                {
                    g.Clear(Color.White);
                    ring.SetR(ring.GetR() + R);
                    ring.Setr(ring.Getr() + r);
                    ring.Show(g, pen);
                }
                else if (ar && !aR)
                {
                    g.Clear(Color.White);
                    ring.Setr(ring.Getr() + r);
                    ring.Show(g, pen);
                }
                else if (!ar && aR)
                {
                    g.Clear(Color.White);
                    ring.SetR(ring.GetR() + R);
                    ring.Show(g, pen);
                }
                else
                {
                    label10.Text = "Некорректный ввод радиуса!";
                }
            }
        }

        private void buttonCreateMassRing_Click(object sender, EventArgs e)
        {
            ring = null;

            g.Clear(Color.White);
            for (int i = 0; i < 5; i++)
            {
                rings[i] = new Ring(random);
                rings[i].Show(g, pen);
            }
        }

        private void buttonMoveToMassRing_Click(object sender, EventArgs e)
        {
            if (rings[1] != null)
            {
                var ax = int.TryParse(textBox6.Text, out int x);
                var ay = int.TryParse(textBox7.Text, out int y);
                if (ax && ay)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        rings[i].MoveTo(g, pen, x, y);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        rings[i].Show(g, pen);
                    }
                }
                else if (ax && !ay)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        rings[i].MoveTo(g, pen, x, 0);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        rings[i].Show(g, pen);
                    }
                }
                else if (!ax && ay)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        rings[i].MoveTo(g, pen, 0, y);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        rings[i].Show(g, pen);
                    }
                }
                else
                {
                    label10.Text = "Некорректный ввод координат!";
                }
            }
        }

        private void buttonRadMassRing_Click(object sender, EventArgs e)
        {
            if (rings[1] != null)
            {
                var aR = int.TryParse(textBox8.Text, out int R);
                var ar = int.TryParse(textBox12.Text, out int r);
                if (ar && aR)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        rings[i].SetR(rings[i].GetR() + R);
                        rings[i].Setr(rings[i].Getr() + r);
                        rings[i].Show(g, pen);
                    }
                }
                else if (ar && !aR)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        rings[i].Setr(rings[i].Getr() + r);
                        rings[i].Show(g, pen);
                    }
                }
                else if (!ar && aR)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        rings[i].SetR(rings[i].GetR() + R);
                        rings[i].Show(g, pen);
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
