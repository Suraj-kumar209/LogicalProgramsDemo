using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class HollowSquarePattern
    {
        static void Main()
        {
            Console.Write("Enter number of rows:");
            
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j == 0 || j == n - 1)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }
         
            }
            Console.ReadLine();
        }

    }
}
