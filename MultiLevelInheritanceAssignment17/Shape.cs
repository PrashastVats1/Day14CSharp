using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritanceAssignment17
{
    public class Shape
    {
        public string ShapeType { get; set; }
        public virtual double Area { get; }
        public virtual double Perimeter { get; }
        public Shape(string shapeType)
        {
            ShapeType = shapeType;
        }
        public virtual void PrintResult()
        {
            Console.WriteLine($"Shape Type: \t{ShapeType}");
            Console.WriteLine($"Area: \t{Area} cm²");
            Console.WriteLine($"Perimeter: \t{Perimeter} cm");
        }
    }
}
