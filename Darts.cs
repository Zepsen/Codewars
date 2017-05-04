using System;

namespace Codewars
{
    class Darts : ICodeWars
        {
        
        public object Start()
        {
            return Func(16, 16);
        }

        public static string Func(double x, double y)
        {            

            if(IsInCircle(BOARD.DROUT/2, x, y))
            {
                if(IsInCircle(BOARD.BULLEYE/2, x, y))
                {
                    return MESSAGE.BULL_EYE;   
                }
                else 
                {
                    if(IsInCircle(BOARD.BULL/2, x, y))
                    {
                        return MESSAGE.BULL;   
                    }
                    else 
                    {
                        return "IN";
                    }
                }
            }
            else 
            {
                return MESSAGE.MISS;
            }
        }

        public static bool IsInCircle(double R, double x, double y)
        {
            return Math.Pow(x - BOARD.CX,2) + Math.Pow((y - BOARD.CY),2) <= Math.Pow(R,2);
        }
    }

    public static class MESSAGE
    {
        public readonly static string MISS = "X";
        public readonly static string BULL_EYE = "DB";
        public readonly static string BULL = "SB";
        public readonly static string TRIPLE = "T";
        public readonly static string Double = "D";
    }

    public static class BOARD
    {
        public static double CX = 0;
        public static double CY = 0;

        public static double HK = 0.156;

        public static double DRIN = 324;
        public static double DROUT = 340;
        public static double TRIN = 214;
        public static double TROUT = 198;
        public static double BULL = 31.8;
        public static double BULLEYE = 12.7;
    }
}
