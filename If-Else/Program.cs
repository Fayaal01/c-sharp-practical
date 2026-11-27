using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 10) {
                Console.WriteLine("Number is less than 10");
            }
            else if (n < 20) {
                Console.WriteLine("Number is less than 20");
            }
            else {
                Console.WriteLine("Number is  greatyer than or equal to 20");
            }
        }
    }
}
