using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.T4Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawStuff();
        }

        static void DrawStuff()
        {
            {
                int i = 1;

                Circle circle = new Circle();
                circle.Name = "Circle";
                circle.Radius = 1;
                circle.Draw();
                circle.PrintRadArea();
                circle.PrintCircumference();
                Console.WriteLine();


                Circle circle1 = new Circle();
                circle1.Name = "Bigger circle";
                circle1.Radius = 3;
                circle1.Draw();
                circle1.PrintRadArea();
                circle1.PrintCircumference();
                Console.WriteLine();


                Rectangle rectangle = new Rectangle();
                rectangle.Name = "Rectangle";
                rectangle.Width = 25;
                rectangle.Height = 120;
                rectangle.Draw();
                rectangle.PrintRadArea();
                rectangle.PrintCircumference();
                Console.WriteLine();


                Rectangle rectangle1 = new Rectangle();
                rectangle1.Name = "Smaller rectangle";
                rectangle1.Width = 5;
                rectangle1.Height = 2.5;
                rectangle1.Draw();
                rectangle1.PrintRadArea();
                rectangle1.PrintCircumference();
                Console.WriteLine();

                List<Shape> shapes = new List<Shape>();
                // use polymorphis to store objects
                shapes.Add(circle);
                shapes.Add(circle1);
                shapes.Add(rectangle);
                shapes.Add(rectangle1);

                for (int j = 0; j < Console.WindowWidth; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();

                Console.WriteLine("Loop through all drawing objects in a list:");
                foreach (Shape item in shapes)
                {
                    Console.WriteLine("\nShape #{0}", i);
                    item.Draw();
                    item.PrintRadArea();
                    item.PrintCircumference();
                    i++;
                }
                Console.WriteLine();
            }
        }
    }
}
