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
    public partial class RhombusForm : Form
    {
        private Rhombus[] rhombuses;
        private Rhombus rhombus;

        private Graphics g;
        private Pen pen;

        private Random random;
        public RhombusForm()
        {
            InitializeComponent();
            rhombuses = new Rhombus[5];

            g = pictureBox1.CreateGraphics();
            pen = new Pen(Color.Black, 3f);
            random = new Random();
        }

        private void buttonCreateRombus_Click(object sender, EventArgs e)
        {
            bool ax = int.TryParse(textBox18.Text, out int x);
            bool ay = int.TryParse(textBox17.Text, out int y);
            bool ar = int.TryParse(textBox16.Text, out int r);
            bool ar2 = int.TryParse(textBox19.Text, out int r2);
            if (ax && ay && ar && ar2)
            {
                rhombus = new Rhombus(random, x, y, r, r2);
                g.Clear(Color.White);
                rhombus.Show(g, pen);
            }
            else
            {
                rhombus = new Rhombus(random);
                g.Clear(Color.White);
                rhombus.Show(g, pen);
            }
        }

        private void buttonMoveToRombus_Click(object sender, EventArgs e)
        {
            if (rhombus != null)
            {
                var ax = int.TryParse(textBox15.Text, out int x);
                var ay = int.TryParse(textBox13.Text, out int y);

                if (ax && ay)
                {
                    rhombus.MoveTo(g, pen, x, y);
                }
                else if (ax && !ay)
                {
                    rhombus.MoveTo(g, pen, x, 0);
                }
                else if (!ax && ay)
                {
                    rhombus.MoveTo(g, pen, 0, y);
                }
                else
                {
                    rhombus.MoveTo(g, pen, random.Next(-100, 100), random.Next(-100, 100));
                }
            }
        }

        private void buttonRadRombus_Click(object sender, EventArgs e)
        {
            if (rhombus != null)
            {
                var ar = int.TryParse(textBox10.Text, out int r);
                var ar2 = int.TryParse(textBox20.Text, out int r2);

                if (ar && ar2)
                {
                    g.Clear(Color.White);
                    rhombus.SetD1(rhombus.GetD1() + r);
                    rhombus.SetD2(rhombus.GetD2() + r2);
                    rhombus.Show(g, pen);
                }
                else if (ar && !ar2)
                {
                    g.Clear(Color.White);
                    rhombus.SetD1(rhombus.GetD1() + r);
                    rhombus.Show(g, pen);
                }
                else if (!ar && ar2)
                {
                    g.Clear(Color.White);
                    rhombus.SetD2(rhombus.GetD2() + r2);
                    rhombus.Show(g, pen);
                }
                else
                {
                    label23.Text = "Некорректный ввод координат!";
                }
            }
        }

        private void buttonRotateRombus_Click(object sender, EventArgs e)
        {
            if (rhombus != null)
            {
                rhombus.Rotate(g, pen);

            }
        }

        private void buttonCreateMassRombus_Click(object sender, EventArgs e)
        {
            rhombus = null;

            g.Clear(Color.White);
            for (int i = 0; i < 5; i++)
            {
                rhombuses[i] = new Rhombus(random);
                rhombuses[i].Show(g, pen);
            }
        }

        private void buttonMoveToMassRobus_Click(object sender, EventArgs e)
        {
            if (rhombuses[1] != null)
            {
                var ax = int.TryParse(textBox14.Text, out int x);
                var ay = int.TryParse(textBox12.Text, out int y);

                if (ax && ay)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        rhombuses[i].MoveTo(g, pen, x, y);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        rhombuses[i].Show(g, pen);
                    }
                }
                else if (ax && !ay)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        rhombuses[i].MoveTo(g, pen, x, 0);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        rhombuses[i].Show(g, pen);
                    }
                }
                else if (!ax && ay)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        rhombuses[i].MoveTo(g, pen, 0, y);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        rhombuses[i].Show(g, pen);
                    }
                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        rhombuses[i].MoveTo(g, pen, random.Next(-100, 100), random.Next(-100, 100));
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        rhombuses[i].Show(g, pen);
                    }
                }
            }
        }

        private void buttonRadMassRombus_Click(object sender, EventArgs e)
        {
            if (rhombuses[1] != null)
            {
                var ar = int.TryParse(textBox11.Text, out int r);
                var ar2 = int.TryParse(textBox21.Text, out int r2);

                if (ar && ar2)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        g.Clear(Color.White);
                        rhombuses[i].SetD1(rhombuses[i].GetD1() + r);
                        rhombuses[i].SetD2(rhombuses[i].GetD2() + r2);
                    };
                    for (int i = 0; i < 5; i++)
                    {
                        rhombuses[i].Show(g, pen);
                    };
                }
                else if (ar && !ar2)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        rhombuses[i].SetD1(rhombuses[i].GetD1() + r);
                    };
                    for (int i = 0; i < 5; i++)
                    {
                        rhombuses[i].Show(g, pen);
                    };
                }
                else if (!ar && ar2)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        rhombuses[i].SetD2(rhombuses[i].GetD2() + r2);
                    };
                    for (int i = 0; i < 5; i++)
                    {
                        rhombuses[i].Show(g, pen);
                    };
                }
                else
                {
                    label23.Text = "Некорректный ввод координат!";
                }
            }
        }

        private void buttonRotateMassRombus_Click(object sender, EventArgs e)
        {
            if (rhombuses[1] != null)
            {
                for (int i = 0; i < 5; i++)
                {
                    rhombuses[i].Rotate(g, pen);
                };
                for (int i = 0; i < 5; i++)
                {
                    rhombuses[i].Show(g, pen);
                };
            }
        }
    }
}
