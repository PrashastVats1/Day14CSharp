using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMethodOverridingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee class called");
            Employee employee = new Employee();
            employee.Register();
            employee.Display();
            Console.WriteLine("Developer class called");
            Developer developer = new Developer();
            developer.Register();
            developer.Display();
            Console.ReadKey();
        }
    }
}
