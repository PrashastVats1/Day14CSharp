using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMethodOverloading
{
    //Method overloading is a concept of single class. We have same name method/function but have different parameters
    //Methods become different based on different parameters even though the names are same
    public class OurClass
    {
        //Nuber of parameters
        public void Display()
        {
            Console.WriteLine("Display of Our Class");
        }
        public void Display(string name)
        {
            Console.WriteLine("Welcome to Display " + name);
        }
        public void Display(string fname, string lname)
        {
            Console.WriteLine("Welcome to Display Mr/Ms. " + fname + " " + lname);
        }
        //Type of Parameters
        public double Add(double num1, double num2)
        {
            Console.WriteLine("Double method call");
            return num1 + num2;
        }
        public int Add(int num1, int num2)
        {
            Console.WriteLine("Int method call");
            return num1 + num2;
        }
        public string Add(string fname, string lname)
        {
            Console.WriteLine("String method call");
            return fname + " " + lname;
        }
        public void Increment (int num1)
        {
            num1 += 2;
            Console.WriteLine("Number after increment: \t" + num1);
        }
        public void Increment(ref int num1)
        {
            num1 += 5;
            Console.WriteLine("Number after increment: \t" + num1);
        }
        //at one time we can only have one reference overloading for a method
        //public void Increment(out int num1)
        //{
        //    num1 = 120;
        //    Console.WriteLine("Number after increment: \t" + num1);
        //}
    }
}
