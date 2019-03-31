using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the text!");
            string str = Console.ReadLine();

            Console.WriteLine(str.ToArenian());
        }
    }
}
