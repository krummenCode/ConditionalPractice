using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter a number
            Console.WriteLine("Enter a positive or negative number");
            int myNumber = Convert.ToInt32(Console.ReadLine());
            
            if (myNumber > 0)
            {
                Console.WriteLine("True, your number is greater than 0");
            }
            else
            {
                Console.WriteLine("Your number is not greater than 0");
            }

            Console.ReadKey();
        }
    }
}
