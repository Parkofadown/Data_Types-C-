using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 5;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 + d2;

            float f1 = 3.5f;
            float f2 = 1.223f;
            float sumF = f1 + f2;

            Console.WriteLine("The sum of {0} and {1} is " + sum, num1,num2);
            Console.WriteLine("The sum of {0} and {1} is " + sumD, d1,d2);
            Console.WriteLine("The sum of {0} and {1} is " + sumF, f1, f2);
            Console.ReadKey();

        
        }
    }
}
