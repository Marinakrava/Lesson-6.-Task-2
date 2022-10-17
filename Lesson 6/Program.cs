using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = str.Length;
            string str2 = "";
            foreach (char c in str)
            {
                str2 = c + str2;
            }
            Console.WriteLine(str2);
            if (str == str2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

           
            Console.ReadKey();
        }
    }
}
