using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class MirroredTrianglePattern
    {
        static void Main()
        {
            Console.WriteLine("Enter number of rows");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i= 1;i<=n;i++)
            {
                Console.Write(new string('*',i));
                Console.Write(new string(' ',n-i));
                Console.WriteLine(new string('*',n-i+1));
            }
            Console.ReadLine();
        }
    }
}
