using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworksApp
{
    class Utilities
    {
        internal static string prompt(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        internal static int GetNumber(string question)
        {
            Console.WriteLine(question);
            return int.Parse(Console.ReadLine());
        }
    }
}
