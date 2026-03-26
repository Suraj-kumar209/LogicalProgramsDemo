using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class InvertedNumberDiamondPattern
    {
        static void Main()
        {
            Console.Write("Enter number of rows:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i=n; i>0; i--)
            {
                for (int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
