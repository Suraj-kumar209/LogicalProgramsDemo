using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class RightTrianglePattern
    {
        static void Main()
        {
            Console.WriteLine("Enter number of rows");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<n;i++)
            {
                for (int j=1;j<=i;j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(int k=n-2; k>0; k--)
            {
                for (int l=1;l<=k;l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
