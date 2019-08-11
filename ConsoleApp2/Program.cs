using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = " xiao mi  ";
            string[] lines = result.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(lines.Length);
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

        }
    }
}
