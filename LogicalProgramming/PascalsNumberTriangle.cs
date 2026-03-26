using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PascalsNumberTriangle
    {
        static void Main()
        {
            Console.Write("Enter number of rows:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int result;
            for (int i=0;i<=n;i++)
            {
                result = 1;
                for (int j=i;j<=n-1;j++)
                {
                    Console.Write(" ");
                }
                for (int k=0;k<=i;k++)
                {
                    Console.Write(result+" ");
                    result = (result*(i-k)/(k+1));
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
