using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    public class PerfectNumber
    {
        public static void ThePerfectNumber()
        {
            int number, sum = 0, n;
            Console.WriteLine("enter the Number");
            number = Convert.ToInt32(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("Entered number is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Entered number is not a perfect number");
                Console.ReadLine();
            }
        }
    }
}
