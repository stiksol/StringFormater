using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormater
{
    class DelRep : mainString
    {
        string str1 = "";
        
        public string Str1
        {
            get { return str1; }
            set { str1 = value; }
        }

        int[] Count { get; set; }

        public override string SFormat(string str)
        {
            String result = null;
            ArrayList Count = new ArrayList();
            if (!String.IsNullOrEmpty(str))
            {
                List<String> lst = new List<String>(str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                if (lst.Count > 1)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        for (int j = i + 1; j < lst.Count; j++)
                        {
                            if (String.Compare(lst[i], lst[j], StringComparison.OrdinalIgnoreCase) == 0)
                            {
                                lst.RemoveAt(j);
                                Count.Add(j);
                                continue;
                            }
                        }
                    }

                }
                foreach (String ts in lst)
                    result += ts + " ";

                Console.ReadLine();
                foreach (var ArrayPrint in Count)
                    Console.WriteLine(ArrayPrint);
            }

            return result;
           // return str;
        }
    }
}
