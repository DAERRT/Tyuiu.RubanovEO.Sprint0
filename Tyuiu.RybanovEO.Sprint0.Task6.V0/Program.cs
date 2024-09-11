using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RybanovEO.Sprint0.Task6.V0.Lib;

namespace Tyuiu.RybanovEO.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array elem summ = " + DataService.AdditionArray(numsArray));
            Console.WriteLine("Array elem sub = " + DataService.SubtractionArray(numsArray));
            Console.WriteLine("Array elem mult = " + DataService.MultiplicationArray(numsArray));
            Console.ReadKey();
        }
    }
}
