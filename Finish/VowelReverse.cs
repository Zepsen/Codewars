using System.Linq;

namespace Codewars
{
    public class VowelReverse : ICodeWars<string, string>
    {
        char[] vowels = new [] { 'a','o','e','i','u', 'y' };

        public object Start()
        {
            var text = "Hello this is a new day";
            var result = "Hylla thes as i niw doe";
            var res = Func(text);
            var q = res.Equals(result);
            return res;
        }

        
        public string Func(string arg)
        {
            var arr = arg.ToCharArray();
            
            Item t1 = new Item();
            Item t2 = new Item();
                        
            int i = 0;            
            int y = arr.Length - 1;

            while (i <= y)
            {                
                if(!t1.Finded && vowels.Contains(arr[i]))             
                    t1.Save(i);

                if(!t2.Finded && vowels.Contains(arr[y])) 
                    t2.Save(y);
                
                if(t1.Finded && t2.Finded) 
                {
                    Swap(arr, t1.Index, t2.Index); 
                    t1.Clear();
                    t2.Clear();
                }

                if(!t1.Finded) i++;
                if(!t2.Finded) y--;            
            }
            
            return new string(arr);            
        }

        public void Swap(char[] arr, int i1, int i2)
        {
            var temp = arr[i1];
            arr[i1] = arr[i2];
            arr[i2] = temp;
        }

        public struct Item
        {
            public bool Finded;
            public int Index;

            public Item(bool find = false, int index = 0)
            {
                Finded = find;
                Index = index;
            }

            public void Save(int idx)
            {
                this.Index = idx;
                this.Finded = true;
            }

            public void Clear()
            {
                this.Index = 0;
                this.Finded = false;
            }

        }
    }
}