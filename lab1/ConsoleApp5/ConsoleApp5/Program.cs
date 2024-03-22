using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduceți numere întregi separate prin spațiu:");

            string[] inputNumbers = Console.ReadLine().Split(' ');

            // Calculul mediei aritmetice
            int sum = 0;
            foreach (string strNumber in inputNumbers)
            {
                int number;
                if (int.TryParse(strNumber, out number))
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine("Unul dintre elementele introduse nu este un număr întreg valid.");
                    return;
                }
            }
            double mediaAritmetica = (double)sum / inputNumbers.Length;
            Console.WriteLine("Media aritmetică este: " + mediaAritmetica);

            // Calculul mediei geometrice
            int product = 1;
            foreach (string strNumber in inputNumbers)
            {
                int number;
                if (int.TryParse(strNumber, out number) && number != 0)
                {
                    product *= number;
                }
                else
                {
                    Console.WriteLine("Unul dintre elementele introduse nu este un număr întreg valid sau este zero.");
                    return;
                }
            }
            double mediaGeometrica = Math.Pow(product, 1.0 / inputNumbers.Length);
            Console.WriteLine("Media geometrică este: " + mediaGeometrica);
        }
    }

}
