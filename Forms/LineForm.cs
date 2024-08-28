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
    public partial class LineForm : Form
    {
        private Line[] lines;
        Line line;

        private Graphics g;
        private Pen pen;

        private Random random;
        public LineForm()
        {
            InitializeComponent();
            lines = new Line[5];

            g = pictureBox1.CreateGraphics();
            pen = new Pen(Color.Black, 3f);
            random = new Random();
        }

        private void buttonCreateLine_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                lines[i] = null;
            }

            bool ax1 = int.TryParse(textBox1.Text, out int x1);
            bool ay1 = int.TryParse(textBox2.Text, out int y1);
            var ax2 = int.TryParse(textBox10.Text, out int x2);
            var ay2 = int.TryParse(textBox11.Text, out int y2);

            if (ax1 && ay1 && ax2 && ay2)
            {
                line = new Line(x1, y1, x2, y2);
                g.Clear(Color.White);
                line.Show(g, pen);
            }
            else
            {
                Random random = new Random();
                line = new Line(random);
                g.Clear(Color.White);
                line.Show(g, pen);
            }
        }

        private void buttonMoveToLine_Click(object sender, EventArgs e)
        {
            if(line != null)
            {
                var ax = int.TryParse(textBox3.Text, out int x);
                var ay = int.TryParse(textBox4.Text, out int y);
                if (ax && ay)
                {
                    line.MoveTo(g, pen, x, y);
                }
                else if (ax && !ay)
                {
                    line.MoveTo(g, pen, x, 0);
                }
                else if (!ax && ay)
                {
                    line.MoveTo(g, pen, 0, y);
                }
                else
                {
                    label10.Text = "Некорректный ввод координат!";
                }

            }

        }

        private void buttonRotateLine_Click(object sender, EventArgs e)
        {
            if(line != null)
            {
                var aangle = int.TryParse(textBox5.Text, out int angle);

                if (aangle)
                {
                    g.Clear(Color.White);
                    line.MoveAngle(g, pen, angle);
                }
                else
                {
                    label10.Text = "Некорректный ввод координат!";
                }
            }
        }

        private void buttonCreateMassLine_Click(object sender, EventArgs e)
        {
            line = null;

            g.Clear(Color.White);
            for (int i = 0; i < 5; i++)
            {
                lines[i] = new Line(random);
                lines[i].Show(g, pen);
            }
        }

        private void buttonMoveToMassLine_Click(object sender, EventArgs e)
        {
            if (lines[1] != null)
            {
                var ax = int.TryParse(textBox6.Text, out int x);
                var ay = int.TryParse(textBox7.Text, out int y);
                if (ax && ay)
                {

                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        if (lines[i] != null)
                            lines[i].MoveTo(g, pen, x, y);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        if (lines[i] != null)
                            lines[i].Show(g, pen);
                    }
                }
                else
                {
                    label10.Text = "Некорректный ввод координат!";
                }
            }

            
        }


        private void buttonRotateMassLine_Click(object sender, EventArgs e)
        {
            if (lines[1] != null)
            {
                var aangle = int.TryParse(textBox8.Text, out int angle);
                if (aangle)
                {
                    g.Clear(Color.White);
                    for (int i = 0; i < 5; i++)
                    {
                        if (lines[i] != null)
                            lines[i].MoveAngle(g, pen, angle);
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
