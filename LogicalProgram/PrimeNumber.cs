﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PrimeNumber
    {
        public void Prime()
        {
            Console.WriteLine("Enter the Number");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if(count > 1)
            {
                Console.WriteLine("It is not a Prime Number");
            }else
                Console.WriteLine("It is a Prime Number");
        }
    }
}
