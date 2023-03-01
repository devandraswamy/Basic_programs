using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class swapping_number
    {
        public static void Main()
        {
            int n1 = 10, n2 = 20, temp = 0;
            Console.WriteLine($"Before Swapping number 1:{n1} and Number2:{n2}");
            temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine($"After Swapping number1:{n1}and number2:{n2}");
        }
    }
}
