using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class FibonaccciSeries
    {
        public void Series()
        {
            Console.WriteLine("Enter the number of terms you want in fibonnaci Series ");
            int term = Convert.ToInt32(Console.ReadLine());
            int firstNum = 0; int secondNum = 1; int sum = 0, thirdNum = 0;
            Console.Write(firstNum + " " + secondNum + " ");
            
            for (int i = 3; i <= term; i++)
            {
                thirdNum = firstNum + secondNum;
                Console.Write(thirdNum + " ");
                firstNum = secondNum;
                secondNum = thirdNum;
            }
        }
    }
}
