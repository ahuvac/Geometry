using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryA
{
    class Program
    {
        private static string workingDirectory;

        static void Main(string[] args)
        {

            Console.Out.WriteLine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).
        Parent.Parent.FullName);
            Circle circle = new Circle(new Point(), 1.0);
            Square square = new Square(1.0);
            Rectangle rectangle = new Rectangle(2.0, 1.0);
            Rhombus rhombus = new Rhombus(5.0, 3.0, 2.0);

            IShape[] shapes = { circle, square, rectangle, rhombus };
            foreach (IShape shape in shapes)
            {
                ShowFigure(shape);
            }
            var waitForUser = Console.ReadKey();
        }

        private static void ShowFigure(IShape shape)
        {
            String Iam = shape.GetType().ToString();
            //Iam = Iam.Substring(1 + Iam.LastIndexOf('.'));
            String area = String.Format("{0:0.00}", shape.GetArea());
            String perimeter = String.Format("{0:0.00}", shape.GetPerimeter());
            Console.Out.WriteLine($"{Iam} area: {area} \n{Iam} perimeter: {perimeter}\n");
        }
    }
}

