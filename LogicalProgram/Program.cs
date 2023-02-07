using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Option Given Below: \n1.FibonacciSeries \n2. PerfectNumber \n Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonaccciSeries fibonacci = new FibonaccciSeries();
                    fibonacci.Series();
                    break;
                case 2:
                    PerfectNumber perfect = new PerfectNumber();
                    perfect.Perfect();
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}


