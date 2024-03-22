using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{




    class GreutateIdealaCalculator
    {
        public static void Main()
        {
            Console.WriteLine("Introduceți înălțimea (în cm):");
            double inaltime = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduceți vârsta (în ani):");
            int varsta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceți sexul (f pentru femei, m pentru bărbați):");
            char sex = Convert.ToChar(Console.ReadLine());

            double greutate = CalculGreutateIdeala(inaltime, varsta, sex);
            AfisareGreutateIdeala(greutate);
        }

        public static double CalculGreutateIdeala(double inaltime, int varsta, char sex)
        {
            if (sex == 'm')
            {
                return inaltime - 100 - ((inaltime - 150) / 4) + ((varsta - 20) / 4);
            }
            else if (sex == 'f')
            {
                return inaltime - 100 - ((inaltime - 150) / 2.5) + ((varsta - 20) / 6);
            }
            else
            {
                Console.WriteLine("Sexul introdus nu este valid.");
                return 0;
            }
        }

        public static void AfisareGreutateIdeala(double greutate)
        {
            Console.WriteLine("Greutatea ideală este: " + greutate.ToString("0.00") + " kg");
        }
    }
}