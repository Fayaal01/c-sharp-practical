using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int myNum = 20;
            // myNum = 80; // Cannot chnage tghe value of a constant variable
            Console.WriteLine(myNum);

            /*int num = 15;
            num = 10;
            Console.WriteLine(num);*/
        }
    }
}
