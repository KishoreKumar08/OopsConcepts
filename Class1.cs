using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcepts
{
    class Class1 : Calculator
    { 
        void run1()
        {
            Console.WriteLine("The multiplied value is " + multiplication(a, b));
            Console.WriteLine("The divided value is " + this.division(c, d));
            Console.WriteLine("The added value is " + this.addition(a, b, c));
            Console.WriteLine("The subtracted value is " + this.subtraction(a, b, c, d));
            Console.WriteLine("The cube value is " + this.squareOfvalue(a));
            Console.WriteLine("The square value is " + this.cubeOfvalue(b));
        }
        void anotherRun()
        {
            Console.WriteLine("The multiplied value 2nd Iteration is " + this.multiplication(a, b));
            Console.WriteLine("The divided value 2nd Iteration is " + this.division(c, d));
            Console.WriteLine("The added value 2nd Iteration is " + addition(a, b, c));
            Console.WriteLine("The subtracted value 2nd Iteration is " + this.subtraction(a, b, c, d));
            Console.WriteLine("The added value of multiplied result and addition result is "
                + this.multiplication(a, b) + this.addition(a, b, c));
            Console.WriteLine("The cube value of 2nd Iteration is " + this.squareOfvalue(a));
            Console.WriteLine("The square value 2nd Iteration is " + this.cubeOfvalue(b));
        }
        public static void methodToRun()
        {
            Class1 m2 = new Class1();
            m2.a = 1000;
            m2.b = 5000;
            m2.c = 25;
            m2.d = 12;
            m2.run1();
            m2.anotherRun();            
        }
    }
    class createdForList : conceptsOfCollections
    {
        static void Main() 
        {
            createdForList c = new createdForList();
            CSharpTrickyReusablePrograms i = new CSharpTrickyReusablePrograms();
            //c.hash();
            //c.sortedList();
            //c.stack();
            //genericList();
            //genericHashTable();
            //genericSortedList();
            //genericStack();
            //exceptionHandling();
            //Class1.methodToRun();
            //CSharpTrickyReusablePrograms.duplicateElementsInArrayOrList();
            //setExample();
            //SetWithVarDataType();
            //SetWithArray();
            //i.ReverseString("Kishore");
            Console.WriteLine($"The reversed string is {i.ReverseAString("Kishore")}");
            Console.WriteLine($"The string without space is {i.UniteAStringByRemovingSpace("Hey there.. how are you!")}");
            Console.WriteLine($"Current Date and Time is {i.GetDateTime()}");
            Console.WriteLine($"Current Date is {i.GetDate()}");
            Console.WriteLine($"Current Time is {i.GetTime()}");
            Console.WriteLine($"Current Date with Proposed DD and MM is {i.AddCurrentYearwithDD_MM("08","04")}");
            Console.WriteLine($"Current Date with Proposed yyyy is {i.AddCurrentDateandTimewithYYYY("1995")}");
            Console.WriteLine($"Current Date with Proposed dd mm yyyy is {i.DateFormatForGivenDDMMYYYY("08","04","1995")}");
            Console.WriteLine($"Splitted String with Space is {i.SplitAStringBySpace(3,"HeyYouYesYouNotHimDefinitelyNot")}");
            Console.WriteLine($"Splitted String with Space is {i.SplitAStringBySpace(3, "CSKRCBKKR")}");

        }
    }
}
