using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class Rectangle:Tetragon
    {
        private int width;
        private int height;

        public Rectangle(Random random, int ax, int ay, int awidth, int aheight):base(random, ax, ay)
        {
            width = awidth;
            height = aheight;

            if (awidth > 733 - GetX())
            {
                width = 733 - GetX();
            }
            if (aheight > 558 - GetY())
            {
                height = 558 - GetY();
            }

            SetXY2(GetX()+width, GetY());
            SetXY3(GetX2(), GetY2()+height);
            SetXY4(GetX(), GetY() + height);
            //Console.WriteLine("Объект прямоугольник создан: (" + GetX() + ", " + GetY() + ") (" + width + ", " +  height + ")");
            Console.WriteLine("Объект Rectangle создан");
        }
        public Rectangle(Random random) : base(random)
        {
            width = random.Next(1, 500);
            height = random.Next(1, 500);

            if (width > 733 - GetX())
            {
                width = 733 - GetX();
            }
            if (height > 558 - GetY())
            {
                height = 558 - GetY();
            }

            SetXY2(GetX() + width, GetY());
            SetXY3(GetX2(), GetY2() + height);
            SetXY4(GetX(), GetY() + height);

            Console.WriteLine("Объект Rectangle создан");
            //Console.WriteLine("Объект прямоугольник создан: (" + GetX() + ", " + GetY() + ") (" + width + ", " + height + ")");
        }

        public int GetWidth() { return width; }

        public int GetHeight() { return height; }

        public void SetWH(int awidth, int aheight)
        {
            width = awidth;
            height = aheight;
            SetXY2(GetX() + width, GetY());
            SetXY3(GetX2(), GetY2() + height);
            SetXY4(GetX(), GetY() + height);
        }
        
    }
}
