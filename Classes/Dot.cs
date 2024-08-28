using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class Dot:Figure
    {
        public Dot(int ax, int ay) :base(ax, ay) 
        {
            Check();
        }
        public Dot(Random random) :base(random)
        {
            Console.WriteLine("Объект Dot создан");
        }
        public override void Show(Graphics g, Pen pen)
        {
            g.DrawEllipse(pen, GetX() - 1, GetY() - 1, 2, 2);
        }

    }
}
