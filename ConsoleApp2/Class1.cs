using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp2
{
    class Class1
    {
        public static string a;

        //public string a;
        public static void Main()
        {
            a = Environment.CurrentDirectory;
            Console.WriteLine(Path.Combine(a, "JRE"));

        }
    }
}