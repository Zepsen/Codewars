using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars
{
    class DoubleCola : ICodeWars
    {
        object ICodeWars.Start()
        {
            return Func3(1);
        }


        private static string Func(int n)
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };

            var nn = n % names.Length; 
            var res = n % names.Length == 0 ? names.Length : n % names.Length - 1;
            
            Stack<string> names2 = new Stack<string>();
            names2.Push("Sheldon");
            names2.Push("Leonard");
            names2.Push("Penny");
            names2.Push("Rajesh");
            names2.Push("Howard");
            

            return names[res];
        }

        private static string Func2(long n)
        {            
            string[] name = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            
            Queue<string> names = new Queue<string>();
            name.ToList().ForEach(i => names.Enqueue(i));
                        
            for(int i = 0; i < n; i++)
            {
                 var pop = names.Dequeue();
                 names.Enqueue(pop);
                 names.Enqueue(pop);
            }
            
            return names.Dequeue();
        }

        private static string Func3(long n)
        {     
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            var len = names.Length;
            var sum = 0;
            var i = 0;
            
            while(true)     
            {
                var nextSum = len + sum * 2;
                if(nextSum < n)
                {
                    sum = nextSum;
                    i++;
                }
                else break;
            }

            var countOfRepeatedNames = Math.Pow(2,i);
            var pos = (int)((n - sum) / countOfRepeatedNames);
            return names[pos];
        }
       
    }
}