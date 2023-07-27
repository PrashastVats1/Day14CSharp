using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMultiLevelInheritance
{
    public class Developer : Employee
    {
        string project;
        string domain;
        public Developer()
        {
            Console.WriteLine("Developer Constructor");
            project = "not given";
            domain = "not assigned";
        }
        public override void Register()
        {
            base.Register();
            Console.WriteLine("Enter Domain");
            domain = Console.ReadLine();
            Console.WriteLine("Enter Project");
            project = Console.ReadLine();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Domain: \t" + domain);
            Console.WriteLine("Project: \t" + project);
        }
    }
}
