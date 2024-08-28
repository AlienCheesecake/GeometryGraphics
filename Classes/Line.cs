using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB
{
    internal class Line : Figure
    {
        //private MyPoint point1;
        private MyPoint point2;


        public Line(Random random):base(random)
        {
            int ax2 = random.Next(2, 732);
            int ay2 = random.Next(1, 557);
            point2 = new MyPoint(ax2, ay2);
            Console.WriteLine("Объект Line создан");
        }

        public Line(int ax1, int ay1, int ax2, int ay2):base(ax1, ay1)
        {
            point2 = new MyPoint(ax2, ay2);

            Check();
            Check(point2);
            Console.WriteLine("Объект Line создан");
        }
        public int GetX1() { return GetX(); }

        public int GetX2() { return point2.GetX(); }

        public int GetY1() { return GetY(); }

        public int GetY2() { return point2.GetY(); }

        public void SetXY(int ax1, int ay1, int ax2, int ay2)
        {
            SetXY(ax1, ay1);
            point2.SetXY(ax2, ay2);
        }

        public void MoveAngle(Graphics g, Pen pen, int angle) 
        {

            double dangle = angle / 57.296;
            int x0 = (GetX1() + GetX2()) / 2, y0 = (GetY1() + GetY2()) / 2;
            double a = Math.Cos(dangle), b = Math.Sin(dangle);
            double c = Math.Cos(Math.PI / 2 + dangle), d = Math.Sin(Math.PI / 2 + dangle);
            int dx1 = GetX1() - x0, dy1 = GetY1() - y0;
            int dx2 = GetX2() - x0, dy2 = GetY2() - y0;

            int tx1 = (int)(a * dx1 + b * dy1);
            int ty1 = (int)(c * dx1 + d * dy1);
            int tx2 = (int)(a * dx2 + b * dy2);
            int ty2 = (int)(c * dx2 + d * dy2);

            SetXY(tx1 + x0, ty1 + y0, tx2 + x0, ty2 + y0);

            Show(g, pen);
        }

        public override void SetXYforMove(int ax, int ay)
        {
            SetXY(GetX1() + ax, GetY1() + ay, GetX2() + ax, GetY2() + ay);
        }

        public override void Show(Graphics g, Pen pen)
        {
            g.DrawLine(pen, GetX1(), GetY1(), GetX2(), GetY2());
            //Console.WriteLine("Объект отрезок нарисован");

        }

        //public override void MoveTo(Graphics g, Pen pen, int ax, int ay)
        //{
        //    Pen pen1 = new Pen(Color.White, 3f);
        //    Show(g, pen1);
        //    SetXY(GetX1() + ax, GetY1() + ay, GetX2() + ax, GetY2() + ay);
        //    Show(g, pen);
        //}

    }
}
