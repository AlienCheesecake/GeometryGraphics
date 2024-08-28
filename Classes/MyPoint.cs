using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class MyPoint
    {
        private int x;
        private int y;

        public MyPoint(int ax, int ay)
        {
            x = ax; 
            y = ay;
            Console.WriteLine("Объект MyPoint создан");
        }

        public MyPoint(Random random) 
        {
            int rand1 = random.Next(2, 732);
            int rand2 = random.Next(2, 557);
            x = rand1;
            y = rand2;
            Console.WriteLine("Объект MyPoint создан");
        }

        public int GetX() { return x; }

        public int GetY() { return y; }

        public void SetXY(int ax, int ay)
        {
            x = ax;
            y = ay;
        }

        public void SetX(int ax)
        {
            x = ax;
        }

        public void SetY(int ay)
        {
            y = ay;
        }



    }
}
