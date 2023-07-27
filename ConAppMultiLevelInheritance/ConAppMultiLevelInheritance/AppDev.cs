using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMultiLevelInheritance
{
    //public class AppDev : Developer, Employee //Error multiple base classes are not allowed
    //{
    //}
    //public sealed class AppDev : Developer
    //if we use keyword sealed with class, that means we cannot further drive from that class
    public class AppDev : Developer
    {
        string osType;
        public AppDev()
        {
            Console.WriteLine("App Developer Constructor");
            osType = "Unknown";
        }
        public override void Register()
        {
            base.Register();
            Console.WriteLine("Enter OS Type");
            osType = Console.ReadLine();
        }
        public sealed override void Display()
        {
            //you cannot override this method further
            base.Display();
            Console.WriteLine("OS Type: \t" + osType);
        }
    }
}
