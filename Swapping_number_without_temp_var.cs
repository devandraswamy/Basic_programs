using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class Swapping_number_without_temp_var
    {
        public static void Main()
        {
            int n1=10, n2=20;
            Console.WriteLine($"Before Swapping number={n1} And Number2={n2}");
            n1=n1*n2; //10*20=200
            n2=n1/n2; //200/20=10
            n1= n1/n2; //200/10=20
            Console.WriteLine($"After Swapping number1={n1} and number2={n2}");


        }
    }
}
