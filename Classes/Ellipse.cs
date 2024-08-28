using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class Ellipse:Circle
    {
        private int r2;

        public Ellipse(int ax, int ay, int ar, int ar2) : base(ax, ay, ar)
        {
            r2 = ar2;

            if (r2 > 732 - GetX())
            {
                r2 = 734 - GetX();
            }
            else if (r2 > GetX())
            {
                r2 = GetX();
            }

            if (r2 > 557 - GetY())
            {
                r2 = 559 - GetY();
            }
            else if (r2 > GetY())
            {
                r2 = GetY();
            }

        }

        public Ellipse(Random random) : base(random) 
        {
            r2 = random.Next(1, 250);

            if (r2 > 732 - GetX())
            {
                r2 = 734 - GetX();
            }
            else if (r2 > GetX())
            {
                r2 = GetX();
            }

            if (r2 > 557 - GetY())
            {
                r2 = 559 - GetY();
            }
            else if (r2 > GetY())
            {
                r2 = GetY();
            }
        }

        public void SetR2(int ar2)
        {
            if (ar2 < 1) { r2 = 1; }
            else { r2 = ar2; }
        }

        public int GetR2()
        {
            return r2;
        }
        public override void Show(Graphics g, Pen pen)
        {
            g.DrawEllipse(pen, GetX() - GetR(), GetY() - r2, 2 * GetR(), 2 * r2);
        }

        public void Rotate(Graphics g, Pen pen)
        {
            Pen pen1 = new Pen(Color.White, 3f);
            Show(g, pen1);

            int ar;

            ar = r2;
            SetR2(GetR());
            SetR(ar);

            Show(g, pen);
        }

        
    }
}
