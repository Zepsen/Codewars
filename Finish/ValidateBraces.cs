

using System.Collections.Generic;

public class ValidateBraces : ICodeWars
{  
    object ICodeWars.Start()
    {
        return Func();
    }

    bool Func()
    {
        var dic = new Dictionary<char, char>();
        dic.Add('{','}');
        dic.Add('[',']');
        dic.Add('(',')');

        var braces = "(})";
        var stack = new Stack<char>();
        
        for(var i = 0; i < braces.Length; i++)
        {                     
            if(dic.ContainsKey(braces[i]))
            {
                stack.Push(braces[i]);                
            }
            else 
            {
                if(stack.Count == 0) return false;
                var peek = stack.Peek();                
                if(dic[peek] == braces[i])
                {
                    stack.Pop();
                } else return false;
            }            
        }

        
        return stack.Count == 0;
    }
}