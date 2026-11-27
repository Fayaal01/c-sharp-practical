using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter operator (+ or -) : ");
            int opr = Convert.ToChar(Console.ReadLine());

            int result;

            switch (opr)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Result : " + result);//pls change it
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Result : " + result);
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
        }
    }
}
