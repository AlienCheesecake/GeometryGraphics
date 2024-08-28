using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class Ring
    {
        private Circle SmallCircle;
        private Circle BigCircle;
        public Ring(Random random)
        {
            int ar = random.Next(51, 250);
            int aR = random.Next(1, 50);
            //MyPoint point = new MyPoint(random);
            int ax = random.Next(2, 732);
            int ay = random.Next(2, 557);

            if (aR >= 2 || ar >= 2)
            {
                if (aR > ar)
                {
                    BigCircle = new Circle(ax, ay, aR);
                    SmallCircle = new Circle(ax, ay, ar);
                }
                else if (ar > aR)
                {
                    BigCircle = new Circle(ax, ay, ar);
                    SmallCircle = new Circle(ax, ay, aR);
                }
                else
                {
                    BigCircle = new Circle(ax, ay, aR);
                    SmallCircle = new Circle(ax, ay, ar - 1);
                }
            }
            else
            {
                BigCircle = new Circle(ax, ay, 2);
                SmallCircle = new Circle(ax, ay, 1);
            }

            if (BigCircle.GetR() <= SmallCircle.GetR())
            {
                SmallCircle.SetR(BigCircle.GetR() - 1);
            }

            Console.WriteLine("Объект Ring создан");
            //Console.WriteLine("Объект кольцо создан: " +  SmallCircle.GetR() + " " + BigCircle.GetR());
            //BigCircle = new Circle(random);
            //SmallCircle = new Circle(BigCircle.GetX(), BigCircle.GetY(), random);
        }

        public Ring(int ax, int ay, int aR, int ar) 
        {
            //MyPoint point = new MyPoint(ax, ay);

            if ((aR >= 2 || ar >= 2) && (ar >= 1) && (aR >= 1) )
            {
                if (aR > ar)
                {
                    BigCircle = new Circle(ax, ay, aR);
                    SmallCircle = new Circle(ax, ay, ar);
                }
                else if (ar > aR)
                {
                    BigCircle = new Circle(ax, ay, ar);
                    SmallCircle = new Circle(ax, ay, aR);
                }
                else
                {
                    BigCircle = new Circle(ax, ay, aR);
                    SmallCircle = new Circle(ax, ay, ar - 1);
                }
            }
            else
            {
                BigCircle = new Circle(ax, ay, 2);
                SmallCircle = new Circle(ax, ay, 1);
            }

            Console.WriteLine("Объект Ring создан");
        }



        public int GetX()
        {
            return BigCircle.GetX();
        }

        public int GetY()
        {
            return BigCircle.GetY();
        }

        public int GetR()
        {
            return BigCircle.GetR();
        }

        public int Getr()
        {
            return SmallCircle.GetR();
        }

        public void SetXY(int ax, int ay)
        {
            BigCircle.SetXY(ax, ay);
            SmallCircle.SetXY(ax, ay);
        }

        public void SetR(int ar)
        {
            if (ar <= Getr())
            {
                BigCircle.SetR(Getr() + 1);
            }
            else
            {
                BigCircle.SetR(ar);
            }
        }

        public void Setr(int ar)
        {
            if (ar >= GetR())
            {
                SmallCircle.SetR(GetR()-1);
            }
            else
            {
                SmallCircle.SetR(ar);
            }
        }

        public void Show(Graphics g, Pen pen)
        {
            BigCircle.Show(g, pen);
            SmallCircle.Show(g, pen);
            //g.DrawEllipse(pen, GetX() - Getr(), GetY() - Getr(), 2 * Getr(), 2 * Getr());
            //g.DrawEllipse(pen, GetX() - GetR(), GetY() - GetR(), 2 * GetR(), 2 * GetR());
        }
        public void MoveTo(Graphics g, Pen pen, int ax, int ay)
        {
            //Pen pen1 = new Pen(Color.White, 3f);
            //Show(g, pen1);

            //SetXY(GetX() + ax, GetY() + ay);
            //SetXY(GetX() + ax, GetY() + ay);
            //Show(g, pen);

            BigCircle.MoveTo(g, pen, ax, ay);
            SmallCircle.MoveTo(g, pen, ax, ay);
        }
    }
}
