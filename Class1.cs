using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcepts
{
    class Class1 : Calculator
    {
        void run1()
        {
            Console.WriteLine("The Square values is " + this.multiplication(a, b));
            Console.WriteLine("The Cube value is " + this.division(c, d));
            Console.WriteLine("The Square values is " + this.addition(a, b, c));
            Console.WriteLine("The Square values is " + this.subtraction(a, b, c, d));
        }
        static void Main()
        {
            Class1 m2 = new Class1();
            m2.a = 1000;
            m2.b = 5000;
            m2.c = 25;
            m2.d = 12;
            m2.run1();
        }
    }
}
