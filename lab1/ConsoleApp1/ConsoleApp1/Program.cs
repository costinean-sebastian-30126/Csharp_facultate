using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Introduceți numărul de termeni dorit pentru secvența Fibonacci:");

            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Vă rugăm să introduceți un număr întreg pozitiv.");
            }

            Console.WriteLine("Primii " + n + " termeni ai secvenței Fibonacci sunt:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }

        static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
