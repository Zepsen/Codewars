
    public interface ICodeWars
    {
        object Start();
    }


    public interface ICodeWars<T, R> : ICodeWars
    {
        R Func(T arg);
    }