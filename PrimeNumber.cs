﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    public class PrimeNumber
    {
        public static void FindThePrimeNumber()
        {
            int count = 0;
            Console.WriteLine("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= (number / 2); i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }

            if (count == 1)
            {
                Console.WriteLine(" Is Prime a number");
            }
            else
            {
                Console.WriteLine(" Is not a Prime number");
            }
        }
    }
}
