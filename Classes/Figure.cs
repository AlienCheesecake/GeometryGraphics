using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class Figure
    {
        private MyPoint point;

        public Figure(int ax, int ay)
        {
            point = new MyPoint(ax, ay);
            Check();
            Console.WriteLine("Объект Figure создан");
        }

        public Figure(Random random) 
        {
            point = new MyPoint(random);
            Console.WriteLine("Объект Figure создан");
        }

        public int GetX() { return point.GetX(); }
        public int GetY() { return point.GetY(); }

        public void SetXY(int ax, int ay) 
        { 
            point.SetXY(ax, ay);
        }

        public void SetX(int ax)
        {
            point.SetX(ax);
        }

        public void SetY(int ay)
        {
            point.SetY(ay);
        }

        public void Check(MyPoint _point)
        {
            if (_point.GetX() > 732)
            {
                _point.SetX(732);
            }
            else if (_point.GetX() < 2)
            {
                _point.SetX(2);
            }

            if (_point.GetY() > 557)
            {
                _point.SetY(557);
            }
            else if (_point.GetY() < 2)
            {
                _point.SetY(2);
            }
        }

        public void Check()
        {
            if (GetX() > 732)
            {
                SetX(732);
            }
            else if (GetX() < 2)
            {
                SetX(2);
            }

            if (GetY() > 557)
            {
                SetY(557);
            }
            else if (GetY() < 2)
            {
                SetY(2);
            }
        }

        public virtual void SetXYforMove(int ax, int ay)
        {
            SetXY(GetX() + ax, GetY() + ay);
        }

        public virtual void Show(Graphics g, Pen pen)
        {

        }

        public void MoveTo(Graphics g, Pen pen, int ax, int ay)
        {
            Pen pen1 = new Pen(Color.White, 3f);
            Show(g, pen1);

            //SetXY(GetX() + ax, GetY() + ay);
            SetXYforMove(ax, ay);

            Show(g, pen);
        }
    }
}
