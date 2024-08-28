using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class Circle:Figure
    {

        private int r;

        public Circle(Random random):base(random)
        {
            Check();
            SetRCheck(random.Next(250));
        }
        public Circle(int ax, int ay, int ar):base(ax, ay)
        {
            Check();
            SetRCheck(ar);
            Console.WriteLine("Объект Circle создан");
            //Console.WriteLine(GetX() + " " + GetY() + " " + r);
        }

        public Circle(int ax, int ay, Random random):base(ax, ay)
        {
            Check();
            SetRCheck(random.Next(250));
            Console.WriteLine("Объект Circle создан");
            //Console.WriteLine(GetX() + " " + GetY() + " " + r);
        }

        public int GetR() { return r; }

        public void SetRCheck(int ar)
        {
            if (ar<1) { r = 1; } 
            else { r = ar; }

            if (ar > 732 - GetX())
            {
                r = 734 - GetX();
            }
            else if (ar > GetX())
            {
                r = GetX();
            }

            if (r > 557 - GetY())
            {
                r = 559 - GetY();
            }
            else if (r > GetY())
            {
                r = GetY();
            }
        }

        public void SetR(int ar)
        {
            if (ar < 1) { r = 1; }
            else { r = ar; }
        }

        public override void Show(Graphics g, Pen pen)
        {
            g.DrawEllipse(pen, GetX() - r, GetY() - r, 2 * r, 2*r);
            //Console.WriteLine("Объект Circle нарисован");
        }
    }
}
