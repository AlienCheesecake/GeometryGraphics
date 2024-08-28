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
    public partial class DotForm : Form
    {
        private Dot[] dots;
        private Dot dot;

        private Graphics g;
        private Pen pen;

        private Random random;
        public DotForm()
        {
            InitializeComponent();
            dots = new Dot[5];

            g = pictureBox1.CreateGraphics();
            pen = new Pen(Color.Black, 3f);
            random = new Random();
        }

        private void buttonCreateDot_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                dots[i] = null;
            }

            bool ax = int.TryParse(textBox1.Text, out int x); 
            bool ay = int.TryParse(textBox2.Text, out int y);

            if (ax && ay)
            {
                dot = new Dot(x, y);
                g.Clear(Color.White);
                dot.Show(g, pen);
            }
            else 
            {
                Random random = new Random();
                dot = new Dot(random);
                g.Clear(Color.White);
                dot.Show(g, pen);
            }
        }

        private void buttonMoveToDot_Click(object sender, EventArgs e)
        {
            if (dot != null)
            {
                var ax = int.TryParse(textBox3.Text, out int x);
                var ay = int.TryParse(textBox4.Text, out int y);

                if (ax && ay)
                {
                    dot.MoveTo(g, pen, x, y);
                }
                else if (ax && !ay)
                {
                    dot.MoveTo(g, pen, x, 0);
                }
                else if (!ax && ay)
                {
                    dot.MoveTo(g, pen, 0, y);
                }
                else
                {
                    dot.MoveTo(g, pen, random.Next(-50, 50), random.Next(-50, 50));
                }
            }

        }

        private void buttonCreateMassDot_Click(object sender, EventArgs e)
        {
            dot = null;

            g.Clear(Color.White);
            for (int i = 0; i < 5; i++) 
            {
                dots[i] = new Dot(random);
                dots[i].Show(g, pen);
            }
        }

        private void buttonMoveToMassDot_Click(object sender, EventArgs e)
        {
            if (dots[1] != null)
            {
                var ax = int.TryParse(textBox5.Text, out int x);
                var ay = int.TryParse(textBox6.Text, out int y);
                if (ax && ay)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        dots[i].MoveTo(g, pen, x, y);
                    }
                }
                else if (ax && !ay)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        dots[i].MoveTo(g, pen, x, 0);
                    }
                }
                else if (!ax && ay)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        dots[i].MoveTo(g, pen, 0, y);
                    }
                }
                else
                {
                    for(int i = 0;i < 5; i++)
                    {
                        dots[i].MoveTo(g, pen, random.Next(-50, 50), random.Next(-50, 50));
                    }
                }
            }
        }
    }
}
