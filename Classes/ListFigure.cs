using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LAB
{
    internal class ListFigure
    {
        private List<Figure> list;

        public ListFigure() 
        { 
            list = new List<Figure>();
            Console.WriteLine("Создан пустой список фигур");
        }

        public void Add() 
        {
            Random random = new Random();

            switch (random.Next(1, 7))
            {
                case 1:
                    Circle circle = new Circle(random);
                    list.Add(circle);
                    break;
                case 2:
                    Ellipse ellipse = new Ellipse(random);
                    list.Add(ellipse);
                    break;
                case 3:
                    Rectangle rect = new Rectangle(random);
                    list.Add(rect);
                    break;
                case 4:
                    Rhombus rhomb = new Rhombus(random);
                    list.Add(rhomb);
                    break;
                case 5:
                    Tetragon tetr = new Tetragon(random);
                    list.Add(tetr);
                    break;
                case 6:
                    Line line = new Line(random);
                    list.Add(line);
                    break;
            }
        }

        public void Iterator(Graphics g, Pen pen, string action, int x = 0, int y = 0)
        {
            switch (action)
            {
                case "Show":
                    foreach (Figure figure in list)
                    {
                        figure.Show(g, pen);
                    }
                    break;
                case "MoveTo":
                    foreach (Figure figure in list)
                    {
                        figure.MoveTo(g, pen, x, y);
                    }
                    break;
                case "UnVisible":
                    foreach (Figure figure in list)
                    {
                        Pen pen1 = new Pen(Color.White, 3f);
                        figure.Show(g, pen1);
                    }
                    break;
                case "Destroy":
                    if(list.Count != 0)
                    {
                        g.Clear(Color.White);
                        list.Clear();
                    }
                   
                    break;
            }
        }
    }
}
