using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMethodOverridingExample
{
    public class Employee
    {
        int id;
        string name;
        double sal;
        public virtual void Register()
        {
            Console.WriteLine("Enter Id");
            id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter salary");
            sal = double.Parse(Console.ReadLine());
        }
        public virtual void Display()
        {
            Console.WriteLine("Id: \t" + id);
            Console.WriteLine("Name: \t" + name);
            Console.WriteLine("Salary: \t" + sal);
        }
    }
}
