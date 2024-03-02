using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    internal class Program
    {
        [DllImport("Calculator.dll")]
        public static extern int MultiplyNumbers(int num1, int num2);
        static void Main(string[] args)
        {


            int num1 = 2;
            int num2 = 3;

       
            int result = MultiplyNumbers(num1, num2);

            // Display the result
            Console.WriteLine($"results : {result}");


        }
    }
}
