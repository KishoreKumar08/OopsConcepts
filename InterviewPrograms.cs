using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OopsConcepts
{
    public class InterviewPrograms
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

    }
}
