using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class ReversePyramidPattern
    {
        public static void Main()
        {
            Console.Write("Enter number of rows:");
            int n = Convert.ToInt32 (Console.ReadLine());
            for (int i=n;i>=1;i--)
            {
                for (int j=n;j>=i ;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
