using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Codewars
{
    class DirectionsReduction : ICodeWars
    {
        public object Start()
        {
            Func2(new string[]{"NORTH", "WEST", "SOUTH", "EAST"});
            Func2(new string[] {"NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST"});
            return null;
        }

        private static string[] Func(string[] dir)        
        {
            // var res = dir.GroupBy(i => i)
            //              .Select(i => new { D = i.Key, Count = i.Count()})
            //              .Where(i => i.Count % 2 != 0)
            //              .Select(i => i.D)
            //              .ToArray();

            var opposite = new Dictionary<string, string> { ["NORTH"] = "SOUTH", ["SOUTH"] = "NORTH", ["WEST"] = "EAST",["EAST"] = "WEST" };
            for(int i = 0; i < dir.Length; i++)
            {     
                var count =  dir.Count();
                if(count > 2 && i+1 < count)
                {
                    if(dir[i] == opposite[dir[i+1]] )
                    {                    
                        dir = dir.Take(i).Concat(dir.Skip(i+2)).ToArray();
                        i=-1;
                    }
                }
            }
            var res = dir;
            return new string[]{""};
        }

        //Best 
        private static string[] Func2(string[] arr)
        {
            string s = new string(arr.Select(x=>x[0]).ToArray());
            while (Regex.Match(s,"NS|EW|SN|WE").Success) s=Regex.Replace(s,"NS|EW|SN|WE","");
            return s.Select(x=>x=='N' ? "NORTH" : x=='S' ? "SOUTH" : x=='E' ? "EAST" : "WEST").ToArray();
        }

        //Best Stack
        private static string[] Func3(string[] arr)
        {
            var opposite = new Dictionary<string, string> { ["NORTH"] = "SOUTH", ["SOUTH"] = "NORTH", ["WEST"] = "EAST",["EAST"] = "WEST" };
            var stack = new Stack<string>();
            foreach(var dir in arr)
            {
                
            }
        }
    }
}