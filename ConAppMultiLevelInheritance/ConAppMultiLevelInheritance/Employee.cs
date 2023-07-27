using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMultiLevelInheritance
{
    public class Employee
    {
        int id;
        string name;
        public Employee()
        {
            Console.WriteLine("Employee class constructor");
            id = -1;
            name = "not given";
        }
        public virtual void Register()
        {
            Console.WriteLine("Enter ID");
            id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
        }
        public virtual void Display()
        {
            Console.WriteLine("ID: \t" + id);
            Console.WriteLine("Name: \t" + name);
        }
    }
}
