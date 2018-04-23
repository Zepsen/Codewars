using System;

namespace Codewars
{
    public class BuyACar : ICodeWars
    {
        object ICodeWars.Start()
        {
            return Func(2000,8000,1000,1.5);
        }

        private object Func(int startPriceOld, int startPriceNew, int savingperMonth, double percentLossByMonth)       
        {                      
             var mth = 0;
            percentLossByMonth /= 100;
            var cache = savingperMonth;
            for(mth = 0; startPriceOld + cache < startPriceNew; mth++)
            {
                if(mth == 0) continue;
                startPriceOld -= (int)(startPriceOld*percentLossByMonth);
                startPriceNew -= (int)(startPriceNew*percentLossByMonth);
                cache += savingperMonth;
                if(mth%2 != 0 && mth > 1) percentLossByMonth += 0.005;
                System.Console.WriteLine($"{mth}:{startPriceOld}, {startPriceNew} {startPriceOld + cache - startPriceNew} {percentLossByMonth}");
            }
            var res = (mth == 0) ? startPriceOld - startPriceNew : startPriceOld + cache - startPriceNew;
            return $"{mth}, {res} {percentLossByMonth}";
        }
    }
}