namespace Codewars
{
    public class BouncingBalls : ICodeWars
    {
        object ICodeWars.Start()
        {
            var model = new 
            {
                h = 0.0,
                bounce = 0.0,
                window = 0.0
            };

            return Func(model);
        }

        private object Func(dynamic model)
        {
            var res = 0;
            if (Validate(model.h, model.bounce, model.window)) return -1;
            Bouncing(model.h, model.bounce, model.window, ref res);
            return res;
        }

        private int Bouncing(double h, double bounce, double window, ref int res)
        {            
            var bh = h * bounce;
            if(bh <= window) return res++;
            res += 2;
            return Bouncing(bh, bounce, window, ref res);            
        }

        private bool Validate(double h, double bounce, double window)
            => h <= 0 || bounce <= 0 || window <= 0 ||
               bounce >= 1 || 
               window >= h;
        
    }
}