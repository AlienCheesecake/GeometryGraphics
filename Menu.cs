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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            DotForm dot = new DotForm();
            dot.Show();
        }

        private void button_circle_Click(object sender, EventArgs e)
        {
            CircleForm circleform = new CircleForm();
            circleform.Show();
        }

        

        private void button_rect_Click(object sender, EventArgs e)
        {
            RectangleForm rectform = new RectangleForm();
            rectform.Show();
        }

        private void button_ring_Click(object sender, EventArgs e)
        {
            RingForm ringform = new RingForm();
            ringform.Show();
        }

        private void button_circlesquare_Click(object sender, EventArgs e)
        {
            CircleSquareForm circlesquareform = new CircleSquareForm();
            circlesquareform.Show();
        }

        private void button_line_Click(object sender, EventArgs e)
        {
            LineForm lineform = new LineForm();
            lineform.Show();
        }

        private void button_tetragon_Click(object sender, EventArgs e)
        {
            TetragonForm tetragonform = new TetragonForm();
            tetragonform.Show();
        }

        private void button_ellipse_Click(object sender, EventArgs e)
        {
            EllipseForm ellipseform = new EllipseForm();
            ellipseform.Show();
        }

        private void button_rhombus_Click(object sender, EventArgs e)
        {
            RhombusForm rhombusform = new RhombusForm();
            rhombusform.Show();
        }

        private void button_polimorf_Click(object sender, EventArgs e)
        {
            PolimorfForm polimorfform = new PolimorfForm();
            polimorfform.Show();
        }

        private void button_array_Click(object sender, EventArgs e)
        {
            ArrayFigureForm arrayform = new ArrayFigureForm();
            arrayform.Show();
        }

        private void button_list_Click(object sender, EventArgs e)
        {
            ListFigureForm listform = new ListFigureForm();
            listform.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
