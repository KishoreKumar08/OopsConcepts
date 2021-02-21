using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OopsConcepts
{
    public class CSharpTrickyReusablePrograms
    {
        public static void duplicateElementsInArrayOrList()
        {
            int[] a = { 1, 5, 7, 3, 7, 2, 5, 8, 9, 5 };
            List<int> x = new List<int>();
            a.ToList();            
            List<int> b = new List<int>();
            int Counter = 0;
            for (int i = 0; i < x.Count; i++)
            {
                b.Add(x[i]);
                for (int j = 0; j <= b.Count; j++)
                {
                    if (x[i] == b[j])
                    {
                        Counter = Counter + 1;
                        if (Counter == 2)
                        {
                            x.RemoveAt(i);
                        }
                    }
                }
                foreach (int c in x)
                {
                    Console.WriteLine(c);
                }
            }
        }
        public string ReverseString(string word)
        {
            string revWord ="";
            int l = word.Length - 1;
            while(l>=0)
            {
                revWord = revWord + word[l];
                // revWord = revWord + $"{word[l]}";
                l--;
            }
            return revWord;
        }
        public string SplitAStringBySpace(string word)
        {
            string[] splittedWord= word.Split(" ");
            string splitWord = "";
            foreach(string s in splittedWord)
            {
                splitWord = splitWord + s;
            }
            return splitWord;
        }
        public string GetDateTime()
        {
            return DateTime.Now.ToString();
        }
        public string GetDate()
        {
            string[] currentDate=DateTime.Now.ToString().Split(" ");            
            return currentDate[0];
        }
        public string GetTime()
        {
            string[] currentTime = DateTime.Now.ToString().Split(" ");
            return currentTime[1];
        }
        public string AddCurrentYearwithDD_MM(string dd, string mm)
        {
            string[] currentDate = DateTime.Now.ToString().Split(" ");
            string[] ddmm=currentDate[0].Split('-');
            string date=ddmm[0].Replace(ddmm[0], dd.ToString()+"-");
            string month=ddmm[1].Replace(ddmm[1], mm.ToString()+"-");
            return date+month+ DateTime.Now.Year;
        }
    }
}
