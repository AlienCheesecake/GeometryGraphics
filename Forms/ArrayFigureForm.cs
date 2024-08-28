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
    public partial class ArrayFigureForm : Form
    {
        private ArrayFigure figures;
        private Pen pen;
        private Graphics g;
        public ArrayFigureForm()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            pen = new Pen(Color.Black, 3f);
        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (figures == null)
            {
                figures = new ArrayFigure();
            }
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            if (figures != null)
            {
                figures.Iterator(g, pen, "Show");
            }

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (figures != null)
            {
                figures.Add();
            }
        }

        private void button_Erase_Click(object sender, EventArgs e)
        {
            if (figures != null)
            {
                figures.Iterator(g, pen, "UnVisible");
            }
        }

        private void button_Desrtoy_Click(object sender, EventArgs e)
        {
            if (figures != null)
            {
                figures.Iterator(g, pen, "Destroy");
                figures = null;
            }
        }


        private void buttonMoveToMassRobus_Click(object sender, EventArgs e)
        {
            if (figures != null)
            {
                Random random = new Random();

                var ax = int.TryParse(textBox14.Text, out int x);
                var ay = int.TryParse(textBox12.Text, out int y);


                if (ax && ay)
                {
                    figures.Iterator(g, pen, "MoveTo", x, y);
                }
                else if (ax && !ay)
                {
                    figures.Iterator(g, pen, "MoveTo", x);
                }
                else if (!ax && ay)
                {
                    figures.Iterator(g, pen, "MoveTo", 0, y);
                }
                else
                {
                    figures.Iterator(g, pen, "MoveTo", random.Next(-20, 20), random.Next(-20, 20));
                }

                figures.Iterator(g, pen, "Show");


            }
        }

      
    }
}
