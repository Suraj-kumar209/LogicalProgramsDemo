using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class SequentialNumberTriangle
    {
        static void Main()
        {
            Console.Write("Enter number of rows:");
            int n= Convert.ToInt32(Console.ReadLine());
            int k = 0;
            for (int i=1;i<=n;i++)
            {
               
                for (int j=1;j<=i;j++)
                {
                    k += 1;
                    Console.Write(k);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
