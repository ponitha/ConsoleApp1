using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder("Hello ", 50);

            sb.Append("World!!");
            sb.AppendLine("Hello C#!");
            sb.AppendLine("This is new line.");

            Console.WriteLine(sb);
        }
    }
}
