using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormater
{
    class SortAlphabet : mainString
    {
        string str3 = "";

        public string Str3
        {
            get { return str3; }
            set {str3 = value; }
        }

        public override string SFormat(string str)
        {
            String result = null;
            ArrayList Count = new ArrayList();
            if (!String.IsNullOrEmpty(str))
            {
                List<String> lst = new List<String>(str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                if (lst.Count > 1)
                {
                    for (int i = 0; i < lst.Count-1; i++)
                    {
                      for (int j = 0; j < lst.Count-i-1; j++)
                               if (lst[j].CompareTo(lst[j+1]) >0) //больше нуля значит, следует после сравниваемого объекта 
                               {
                                   string buf = lst[j];
                                   lst[j] = lst[j+1];
                                   lst[j+1] = buf; 
                                   
                               }
                    }

                }
                foreach (String ts in lst)
                    result += ts + " ";

                Console.ReadLine();

            }
            return result;
        }
    }
}
