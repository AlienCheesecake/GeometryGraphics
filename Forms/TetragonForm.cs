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
    public partial class TetragonForm : Form
    {
        private Tetragon tetragon;
        private Tetragon[] tetragons;

        private Graphics g;
        private Pen pen;

        private Random random;
        public TetragonForm()
        {
            InitializeComponent();
            tetragons = new Tetragon[5];

            g = pictureBox1.CreateGraphics();
            pen = new Pen(Color.Black, 3f);
            random = new Random();
        }

        private void buttonCreateTetregon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                tetragons[i] = null;
            }

            bool ax = int.TryParse(textBox1.Text, out int x);
            bool ay = int.TryParse(textBox2.Text, out int y);
            
            tetragon = new Tetragon(random);
            g.Clear(Color.White);
            tetragon.Show(g, pen);

            if (ax && ay)
            {
                tetragon = new Tetragon(random, x, y);
            }
            else
            {
                tetragon = new Tetragon(random);
            }
        }

        private void buttonMoveToTetragon_Click(object sender, EventArgs e)
        {
            if (tetragon != null)
            {
                var ax = int.TryParse(textBox3.Text, out int x);
                var ay = int.TryParse(textBox4.Text, out int y);

                if (ax && ay)
                {
                    tetragon.MoveTo(g, pen, x, y);
                }
                else if (ax && !ay)
                {
                    tetragon.MoveTo(g, pen, x, 0);
                }
                else if (!ax && ay)
                {
                    tetragon.MoveTo(g, pen, 0, y);
                }
                else
                {
                    tetragon.MoveTo(g, pen, random.Next(-50, 50), random.Next(-50, 50));
                }
            }
        }

        private void buttonCreateMassTetragon_Click(object sender, EventArgs e)
        {
            tetragon = null;

            g.Clear(Color.White);
            for (int i = 0; i < 5; i++)
            {
                tetragons[i] = new Tetragon(random);
                tetragons[i].Show(g, pen);
            }
        }

        private void buttonMoveToMassTetragon_Click(object sender, EventArgs e)
        {
            if (tetragons[1] != null)
            {
                var ax = int.TryParse(textBox5.Text, out int x);
                var ay = int.TryParse(textBox6.Text, out int y);
                if (ax && ay)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        tetragons[i].MoveTo(g, pen, x, y);
                    }
                    for (int i = 0;i < 5;i++)
                    {
                        tetragons[i].Show(g, pen);
                    }
                }
                else if (ax && !ay)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        tetragons[i].MoveTo(g, pen, x, 0);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        tetragons[i].Show(g, pen);
                    }
                }
                else if (!ax && ay)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        tetragons[i].MoveTo(g, pen, 0, y);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        tetragons[i].Show(g, pen);
                    }
                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        tetragons[i].MoveTo(g, pen, random.Next(-50, 50), random.Next(-50, 50));
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        tetragons[i].Show(g, pen);
                    }
                }
            }
        }
    }
}
