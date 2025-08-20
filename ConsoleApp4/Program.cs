using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter first Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition is" + (num1 + num2));
            Console.WriteLine("Substraction is" + (num1 - num2));
            Console.WriteLine("Multiplication is " + num1 * num2);
            Console.WriteLine("divition is " + num1 / num2);
            Console.WriteLine("Modulus is " + num1 % num2); 



        }
    }
}
