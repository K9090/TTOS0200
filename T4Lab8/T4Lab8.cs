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
        public double Area { get; set; }
        public double Circum { get; set; }
        
        public abstract string PrintRadArea();

        public abstract string PrintCircumference();

        public abstract string Draw();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }
        private const double pi = 3.14;
     
        public override string Draw()
        {
            return Name;
        }

        public override string PrintRadArea()
        {
            try
            {
                Area = Radius * Radius * pi;
                return "Radius: " + Radius + " Area: " + Area;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }

        public override string PrintCircumference()
        {
            try
            {
                Circum = 2 * pi * Radius;
                return "Circumference: " + Circum;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override string Draw()
        {
            return Name;
        }
        public override string PrintRadArea()
        {
            try
            {
                Area = Width * Height;
                return "Width: " + Width + " Height: " + Height + " Area: " + Area;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public override string PrintCircumference()
        {
            try
            {
                Circum = (Width + Height) * 2;
                return "Circumference: " + Circum;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }

    class Shapes
    {
        private List<Shape> shapes { get; }

        public Shapes()
        {
            shapes = new List<Shape>();
        }

        public List<Shape> ShapesList
        {
            get
            {
                return shapes;
            }
        }

        public void AddShape(Shape shape)
        {
            try
            {
                shapes.Add(shape);
                Console.WriteLine("A new shape: " + shape.Name + " added to list");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
