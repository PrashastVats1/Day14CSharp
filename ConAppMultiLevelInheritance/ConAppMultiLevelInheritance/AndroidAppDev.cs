using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMultiLevelInheritance
{
    public class AndroidAppDev : AppDev
    {
        public override void Register()
        {
            base.Register();
            Console.WriteLine("This is android app developer class");
        }
        //this display method is pointing to display of appdev which has been sealed which is why it  cannot proceed further
        public override void Display()
        {
            Console.WriteLine("Display android class");
        }
    }
}
