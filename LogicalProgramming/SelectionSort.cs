using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class SelectionSort
    {
        static void Main()
        {
            int[] arr = { 59, 29, 7, 43, 92, 4,38 };
            for(int i=0;i<arr.Length-1; i++)
            {
                int min = i;
                for(int j=i+1;j<arr.Length; j++)
                {
                    if (arr[min] > arr[j])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int lowerValue = arr[min];
                    arr[min] = arr[i];
                    arr[i] = lowerValue;
                }
            }
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }
            Console.ReadLine();
        }
    }
}
