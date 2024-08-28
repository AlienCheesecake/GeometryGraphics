using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB
{
    public partial class PolimorfForm : Form
    {
        private Figure[] figures;

        private Graphics g;
        private Pen pen;

        private Random random;
        public PolimorfForm()
        {
            InitializeComponent();

            g = pictureBox1.CreateGraphics();
            pen = new Pen(Color.Black, 3f);

            random = new Random();

            figures = new Figure[20];
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (figures[0] == null)
            {
                int num;
                for (int i = 0; i < figures.Length; i++)
                {
                    num = random.Next(0, 6);
                    switch (num)
                    {
                        case 0:
                            figures[i] = new Circle(random);
                            break;
                        case 1:
                            figures[i] = new Ellipse(random);
                            break;
                        case 2:
                            figures[i] = new Rhombus(random);
                            break;
                        case 3:
                            figures[i] = new Rectangle(random);
                            break;
                        case 4:
                            figures[i] = new Line(random);
                            break;
                        case 5:
                            figures[i] = new Tetragon(random);
                            break;
                    }
                }
            }

        }

        private void button_Show_Click(object sender, EventArgs e)
        {

            if (figures[0] != null)
            {
                for (int i = 0; i < figures.Length; i++)
                {
                    figures[i].Show(g, pen);
                }
            }

        }

        private void button_Erase_Click(object sender, EventArgs e)
        {
            if (figures[0] != null)
            {
                g.Clear(Color.White);
            }

        }

        private void button_Desrtoy_Click(object sender, EventArgs e)
        {
            if (figures[0] != null)
            {
                g.Clear(Color.White);

                for (int i = 0; i < figures.Length; i++)
                {
                    figures[i] = null;
                }
            }
        }

        private void PolimorfForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (figures[0] != null)
            {
                int x = 0;
                int y = 0;

                if (e.KeyCode == Keys.S)
                {
                    x = 0;
                    y = 10;
                }

                if (e.KeyCode == Keys.W)
                {
                    x = 0;
                    y = -10;
                }

                if (e.KeyCode == Keys.D)
                {
                    x = 10;
                    y = 0;
                }

                if (e.KeyCode == Keys.A)
                {
                    x = -10;
                    y = 0;
                }

                for (int i = 0; i < figures.Length; i++)
                {
                    if ((comboBox1.Text == "Круги" || comboBox1.Text == "Все") && !(figures[i] is Ellipse) && (figures[i] is Circle circle))
                    {
                        circle.MoveTo(g, pen, x, y);
                    }
                    if ((comboBox1.Text == "Четырехугольники" || comboBox1.Text == "Все") && !(figures[i] is Rhombus) && !(figures[i] is Rectangle) && (figures[i] is Tetragon tetr))
                    {
                        tetr.MoveTo(g, pen, x, y);
                    }
                    if ((comboBox1.Text == "Прямоугольники" || comboBox1.Text == "Все") && (figures[i] is Rectangle rect))
                    {
                        rect.MoveTo(g, pen, x, y);
                    }
                    if ((comboBox1.Text == "Ромбы" || comboBox1.Text == "Все") && (figures[i] is Rhombus rhomb))
                    {
                         rhomb.MoveTo(g, pen, x, y);
                    }
                    if ((comboBox1.Text == "Линии" || comboBox1.Text == "Все") && (figures[i] is Line line))
                    {
                         line.MoveTo(g, pen, x, y);
                    }
                    if ((comboBox1.Text == "Эллипсы" || comboBox1.Text == "Все") && (figures[i] is Ellipse ellipse))
                    {
                         ellipse.MoveTo(g, pen, x, y);
                    }
                }

                for (int i = 0; i < figures.Length; i++)
                {
                    figures[i].Show(g, pen);
                }
            }            

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            {
                case "Все":
                    textBoxH.ReadOnly = true;
                    textBoxW.ReadOnly = true;
                    textBoxr1.ReadOnly = true;
                    textBoxr2.ReadOnly = true;
                    textBoxR.ReadOnly = true;
                    textBoxRotate.ReadOnly = true;
                    button_Rotate.Enabled = false;
                    button_Applay.Enabled = false;
                    break;
                case "Круги":
                    textBoxR.ReadOnly = false;
                    textBoxH.ReadOnly = true;
                    textBoxW.ReadOnly = true;
                    textBoxr1.ReadOnly = true;
                    textBoxr2.ReadOnly = true;
                    textBoxRotate.ReadOnly = true;
                    button_Rotate.Enabled = false;
                    button_Applay.Enabled = true;
                    break;
                case "Ромбы":
                    textBoxR.ReadOnly = true;
                    textBoxH.ReadOnly = true;
                    textBoxW.ReadOnly = true;
                    textBoxr1.ReadOnly = false;
                    textBoxr2.ReadOnly = false;
                    textBoxRotate.ReadOnly = true;
                    button_Rotate.Enabled = true;
                    button_Applay.Enabled = true;
                    break;
                case "Прямоугольники":
                    textBoxR.ReadOnly = true;
                    textBoxH.ReadOnly = false;
                    textBoxW.ReadOnly = false;
                    textBoxr1.ReadOnly = true;
                    textBoxr2.ReadOnly = true;
                    textBoxRotate.ReadOnly = true;
                    button_Rotate.Enabled = false;
                    button_Applay.Enabled = true;
                    break;
                case "Четырехоугольники":
                    textBoxH.ReadOnly = true;
                    textBoxW.ReadOnly = true;
                    textBoxr1.ReadOnly = true;
                    textBoxr2.ReadOnly = true;
                    textBoxR.ReadOnly = true;
                    textBoxRotate.ReadOnly = true;
                    button_Rotate.Enabled = false;
                    break;
                case "Эллипсы":
                    textBoxR.ReadOnly = true;
                    textBoxH.ReadOnly = true;
                    textBoxW.ReadOnly = true;
                    textBoxr1.ReadOnly = false;
                    textBoxr2.ReadOnly = false;
                    textBoxRotate.ReadOnly = true;
                    button_Rotate.Enabled = true;
                    button_Applay.Enabled = true;
                    break;
                case "Линии":
                    textBoxR.ReadOnly = true;
                    textBoxH.ReadOnly = true;
                    textBoxW.ReadOnly = true;
                    textBoxr1.ReadOnly = true;
                    textBoxr2.ReadOnly = true;
                    textBoxRotate.ReadOnly = false;
                    button_Rotate.Enabled = false;
                    button_Applay.Enabled = true;
                    break;
            }

        }

        private void button_Applay_Click(object sender, EventArgs e)
        {
            if (figures[0] != null)
            {
                Pen pen1 = new Pen(Color.White, 3f);

                for (int i = 0; i < figures.Length; i++)
                {
                    if (!(figures[i] is Ellipse) && (figures[i] is Circle circle) && (comboBox1.Text == "Круги"))
                    {
                        var ar = int.TryParse(textBoxR.Text, out int r);
                        if (ar)
                        {
                            circle.Show(g, pen1);
                            circle.SetR(circle.GetR() + r);
                            circle.Show(g, pen);
                        }
                    }

                    if ((comboBox1.Text == "Эллипсы") && (figures[i] is Ellipse ellipse))
                    {
                        var ar = int.TryParse(textBoxr1.Text, out int r);
                        var ar2 = int.TryParse(textBoxr2.Text, out int r2);

                        if (ar && ar2)
                        {
                            ellipse.Show(g, pen1);
                            ellipse.SetR(ellipse.GetR() + r);
                            ellipse.SetR2(ellipse.GetR2() + r2);
                            ellipse.Show(g, pen);
                        }
                        else if (ar && !ar2)
                        {
                            ellipse.Show(g, pen1);
                            ellipse.SetR(ellipse.GetR() + r);
                            ellipse.Show(g, pen);
                        }
                        else if (!ar && ar2)
                        {
                            ellipse.Show(g, pen1);
                            ellipse.SetR2(ellipse.GetR2() + r2);
                            ellipse.Show(g, pen);
                        }
                    }

                    if ((comboBox1.Text == "Линии") && (figures[i] is Line line))
                    {
                        var aangle = int.TryParse(textBoxRotate.Text, out int angle);

                        if (aangle)
                        {
                            line.Show(g, pen1);
                            line.MoveAngle(g, pen, angle);
                        }
                    }

                    if ((comboBox1.Text == "Ромбы") && (figures[i] is Rhombus rhomb))
                    {
                        var ar = int.TryParse(textBoxr1.Text, out int r);
                        var ar2 = int.TryParse(textBoxr2.Text, out int r2);


                        if (ar && ar2)
                        {
                            rhomb.Show(g, pen1);
                            rhomb.SetD1(rhomb.GetD1() + r);
                            rhomb.SetD2(rhomb.GetD2() + r2);
                            rhomb.Show(g, pen);
                        }
                        else if (ar && !ar2)
                        {
                            rhomb.Show(g, pen1);
                            rhomb.SetD1(rhomb.GetD1() + r);
                            rhomb.Show(g, pen);
                        }
                        else if (!ar && ar2)
                        {
                            rhomb.Show(g, pen1);
                            rhomb.SetD2(rhomb.GetD2() + r2);
                            rhomb.Show(g, pen);
                        }
                    }

                    if ((comboBox1.Text == "Прямоугольники") && (figures[i] is Rectangle rect))
                    {
                        var aw = int.TryParse(textBoxW.Text, out int w);
                        var ah = int.TryParse(textBoxH.Text, out int h);
                        if (aw && ah)
                        {
                            rect.Show(g, pen1);
                            rect.SetWH(rect.GetWidth() + w, rect.GetHeight() + h);
                            rect.Show(g, pen);
                        }
                        else if (aw && !ah)
                        {
                            rect.Show(g, pen1);
                            rect.SetWH(rect.GetWidth() + w, rect.GetHeight());
                            rect.Show(g, pen);
                        }
                        else if (!aw && ah)
                        {
                            rect.Show(g, pen1);
                            rect.SetWH(rect.GetWidth(), rect.GetHeight() + h);
                            rect.Show(g, pen);
                        }
                    }
                }

                for (int i = 0; i < figures.Length; i++)
                {
                    figures[i].Show(g, pen);
                }

            }
        }

        private void button_Rotate_Click(object sender, EventArgs e)
        {
            if (figures[0] != null)
            {
                for (int i = 0; i < figures.Length; i++)
                {
                    if ((comboBox1.Text == "Ромбы") && (figures[i] is Rhombus rhomb))
                    {
                        rhomb.Rotate(g, pen);
                    }

                    if ((comboBox1.Text == "Эллипсы") && (figures[i] is Ellipse ellipse))
                    {
                        ellipse.Rotate(g, pen);
                    }
                }

                for (int i = 0; i < figures.Length; i++)
                {
                    figures[i].Show(g, pen);
                }
            }
        }

    }


}
