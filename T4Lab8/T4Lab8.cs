using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    abstract class Shape
    {
        public string Name { get; set; }
        public double area = 0;
        public double Area
        {
            get { return area; }
            set { area = value; }
        }
        public double Circum { get; set; }

        public Shape()
        {
        }

        public Shape(string name)
        {
            Name = name;
        }

        public abstract void PrintRadArea();

        public abstract void PrintCircumference();

        public abstract void Draw();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }
        
        
        private const double pi = 3.14;
        

        public override void Draw()
        {
            Console.WriteLine("Circle");
        }

        public override void PrintRadArea()
        {
            area = Radius * Radius * pi;
            Console.WriteLine("Radius: {0}", Radius + " Area: " + Area);
        }

        public override void PrintCircumference()
        {
            Circum = 2 * pi * Radius;
            Console.WriteLine("Circumference: {0}", Circum);
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
        public override void PrintRadArea()
        {
            area = Width * Height;
            Console.WriteLine("Width: " + Width + " Height: " + Height + " Area: " + Area);
        }

        public override void PrintCircumference()
        {
            Circum = (Width + Height) * 2;
            Console.WriteLine("Circumference: {0}", Circum);
        }
    }

   /* class Shapes
    {
        List<Shape> shapes { get; }

        public Shapes()
        {
            shapes = new List<Shape>();
        }

        public void AddShapes(Shape shape)
        {
            shapes.Add(shape);
            Console.WriteLine("A new {0} added to list", shape.Name);
        }
    }*/
}
