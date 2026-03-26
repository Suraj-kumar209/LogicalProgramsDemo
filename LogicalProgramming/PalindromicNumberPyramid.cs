using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PalindromicNumberPyramid
    {
        static void Main()
        {
            Console.Write("Enter number of rows:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int i=1;i<=n;i++)
            {
                for (int space=1;space<=(n-i);space++)
                {
                    Console.Write(" ");
                }
                for (int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                for (int k=(i-1);k>=1;k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
