
using System;
using System.Linq;

namespace Codewars
{
    class Persistent : ICodeWars
    {
        public object Start()
        {
            return Func2(39);
        }

        private static int Func(long num)
        {
            return (num < 10) ? 0 : CountOfPersistent(num);
        }

        private static int CountOfPersistent(long num, int count = 0)
        {            
            long sum = 1;
            while(num > 0)
            {
                sum *= num % 10;
                num /= 10;
            }

            count++;
            return (sum > 9) ? CountOfPersistent(sum, count) : count;
        }


        private static int Func2(long num)
        {     
            long res = num.ToString().Aggregate(1, (e, i) => e * (i - '0'));
            return num < 9 ? 0 : 1 + Func2(res);
        }

    }

}