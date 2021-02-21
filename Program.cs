using System;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Linq;
 
namespace OopsConcepts
{
    class Calculator
    {
        public int a, b, c, d;       
        public int multiplication(int a, int b)
        {
            return a * b;
        }
        public int division(int c, int d)
        {
            return c / d;
        }
        public int addition(int a, int b, int c)
        {
            return a + b + c;
        }
        public int subtraction(int a, int b, int c, int d)
        {
            return a - b - c - d;
        }
        public int squareOfvalue(int b)
        {
            return a * a;
        }
        public int cubeOfvalue(int a)
        {
            return a * a * a;
        }
   
    }
    class conceptsOfCollections
    {
        public void list()
        {
            ArrayList al = new ArrayList();
            al.Add("Srijala");
            al.Add(123);
            al.Add(54321.09);
            al.Add('P');
            //al.Reverse();
            //al.Remove(123);
            //al.RemoveAt(0);
            foreach (var x in al)
            {
                Console.WriteLine(x);
            }
        }
        public static void genericList()
        {
            List<string> l = new List<string>();
            l.Add("c3");
            l.Add("c3");
            l.Add("c3");
            l.Add("c3");
            l.Add("c3");
            l.Add("c3");
            l.Add("c3");
            Console.WriteLine(l.Count);
            foreach (string i in l)
            {
                Console.WriteLine(i);
            }
        }
        public void sortedList()
        {
            SortedList sl = new SortedList();
            sl.Add("hey", "C#");
            sl.Add("", "automation");
            sl.Add("hi", "");
            sl.Add("how", "cucumber");
            sl.Add("are you ", "selenium");
            //sl.Remove("hi");
            //sl.RemoveAt(2);
            Console.WriteLine("The no of total elements in my Sorted List is " + sl.Count); ;
            Console.WriteLine(sl);
            foreach (DictionaryEntry i in sl)
            {
                Console.WriteLine("The Current Key in Sorted Lsit is " + i.Key + " The Current value in Sorted List is " + i.Value);
            }
        }
        public static void genericSortedList()
        {
            SortedList<char, string> gsl = new SortedList<char, string>();
            gsl.Add('y', "C#");
            gsl.Add('k', "automation");
            gsl.Add('c', "");
            gsl.Add('z', "");
            gsl.Add('b', "selenium");
            Console.WriteLine("The no of total elements in my Sorted List is " + gsl.Count);
            Console.WriteLine(gsl);
            foreach (KeyValuePair<char, string> i in gsl)
            {
                Console.WriteLine("The Current Key in Sorted Lsit is " + i.Key + " The Current value in Sorted List is " + i.Value);
            }
        }
        public void hash()
        {
            Hashtable ht = new Hashtable();
            ht.Add('a', 1);
            ht.Add('c', "automation");
            ht.Add('b', 12344.56);
            ht.Add('e', "cucumber");
            ht.Add(12.34, "selenium");
            // ht.Remove('c');
            Console.WriteLine("The no of total elements in my HashTable is " + ht.Count);
            Console.WriteLine(ht);
            foreach (DictionaryEntry i in ht)
            {
                Console.WriteLine("The Current Key in HashTable is " + i.Key + " The Current value in HashTable is " + i.Value);
                /* Console.WriteLine(i.Value.GetType().Name);
                 Console.WriteLine(i.Key.GetType());*/
            }
        }
        public static void genericHashTable()
        {
            Dictionary<int, string> ght = new Dictionary<int, string>();
            ght.Add(1, "Hey");
            ght.Add(2, "Hello");
            ght.Add(3, "We are learining");
            ght.Add(4, "C#");
            Console.WriteLine("The no of total elements in my HashTable is " + ght.Count);
            Console.WriteLine(ght);
            foreach (KeyValuePair<int, string> i in ght)
            {
                Console.WriteLine("The Current Key in HashTable is " + i.Key + " The Current value in HashTable is " + i.Value);
                /* Console.WriteLine(i.Value.GetType().Name);
                 Console.WriteLine(i.Key.GetType());*/
            }
        }
        public void stack()
        {
            Stack s = new Stack();
            s.Push("I am");
            s.Push(123);
            s.Push(4.23);
            s.Push('c');
            s.Pop();
            s.Push(12345678901234);

            foreach (var i in s)
            {
                Console.WriteLine(i);
            }
        }
        public static void genericStack()
        {
            Stack<string> s = new Stack<string>();
            s.Push("I am");
            s.Push("Learning");
            s.Push("C#");
            s.Push("Collections");
            s.Pop();
            s.Push("Generic Collections");
            foreach (string i in s)
            {
                Console.WriteLine(i);
            }
        }
        public static void setExample()
        {
            HashSet<string> s = new HashSet<string>();
            s.Add("Hello");
            s.Add("Hi");
            s.Add("There");
            s.Add("Whatsup");
            s.Add("Hello");
            s.Add("Hi");
            foreach(string x in s)
            {
                Console.WriteLine(x);
            }
        }
        public static void SetWithVarDataType()
        {
            var s = new HashSet<string>();
            s.Add("Hello");
            s.Add("Hi");
            s.Add("There");
            s.Add("Whatsup");
            s.Add("Hello");
            s.Add("Hi");
            foreach (string x in s)
            {
                Console.WriteLine(x);
            }
        }
        public static void SetWithArray()
        {
            string[] arr1 = { "Table", "Chair", "Pen", "Clip", "Table" };
            string[] arr2 = { "Hello", "Hi", "There", "Whatsup", "Hello", "Hi", "There" };
            HashSet<string> s= new HashSet<string>(arr1);
            var a = new HashSet<string>(arr2);
            foreach (string x in s)
            {
                Console.WriteLine(x);

            }
            foreach (string x in a)
            {
                Console.WriteLine(x);
            }
        }

        static void seperateCharsInAString()
        {
            int i = 0, l, total = 0;
            String a = "IsaacSamPaul08!@#$%&*";
            l = a.Length - 1;
            while (i < l)
            {
                if (a[l] >= 'a' && a[l] <= 'z' || a[l] >= 'A' && a[l] <= 'Z')
                {
                    total = total + 1;
                }
                l--;
            }
            Console.WriteLine("The total length of chars are " + total);
        }
        public static void exceptionHandling()
        {
            try
            {
                int a = 10;
                int b = 10;
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("I am finally executed");
            }

        }
    }
    // Abstraction
        abstract class Amazon
        {
            public static void addToCart()
            {
                Console.WriteLine("Added items");
            }
            public static void checkOut()
            {
                Console.WriteLine("Items are checked out");
            }
            public static void selectItems()
            {
                Console.WriteLine("Items selected");
            }
            public abstract void login();
        }
        class Inherit : Amazon
        {
            public override void login()
            {
                Console.WriteLine("Logged in successfully");
            }
            /*static void Main()
            {
                Inherit i = new Inherit();
                addToCart();
                checkOut();
                selectItems();
                i.login();
            }*/
        }
    // Interface
        public interface test
        {
            void login();
            void logout();
            void forgotPwd();
        }
        public interface test1
        {
            void login1();
            void logout1();
            void forgotPwd1();
        }

        public class testing : test, test1
        {
            public void login()
            {
                Console.WriteLine("Logged in");
            }
            public void logout()
            {
                Console.WriteLine("Logged out");

            }
            public void forgotPwd1()
            {
                Console.WriteLine("forgotPwd");
            }
            public void login1()
            {
                Console.WriteLine("Logged in");
            }
            public void logout1()
            {
                Console.WriteLine("Logged out");
            }
            public void forgotPwd()
            {
                Console.WriteLine("forgotPwd");
            }
        }
    public sealed class CalculatorStepDefinitions
    {
        public static void chrome()
        {
            ChromeDriver driver = new ChromeDriver(@"E:\Selenium\Chrome Driver 87");
            driver.Navigate().GoToUrl("https://www.google.com/");
            String title=driver.Title.ToString();
            Console.WriteLine($"The title is {title}");
            driver.FindElement(By.XPath("//input[@class='gLFyf gsfi']")).SendKeys("whats new today");
            driver.FindElement(By.ClassName("gNO89b")).Click();
           // driver.Close();
        }
        public static void iceHrm()
        {
            ChromeDriver driver = new ChromeDriver(@"E:\Selenium\Chrome Driver 87");
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
            driver.Manage().Window.Maximize();
            String title=driver.Title.ToString();
            Console.WriteLine($"The current url's title is {title}");
            driver.FindElement(By.Id("txtUsername")).SendKeys("Admin");
            driver.FindElement(By.Name("txtPassword")).SendKeys("admin123");
            driver.FindElement(By.ClassName("button")).Click();
            String landing = driver.Title.ToString();
            Console.WriteLine($"The current url's title is {landing}");  
            driver.Close();
        }          
    }
    class eeolution
    {
        public int solution(int[] A)
        {
            int result=0;
            foreach(int i in A)
            {
                if(i>=1 && i==A[i])
                {
                    Console.WriteLine("The answer is below " + i);
                    result = i;                      
                }
            }
            return result;
        }
 
        /*static void Main()
        {
            Solution S = new Solution();
            int[] arr = Enumerable.Range(1,100000).ToArray();
            S.solution(arr);
            Calculator cn = new Calculator();
            cn.addition(1,2,3);
        }*/
    }
}

