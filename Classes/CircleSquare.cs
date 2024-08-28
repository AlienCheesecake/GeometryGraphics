using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB
{
    internal class CircleSquare
    {
        private Circle circle;
        private Rectangle rect;

        public CircleSquare(Random random)
        {
            circle = new Circle(random);
            rect = new Rectangle(random, GetX() - GetR(), GetY() - GetR(), 2 * GetR(), 2 * GetR());
            Console.WriteLine("Объект CircleSquare создан");
        }

        public CircleSquare(int ax, int ay, Random random)
        {
            circle = new Circle(ax, ay, random);
            rect = new Rectangle(random, GetX() - GetR(), GetY() - GetR(), 2 * GetR(), 2 * GetR());
            Console.WriteLine("Объект CircleSquare создан");
        }

        public CircleSquare(int ax, int ay, int ar, Random random)
        {
            circle = new Circle(ax, ay, ar);
            rect = new Rectangle(random, GetX() - GetR(), GetY() - GetR(), 2 * GetR(), 2 * GetR());
            Console.WriteLine("Объект CircleSquare создан");
        }

        public int GetX()
        {
            return circle.GetX();
        }

        public int GetY()
        {
            return circle.GetY();
        }

        public int GetR()
        {
            return circle.GetR();
        }

        public void SetXY(int ax, int ay)
        {
            circle.SetXY(ax, ay);
            rect.SetXY(ax - GetR(), ay - GetR());
        }

        public void SetR(int ar) 
        {
            circle.SetR(ar);
            rect.SetXY(GetX() - GetR(), GetY() - GetR());
            rect.SetWH(GetR() * 2, GetR() * 2);
        }

        public void Show(Graphics g, Pen pen)
        {
            circle.Show(g, pen);
            rect.Show(g, pen);
        }

        public void MoveTo(Graphics g, Pen pen, int ax, int ay)
        {

            rect.MoveTo(g, pen, ax, ay);
            circle.MoveTo(g, pen, ax, ay);

        }
    }
}
