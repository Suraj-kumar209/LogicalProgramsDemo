using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class SwapNumbersWithoutOther
    {
        static void Main()
        {
            int a = 342, b = 748;
            Console.WriteLine($"Numbers before Swap: a=>{a};b=>{b}");
            //a = a * b;
            //b = a / b;
            //a = a / b;

            //a = a + b;
            //b = a - b;
            //a = a - b;
            // using xor operator
            a = a ^ b;
            b= a ^ b;
            a = a ^ b;
            Console.WriteLine($"Numbers after Swap: a=>{a}; b=>{b}");
            Console.ReadLine();
        }
    }
}
