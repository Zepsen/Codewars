using System;

namespace Codewars
{
    public class FinPlanet : ICodeWars
    {
        public object Start()
        {
            return Func(5);
        }

        public ulong Func(ulong n)
        {
            ulong sum = 0;
            for (ulong i = 0, j = 0; i <= n; i++, j+=2)
            {
                for (ulong m = i; m <= j; m++)
                {
                    sum += m;
                }
            }

            return sum;
        }
    }
}
