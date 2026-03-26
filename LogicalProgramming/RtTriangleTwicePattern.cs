using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class RtTriangleTwicePattern
    {
        static void Main()
        {
            Console.Write("Enter number of rows:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<=number;i++)
            {
                for (int j=1;j<=i;j++)
                {
                    Console.Write("*");
                   
                }
                Console.Write(" ");
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
