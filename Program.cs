using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> listA = new List<object>();
            listA.Add(7);
            listA.Add(28);
            listA.Add(-1);
            listA.Add(true);
            listA.Add("chair");
            int sum = 0;

            for (int i = 0; i< listA.Count; i++)
            {
                Console.WriteLine(listA[i]);
                if (listA[i] is int){
                    int intType = (int)listA[i];
                    sum += intType;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
