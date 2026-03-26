using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class BinaryTrianglePattern
    {
        static void Main()
        {
            Console.Write("Enter number of rows:");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <=n; i++)
            {
                int num = i % 2; 

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num);
                    num = 1 - num; 
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}
