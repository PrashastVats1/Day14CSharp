using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMultiLevelInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDev appDev = new AppDev();
            appDev.Register();
            appDev.Display();
            //Object for Developer class
            Developer developer = new Developer();
            developer.Register();
            developer.Display();
            //Object for Employee class
            Employee employee = new Employee();
            employee.Register();
            employee.Display();

            Console.ReadKey();
        }
    }
}
