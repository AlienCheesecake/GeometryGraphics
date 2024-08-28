using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB
{
    internal class Rhombus:Tetragon
    {
        int d1;
        int d2;
        MyPoint center;
        public Rhombus(Random random, int ax, int ay, int ad1, int ad2) : base(random)
        {
            d1 = ad1;
            d2 = ad2;
            center = new MyPoint(ax, ay);
            Check(center);

            if (d1 > 1 + center.GetY())
            {
                d1 = center.GetY();
            }
            if (d1 > 559 - center.GetY())
            {
                d1 = 557 - center.GetY();
            }

            if (d2 > 1 + center.GetX())
            {
                d2 = center.GetX();
            }
            if (d2 > 734 - center.GetX())
            {
                d2 = 732 - center.GetX();
            }

            SetXY(center.GetX(), center.GetY() - d1);
            SetXY2(center.GetX() + d2, center.GetY());
            SetXY3(center.GetX(), center.GetY() + d1);
            SetXY4(center.GetX() - d2, center.GetY());
        }

        public Rhombus(Random random) : base(random)
        {
            int ad1 = random.Next(2, 200);
            int ad2 = random.Next(2, 200);
            int ax = random.Next(2, 732);
            int ay = random.Next(2, 557);
            center = new MyPoint(ax, ay);
            Check(center);

            d1 = ad1;
            d2 = ad2;


            if (d1 > 1 + center.GetY())
            {
                d1 = center.GetY();
            }
            if (d1 > 557 - center.GetY())
            {
                d1 = 559 - center.GetY();
            }

            if (d2 > 1 + center.GetX())
            {
                d2 = center.GetX();
            }
            if (d2 > 732 - center.GetX())
            {
                d2 = 734 - center.GetX();
            }

            SetXY(center.GetX(), center.GetY() - d1);
            SetXY2(center.GetX() + d2, center.GetY());
            SetXY3(center.GetX(), center.GetY() + d1);
            SetXY4(center.GetX() - d2, center.GetY());
        }

        public int GetD1()
        {
            return d1;
        }

        public int GetD2()
        {
            return d2;
        }

        public void SetD1(int ad1)
        {
            d1 = ad1;
            SetXY(center.GetX(), center.GetY() - d1);
            SetXY2(center.GetX() + d2, center.GetY());
            SetXY3(center.GetX(), center.GetY() + d1);
            SetXY4(center.GetX() - d2, center.GetY());
        }

        public void SetD2(int ad2) 
        { 
            d2 = ad2;
            SetXY(center.GetX(), center.GetY() - d1);
            SetXY2(center.GetX() + d2, center.GetY());
            SetXY3(center.GetX(), center.GetY() + d1);
            SetXY4(center.GetX() - d2, center.GetY());
        }


        public void Rotate(Graphics g, Pen pen)
        {
            Pen pen1 = new Pen(Color.White, 3f);
            Show(g, pen1);

            int d;
            d = d1;
            d1 = d2;
            d2 = d;

            SetXY(center.GetX(), center.GetY() - d1);
            SetXY2(center.GetX() + d2, center.GetY());
            SetXY3(center.GetX(), center.GetY() + d1);
            SetXY4(center.GetX() - d2, center.GetY());

            Show(g, pen);
        }




    }
}
