using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConsole_Applications
{
    class StringExample
    {
        StringBuilder s = new StringBuilder();
        public void printstr()
        {
            //string format
            //string xx = String.Format("Text {0}", "x");
            //StringBuilder s = new StringBuilder();
            int x = 5;
            int z = 7;
            int answer;
            answer = x * z;
            s.AppendFormat("The answer is: {0}", answer);
            printS(s);
        }
        public static void printS(StringBuilder sb)
        {
            Console.WriteLine(sb.ToString());
            sb.Length = 0;
        }
    }
}
