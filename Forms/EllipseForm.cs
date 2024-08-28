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
    public partial class EllipseForm : Form
    {
        private Ellipse[] ellipses;
        private Ellipse ellipse;

        private Graphics g;
        private Pen pen;

        private Random random;
        public EllipseForm()
        {
            InitializeComponent();
            ellipses = new Ellipse[5];

            g = pictureBox1.CreateGraphics();
            pen = new Pen(Color.Black, 3f);
            random = new Random();
        }

        private void buttonCreateEllipse_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                ellipses[i] = null;
            }

            bool ax = int.TryParse(textBox18.Text, out int x);
            bool ay = int.TryParse(textBox17.Text, out int y);
            bool ar = int.TryParse(textBox16.Text, out int r);
            bool ar2 = int.TryParse(textBox19.Text, out int r2);
            if (ax && ay && ar && ar2)
            {
                ellipse = new Ellipse(x, y, r, r2);
                g.Clear(Color.White);
                ellipse.Show(g, pen);
            }
            else
            {
                ellipse = new Ellipse(random);
                g.Clear(Color.White);
                ellipse.Show(g, pen);
            }
        }

        private void buttonMoveToEllipse_Click(object sender, EventArgs e)
        {
            if (ellipse != null)
            {
                var ax = int.TryParse(textBox15.Text, out int x);
                var ay = int.TryParse(textBox13.Text, out int y);

                if (ax && ay)
                {
                    ellipse.MoveTo(g, pen, x, y);
                }
                else if (ax && !ay)
                {
                    ellipse.MoveTo(g, pen, x, 0);
                }
                else if (!ax && ay)
                {
                    ellipse.MoveTo(g, pen, 0, y);
                }
                else
                {
                    ellipse.MoveTo(g, pen, random.Next(-100, 100), random.Next(-100, 100));
                }
            }
        }

        private void buttonRadEllipse_Click(object sender, EventArgs e)
        {
            if (ellipse != null)
            {
                var ar = int.TryParse(textBox10.Text, out int r);
                var ar2 = int.TryParse(textBox20.Text, out int r2);

                if (ar && ar2)
                {
                    g.Clear(Color.White);
                    ellipse.SetR(ellipse.GetR() + r);
                    ellipse.SetR2(ellipse.GetR2() + r2);
                    ellipse.Show(g, pen);
                }
                else if (ar && !ar2)
                {
                    g.Clear(Color.White);
                    ellipse.SetR(ellipse.GetR() + r);
                    ellipse.Show(g, pen);
                }
                else if (!ar && ar2)
                {
                    g.Clear(Color.White);
                    ellipse.SetR2(ellipse.GetR2() + r2);
                    ellipse.Show(g, pen);
                }
                else
                {
                    label23.Text = "Некорректный ввод координат!";
                }
            }
        }

        private void buttonRotateElipse_Click(object sender, EventArgs e)
        {
            if (ellipse != null)
            {
                ellipse.Rotate(g, pen);
            }
        }

        private void buttonCreateMassEllipse_Click(object sender, EventArgs e)
        {
            ellipse = null;

            g.Clear(Color.White);
            for (int i = 0; i < 5; i++)
            {
                ellipses[i] = new Ellipse(random);
                ellipses[i].Show(g, pen);
            }
        }

        private void buttonMoveToMassEllipse_Click(object sender, EventArgs e)
        {
            if (ellipses[1] != null)
            {
                var ax = int.TryParse(textBox14.Text, out int x);
                var ay = int.TryParse(textBox12.Text, out int y);

                if (ax && ay)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        ellipses[i].MoveTo(g, pen, x, y);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        ellipses[i].Show(g, pen);
                    }
                }
                else if (ax && !ay)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        ellipses[i].MoveTo(g, pen, x, 0);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        ellipses[i].Show(g, pen);
                    }
                }
                else if (!ax && ay)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        ellipses[i].MoveTo(g, pen, 0, y);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        ellipses[i].Show(g, pen);
                    }
                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        ellipses[i].MoveTo(g, pen, random.Next(-100, 100), random.Next(-100, 100));
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        ellipses[i].Show(g, pen);
                    }
                }
            }
        }

        private void buttonRadMassEllipse_Click(object sender, EventArgs e)
        {
            if (ellipses[1] != null)
            {
                var ar = int.TryParse(textBox11.Text, out int r);
                var ar2 = int.TryParse(textBox21.Text, out int r2);

                if (ar && ar2)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        ellipses[i].SetR(ellipses[i].GetR() + r);
                        ellipses[i].SetR2(ellipses[i].GetR2() + r2);
                    };
                    for (int i = 0; i < 5; i++)
                    {
                        ellipses[i].Show(g, pen);
                    };
                }
                else if (ar && !ar2)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        ellipses[i].SetR(ellipses[i].GetR() + r);
                    };
                    for (int i = 0; i < 5; i++)
                    {
                        ellipses[i].Show(g, pen);
                    };
                }
                else if (!ar && ar2)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        ellipses[i].SetR2(ellipses[i].GetR2() + r2);
                    };
                    for (int i = 0; i < 5; i++)
                    {
                        ellipses[i].Show(g, pen);
                    };
                }
                else
                {
                    label23.Text = "Некорректный ввод координат!";
                }
            }
        }

        private void buttonRotateMassElipse_Click(object sender, EventArgs e)
        {
            if (ellipses[1] != null)
            {

                for (int i = 0; i < 5; i++)
                {
                    ellipses[i].Rotate(g, pen);
                };
                for (int i = 0; i < 5; i++)
                {
                    ellipses[i].Show(g, pen);
                };

            }
        }
    }
}
