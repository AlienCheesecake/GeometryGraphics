using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace LAB
{
    internal class ArrayFigure
    {
        private Figure[] arr;


        public ArrayFigure() 
        {
            arr = new Figure[0];
            Console.WriteLine("Создан пустой массив фигур");
        }

        public void Add()
        {
            Random random = new Random();
            
            Array.Resize(ref arr, arr.Length+1);
            int a = arr.Length - 1;

            switch (random.Next(1, 7))
            {
                case 1:
                    Circle circle = new Circle(random);
                    arr[a] = circle;
                    break;
                case 2:
                    Ellipse ellipse = new Ellipse(random);
                    arr[a] = ellipse;
                    break;
                case 3:
                    Rectangle rect = new Rectangle(random);
                    arr[a] = rect;
                    break;
                case 4:
                    Rhombus rhomb = new Rhombus(random);
                    arr[a] = rhomb;
                    break;
                case 5:
                    Tetragon tetr = new Tetragon(random);
                    arr[a] = tetr;
                    break;
                case 6:
                    Line line = new Line(random);
                    arr[a] = line;
                    break;
            }

        }

        public void Iterator(Graphics g, Pen pen, string action, int x = 0, int y = 0)
        {
            switch (action)
            {
                case "Show":
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i].Show(g, pen);
                    }
                    break;
                case "MoveTo":
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i].MoveTo(g, pen, x, y);
                    }
                    break;
                case "UnVisible":
                    Pen pen1 = new Pen(Color.White, 3f);
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i].Show(g, pen1);
                    }
                    break;
                case "Destroy":
                    g.Clear(Color.White);
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = null;
                    }
                    break;
            }
        }


    }
}
