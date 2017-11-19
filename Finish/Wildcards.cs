using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Codewars
{
    public class Wildcards : ICodeWars
    {
        object ICodeWars.Start()
        {
            return Func("????????????????????");
        }

        private List<string> Func(string str)
        {            
            //Not working with many 
            // var res = new List<string>(){str};
            // Rec(ref res);     
            // return res;

            //Lobg version
            if(!str.Contains('?')) return new List<string>(){str};
            var res  = Func(Regex.Replace(str, @"(.*)\?(.*)", "${1}0${2}"));
            res.AddRange(Func(Regex.Replace(str, @"(.*)\?(.*)", "${1}1${2}")));           
            return res;
        }

        private void Rec(ref List<string> res)
        {            
            var el = res.FirstOrDefault(i => i.Contains("?"));
            if(el == null) return;
            var indx = el.IndexOf('?');
            res.Add(ReplaceAtIndex(el, indx, '0'));
            res.Add(ReplaceAtIndex(el, indx, '1'));
            res.Remove(el);
            Rec(ref res);
        }

        private string ReplaceAtIndex(string str, int indx, char s)
        {
            var res = str.ToCharArray();
            res[indx] = s;
            return string.Join("", res);                       
        }
    }
}