using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class ReverseNumber
    {
        public void Reverse()
        {
            Console.WriteLine("Enter the Number you want to reverse");
            int number = Convert.ToInt32(Console.ReadLine());
            int revNum = 0; int rem;
            while (number > 0)
            {
                rem = number % 10;
                revNum = revNum* 10 + rem;
                number = number / 10;
            }
            Console.WriteLine("The reverse of the number is :" + revNum);
        }
    }
}
