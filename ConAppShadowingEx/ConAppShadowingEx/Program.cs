using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppShadowingEx
{
    internal class Program
    {
        static int myVar = 15;
        static void Main(string[] args)
        {
            int myVar = 10;
            Console.WriteLine("Inner myVar value is: \t" + myVar);
            Console.WriteLine("Outer myVar value is: \t" + Program.myVar);
            Display();
            Console.ReadKey();
        }
        public static void Display()
        {
            int myVar = 25;
            Console.WriteLine("Local myVar value is: \t" + myVar);
            Console.WriteLine("Global myVar value is: \t" + Program.myVar);
        }
    }
}
