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
            try
            {
                DrawStuff();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        static void DrawStuff()
        {
            {
                int i = 1;

                Circle circle = new Circle();
                circle.Name = "Circle";
                circle.Radius = 1;
                
                Circle circle1 = new Circle();
                circle1.Name = "Bigger circle";
                circle1.Radius = 3;
                
                Rectangle rectangle = new Rectangle();
                rectangle.Name = "Rectangle";
                rectangle.Width = 25;
                rectangle.Height = 120;
                
                Rectangle rectangle1 = new Rectangle();
                rectangle1.Name = "Smaller rectangle";
                rectangle1.Width = 5;
                rectangle1.Height = 2.5;

                Shapes shapes = new Shapes();
                try
                {
                    shapes.AddShape(circle);
                    shapes.AddShape(circle1);
                    shapes.AddShape(rectangle);
                    shapes.AddShape(rectangle1);

                    for (int j = 0; j < Console.WindowWidth; j++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();

                    Console.WriteLine("Print out list:");
                    foreach (Shape item in shapes.ShapesList)
                    {
                        Console.WriteLine("\nShape #{0}", i);
                        Console.WriteLine(item.Draw());
                        Console.WriteLine(item.PrintRadArea());
                        Console.WriteLine(item.PrintCircumference());
                        i++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                Console.WriteLine();
            }
        }
    }
}
