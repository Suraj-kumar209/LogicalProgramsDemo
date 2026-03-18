using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PalindromeNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter a Number:");
            int Number = int.Parse(Console.ReadLine());
            int oldNumber = Number;
            int Reminder, Reverse = 0;
            while (Number!=0)
            {
                Reminder = Number % 10;
                Reverse = (Reverse * 10) + Reminder;
                Number = Number / 10;
            }
            if(oldNumber == Reverse)
            {
                Console.WriteLine("Given number is a palindrome");
            }
            else
            {
                Console.WriteLine("Given number is not a palindrome");
            }
            Console.ReadLine();
        }
    }
}
