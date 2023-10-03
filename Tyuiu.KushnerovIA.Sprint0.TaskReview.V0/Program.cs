using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KushnerovIA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.KushnerovIA.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 6;
            int y = 4;
            int z = 1;
            int res = DataService.Calc(x, y, z);
            Console.WriteLine($"({x} + {y} + {z})* 5 = " + res);
            Console.ReadKey();
        }
    }
}