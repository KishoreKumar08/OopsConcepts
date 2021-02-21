using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OopsConcepts
{
    public class CSharpTrickyReusablePrograms
    {
        static void TotalCharsInAString()
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
        public string ReverseAString(string word)
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
        public string UniteAStringByRemovingSpace(string word)
        {
            string[] splittedWord= word.Split(" ");
            string splitWord = "";
            foreach(string s in splittedWord)
            {
                splitWord = splitWord + s;
            }
            return splitWord;
        }
        public string SplitAStringBySpace(int intervalOfCharsToSplit, string word)
        {
            //string[] splittedWord = word.Split();
            //char[] splitChars;
            string splitWord1="", splitWord2="", splitWord3 = "", splitWord4 = "", splitWord5 = "", splitWord6="", splitWord7 = "";
            int counter = 0;
            foreach(char c in word)
            {
                if(counter < intervalOfCharsToSplit)
                {
                    splitWord1 = splitWord1 + c;
                }
                else if (counter >= intervalOfCharsToSplit && counter < intervalOfCharsToSplit * 2)
                {
                    splitWord2 = splitWord2 + c;
                }
                else if (counter >= intervalOfCharsToSplit * 2 && counter < intervalOfCharsToSplit * 3)
                {
                    splitWord3 = splitWord3 + c;
                }
                else if (counter >= intervalOfCharsToSplit * 3 && counter < intervalOfCharsToSplit * 4)
                {
                    splitWord4 = splitWord4 + c;
                }
                else if (counter >= intervalOfCharsToSplit * 4 && counter < intervalOfCharsToSplit * 5)
                {
                    splitWord5 = splitWord5 + c;
                }
                else if (counter >= intervalOfCharsToSplit * 5 && counter < intervalOfCharsToSplit * 6)
                {
                    splitWord6 = splitWord6 + c;
                }
                else
                {
                    splitWord7 = splitWord7 + c;
                }
                counter++;
            }
            return $"{splitWord1} {splitWord2} {splitWord3} {splitWord4} {splitWord5} {splitWord6} {splitWord7}";
            //return $"{splitWord1} {splitWord2} {splitWord3} {splitWord4} {splitWord5} {splitWord6} {splitWord7}".Trim();
            //return (intervalOfCharsToSplit*5).ToString();
            //return counter.ToString();
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
        public string AddCurrentDateandTimewithYYYY(string year)
        {
            string[] currentDate = DateTime.Now.ToString().Split(" ");
            string[] ddmmyyyy = currentDate[0].Split('-');
            string date = ddmmyyyy[0]+ "-";
            string month = ddmmyyyy[1] + "-";
            string proposedYear = ddmmyyyy[2].Replace(ddmmyyyy[2],year);
            return date+month+proposedYear;
        }
        public string DateFormatForGivenDDMMYYYY(string dd, string mm, string yyyy)
        {
            return $"{dd}-{mm}-{yyyy}";
        }
    }
}
