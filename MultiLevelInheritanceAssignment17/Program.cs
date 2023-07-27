using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritanceAssignment17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We will take the unit of measurement as centimeters(cm)");
            List<Shape> shapes = new List<Shape>();
            while (true)
            {
                Console.WriteLine("Enter shape type (Circle, Rectangle, Triangle) or 'N' to stop");
                string input = Console.ReadLine().ToLower();
                if (input == "n")
                {
                    break;
                }
                switch (input)
                {
                    case "circle":
                        Console.WriteLine("Enter radius: ");
                        if(double.TryParse(Console.ReadLine(), out double radius) )
                        {
                            shapes.Add(new Circle(radius));
                        }
                        else { Console.WriteLine("Invalid input. Please enter a valid radius"); }
                        break;
                    case "rectangle":
                        Console.WriteLine("Enter width: ");
                        if (double.TryParse(Console.ReadLine(), out double width))
                        {
                            Console.WriteLine("Enter height: ");
                            if (double.TryParse(Console.ReadLine(), out double height))
                            {
                                shapes.Add(new Rectangle(width, height));
                            }
                            else { Console.WriteLine("Invalid input. Please enter a valid height"); }
                        }
                        else { Console.WriteLine("Invalid input. Please enter a valid radius"); }
                        break;
                    case "triangle":
                        Console.WriteLine("Enter side A: ");
                        if (double.TryParse(Console.ReadLine(), out double sideA))
                        {
                            Console.WriteLine("Enter side B: ");
                            if (double.TryParse(Console.ReadLine(), out double sideB))
                            {
                                Console.WriteLine("Enter side C: ");
                                if (double.TryParse(Console.ReadLine(), out double sideC))
                                {
                                    shapes.Add(new Triangle(sideA, sideB, sideC));
                                }
                                else { Console.WriteLine("Invalid input. Please enter a valid height"); }
                            }
                            else { Console.WriteLine("Invalid input. Please enter a valid height"); }
                        }
                        else { Console.WriteLine("Invalid input. Please enter a valid radius"); }
                        break;
                    default:
                        Console.WriteLine("Invalid shape type. Please enter valid shape type.");
                        break;
                }
            }
            Console.WriteLine("Shape Information: ");
            foreach(Shape shape in shapes)
            {
                shape.PrintResult();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
