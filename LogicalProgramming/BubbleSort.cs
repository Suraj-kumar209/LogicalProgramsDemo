using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class BubbleSort
    {
        static void Main()
        {
            int[] arr = { 54,79,58,7,42,23,91,3,74,38};
            bool itemMoved =false;
         
            Console.Write("Before sorting:" + arr);
            do
            {
                itemMoved = false;
                for(int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int lowerValue = arr[i + 1];
                        arr[i+1]  = arr[i];
                        arr[i] = lowerValue;
                        itemMoved = true;
                    }
                }
            } while (itemMoved);
            foreach(int i in arr)
            {
                Console.Write("After sorting: "+i+" ");
            }
            Console.ReadLine();
        }
    }
}
