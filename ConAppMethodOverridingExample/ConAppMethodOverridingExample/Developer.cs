using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMethodOverridingExample
{
    public class Developer : Employee
    {
        string domain;
        string projects;
        public override void Register()
        {
            base.Register();
            Console.WriteLine("Enter domain");
            domain = Console.ReadLine();
            Console.WriteLine("Enter project");
            projects = Console.ReadLine();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Domain: \t" + domain);
            Console.WriteLine("Project: \t" + projects);
        }
    }
}
