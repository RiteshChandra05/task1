using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace strngbldr
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("one");
            sb.AppendLine();
            sb.Append("two").AppendLine();
            sb.Append("three");

            string inns = sb.ToString();
            Console.WriteLine(inns);
        }
    }
}
