using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Microsoft .NET Framework 2.0 Application Development Foundation";
            string[] splittedString = s.Split(' ');
            Array.Sort(splittedString);
            s = string.Join(" ", splittedString);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
