using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB
{
    public partial class RectangleForm : Form
    {
        private Rectangle[] rects;
        private Rectangle rect;

        private Graphics g;
        private Pen pen;

        private Random random;
        public RectangleForm()
        {
            InitializeComponent();
            rects = new Rectangle[5];

            g = pictureBox1.CreateGraphics();
            pen = new Pen(Color.Black, 3f);
            random = new Random();
        }

        private void buttonCreateRect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                rects[i] = null;
            }

            bool ax = int.TryParse(textBox1.Text, out int x);
            bool ay = int.TryParse(textBox2.Text, out int y);
            var aw = int.TryParse(textBox10.Text, out int w);
            var ah = int.TryParse(textBox11.Text, out int h);

            if (ax && ay && aw && ah)
            {
                rect = new Rectangle(random, x, y, w, h);
                g.Clear(Color.White);
                rect.Show(g, pen);
            }
            else
            {

                rect = new Rectangle(random);
                g.Clear(Color.White);
                rect.Show(g, pen);
            }
        }

        private void buttonMoveToRect_Click(object sender, EventArgs e)
        {
            if (rect != null)
            {
                var ax = int.TryParse(textBox3.Text, out int x);
                var ay = int.TryParse(textBox4.Text, out int y);

                if (ax && ay)
                {
                    rect.MoveTo(g, pen, x, y);
                }
                else if (ax && !ay)
                {
                    rect.MoveTo(g, pen, x, 0);
                }
                else if (!ax && ay)
                {
                    rect.MoveTo(g, pen, 0, y);
                }
                else
                {
                    rect.MoveTo(g, pen, random.Next(-50, 50), random.Next(-50, 50));
                }
            }
        }

        private void buttonRadRect_Click(object sender, EventArgs e)
        {
            if (rect != null)
            {
                var aw = int.TryParse(textBox5.Text, out int w);
                var ah = int.TryParse(textBox13.Text, out int h);
                if (aw && ah)
                {
                    g.Clear(Color.White);
                    rect.SetWH(rect.GetWidth() + w, rect.GetHeight() + h);
                    rect.Show(g, pen);
                }
                else if (aw && !ah)
                {
                    g.Clear(Color.White);
                    rect.SetWH(rect.GetWidth() + w, rect.GetHeight());
                    rect.Show(g, pen);
                }
                else if (!aw && ah)
                {
                    g.Clear(Color.White);
                    rect.SetWH(rect.GetWidth(), rect.GetHeight() + h);
                    rect.Show(g, pen);
                }
                else
                {
                    label10.Text = "Некорректный ввод координат!";
                }
            }

        }

        private void buttonCreateMassRect_Click(object sender, EventArgs e)
        {
            rect = null;
            g.Clear(Color.White);
            for (int i = 0; i < 5; i++)
            {
                rects[i] = new Rectangle(random);
                rects[i].Show(g, pen);
            }
        }

        private void buttonMoveToMassRect_Click(object sender, EventArgs e)
        {
            if (rects[1] != null)
            {
                var ax = int.TryParse(textBox6.Text, out int x);
                var ay = int.TryParse(textBox7.Text, out int y);
                if (ax && ay)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        rects[i].MoveTo(g, pen, x, y);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        rects[i].Show(g, pen);
                    }
                }
                else if (ax && !ay)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        rects[i].MoveTo(g, pen, x, 0);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        rects[i].Show(g, pen);
                    }
                }
                else if (!ax && ay)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        rects[i].MoveTo(g, pen, 0, y);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        rects[i].Show(g, pen);
                    }
                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        rects[i].MoveTo(g, pen, random.Next(-50, 50), random.Next(-50, 50));
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        rects[i].Show(g, pen);
                    }
                }
            }
                
        }

        private void buttonRadMassRect_Click(object sender, EventArgs e)
        {
            if (rects[1] != null)
            {
                var aw = int.TryParse(textBox8.Text, out int w);
                var ah = int.TryParse(textBox9.Text, out int h);
                if (aw && ah)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        if (rects[i] != null)
                        {
                            rects[i].SetWH(rects[i].GetWidth() + w, rects[i].GetHeight() + h);
                            rects[i].Show(g, pen);
                        }
                    }
                }
                else if (aw && !ah)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        if (rects[i] != null)
                        {
                            rects[i].SetWH(rects[i].GetWidth() + w, rects[i].GetHeight());
                            rects[i].Show(g, pen);
                        }
                    }
                }
                else if (!aw && ah)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        if (rects[i] != null)
                        {
                            rects[i].SetWH(rects[i].GetWidth(), rects[i].GetHeight() + h);
                            rects[i].Show(g, pen);
                        }
                    }
                }
                else
                {
                    label10.Text = "Некорректный ввод!";
                }
            }
        }
    }
}
