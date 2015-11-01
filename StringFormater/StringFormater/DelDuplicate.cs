using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormater
{
    class DelDuplicate : mainString
    {
        string str2 = "";

        public string Str2
        {
            get { return str2; }
            set { str2 = value; }
        }
        public override string SFormat(string MyString)
        {

            char[] ch = {'!','@','#','$','%','^','&','*','(',')','+','№',';','?'};

          StringBuilder sb = new StringBuilder(MyString);
            for (int i=0; i<ch.Length; i++)
                        sb.Replace(ch[i],' ');

            for (int i = 0; i < sb.Length; i++ )
                sb.Replace("  "," ");

                MyString = sb.ToString();
 
            return MyString;
        }

    }
}
