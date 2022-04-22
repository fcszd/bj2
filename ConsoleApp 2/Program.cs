using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Y = 2022, M = 2, D = 20, H = 10, N = 7, S = 35;
            double i = Y + Math.Ceiling(Convert.ToDouble((M + 9) / 12));
            double j = Math.Ceiling(Convert.ToDouble(7 / 4 * i));
            double JD = 1721013.5 + 367 * Y - j + Math.Ceiling(Convert.ToDouble(275 * M / 9)) + D + H / 24 + N / 1440 + S / 86400;
            Console.WriteLine("JD={0}", JD);
            Console.ReadKey();
        }
    }
}
