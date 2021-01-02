using System;

namespace OopsConcepts
{
    class Calculator
{
       public int a, b, c, d;
    public int multiplication(int a,int b)
    {
      return a*b;   
    }
    public int division(int c,int d)
    {
      return c/d;
    }
    public int addition(int a,int b,int c)
    {
        return a+b+c;
    }
    public int subtraction(int a, int b, int c, int d)
    {
        return a-b-c-d;
    }
}
class mainClass : Calculator
{
    void run()
    {
        Console.WriteLine("The Square values is "+this.multiplication(a,b));
        Console.WriteLine("The Cube value is "+this.division(c,d));
        Console.WriteLine("The Square values is "+this.addition(a,b,c));
        Console.WriteLine("The Square values is "+this.subtraction(a,b,c,d));
    }
        void anotherRun()
        {
            Console.WriteLine("The next Square values is " + this.multiplication(a, b));
            Console.WriteLine("The next Cube value is " + this.division(c, d));
            Console.WriteLine("The next Square values is " + this.addition(a, b, c));
            Console.WriteLine("The next Square values is " + this.subtraction(a, b, c, d));
            Console.WriteLine("The added value of multiplied result and addition result is "
                + this.multiplication(a, b) + this.addition(a, b, c));
        }
       /* static void Main()
    {
        mainClass m2=new mainClass();            
           *//* m2.a = 100;
            m2.b = 50;
            m2.c = 25;
            m2.d = 12;
            m2.run();
            m2.anotherRun();
        }*/
}
}
