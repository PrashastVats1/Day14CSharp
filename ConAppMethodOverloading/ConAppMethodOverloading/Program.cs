using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OurClass obj = new OurClass();
            obj.Display("Sam");
            obj.Display();
            Console.WriteLine(obj.Add("Raj","Kumar"));
            int num = 34;
            obj.Increment(num);
            obj.Increment(ref num);
            Console.WriteLine("After taking the reference number");
            obj.Increment(num);
            //obj.Increment(out num);
            Console.ReadKey();
        }
    }
}
