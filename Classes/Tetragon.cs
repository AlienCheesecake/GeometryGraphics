using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB
{
    internal class Tetragon:Figure
    {
        private MyPoint point2;
        private MyPoint point3;
        private MyPoint point4;

        public Tetragon(int ax, int ay,  int ax2, int ay2, int ax3, int ay3, int ax4, int ay4):base(ax,ay)
        {
            point2 = new MyPoint(ax2, ay2);
            point3 = new MyPoint(ax3, ay3);
            point4 = new MyPoint(ax4, ay4);
            Check();
            Check(point2);
            Check(point3);
            Check(point4);

            Console.WriteLine("Объект Tetragon создан");
            Console.WriteLine(GetX()+ " " + GetY());
            Console.WriteLine(GetX2() + " " + GetY2());
            Console.WriteLine(GetX3() + " " + GetY3());
            Console.WriteLine(GetX4() + " " + GetY4());
        }

        public Tetragon(Random random, int ax, int ay) : base(ax, ay)
        {
            point2 = new MyPoint(GetX() + random.Next(50, 150), GetY() + random.Next(-10, 10));
            point3 = new MyPoint(GetX2() + random.Next(-10, 10), GetY2() + random.Next(50, 150));
            point4 = new MyPoint(GetX3() + random.Next(-150, -50), GetY3() + random.Next(-10, 10));
            Check();
            Check(point2);
            Check(point3);
            Check(point4);

            Console.WriteLine("Объект Tetragon создан");
            Console.WriteLine(GetX() + " " + GetY());
            Console.WriteLine(GetX2() + " " + GetY2());
            Console.WriteLine(GetX3() + " " + GetY3());
            Console.WriteLine(GetX4() + " " + GetY4());
        }
        public Tetragon(Random random) : base(random) 
        {
            Check();
            point2 = new MyPoint(GetX() + random.Next(50, 250), GetY() + random.Next(-10, 10)) ;
            Check(point2);
            point3 = new MyPoint(GetX2() + random.Next(-10, 10), GetY2() + random.Next(50, 250));
            Check(point3);
            point4 = new MyPoint(GetX3() + random.Next(-250, -50), GetY3() + random.Next(-10, 10));
            Check(point4);

            Console.WriteLine("Объект Tetragon создан");
            Console.WriteLine(GetX() + " " + GetY());
            Console.WriteLine(GetX2() + " " + GetY2());
            Console.WriteLine(GetX3() + " " + GetY3());
            Console.WriteLine(GetX4() + " " + GetY4());
        }

        public int GetX2() { return point2.GetX(); }

        public int GetX3() { return point3.GetX(); }

        public int GetX4() { return point4.GetX(); }

        public int GetY2() { return point2.GetY(); }

        public int GetY3() { return point3.GetY(); }

        public int GetY4() { return point4.GetY(); }

        public void SetXY2(int ax2, int ay2) { point2.SetX(ax2); point2.SetY(ay2); }

        public void SetXY3(int ax3, int ay3) { point3.SetX(ax3); point3.SetY(ay3); }

        public void SetXY4(int ax4, int ay4) { point4.SetX(ax4); point4.SetY(ay4); }


        public override void SetXYforMove(int ax, int ay)
        {
            SetXY(GetX() + ax, GetY() + ay);
            SetXY2(GetX2() + ax, GetY2() + ay);
            SetXY3(GetX3() + ax, GetY3() + ay);
            SetXY4(GetX4() + ax, GetY4() + ay);
        }

        public override void Show(Graphics g, Pen pen)
        {
            g.DrawLine(pen, GetX(), GetY(), GetX2(), GetY2());
            g.DrawLine(pen, GetX2(), GetY2(), GetX3(), GetY3());
            g.DrawLine(pen, GetX3(), GetY3(), GetX4(), GetY4());
            g.DrawLine(pen, GetX4(), GetY4(), GetX(), GetY());

            Console.WriteLine("Объект Tetragon нарисован");
            Console.WriteLine(GetX() + " " + GetY());
            Console.WriteLine(GetX2() + " " + GetY2());
            Console.WriteLine(GetX3() + " " + GetY3());
            Console.WriteLine(GetX4() + " " + GetY4());
        }

    }
}
