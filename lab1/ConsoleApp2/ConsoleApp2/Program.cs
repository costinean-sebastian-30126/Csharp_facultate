using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    

    class Calculator
    {
        public static double Aduna(double a, double b)
        {
            return a + b;
        }

        public static double Scade(double a, double b)
        {
            return a - b;
        }

        public static double Inmulteste(double a, double b)
        {
            return a * b;
        }

        public static double Imparte(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Impartirea la zero nu este permisă!");
                return double.NaN; // Returnăm NaN (Not a Number) pentru a semnala o eroare
            }
            return a / b;
        }

        public static void AfiseazaRezultat(double rezultat)
        {
            Console.WriteLine("Rezultatul este: " + rezultat);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduceți două numere reale:");
            double numar1 = Convert.ToDouble(Console.ReadLine());
            double numar2 = Convert.ToDouble(Console.ReadLine());

            // Adunare
            double rezultatAdunare = Calculator.Aduna(numar1, numar2);
            Calculator.AfiseazaRezultat(rezultatAdunare);

            // Scădere
            double rezultatScadere = Calculator.Scade(numar1, numar2);
            Calculator.AfiseazaRezultat(rezultatScadere);

            // Înmulțire
            double rezultatInmultire = Calculator.Inmulteste(numar1, numar2);
            Calculator.AfiseazaRezultat(rezultatInmultire);

            // Împărțire
            double rezultatImpartire = Calculator.Imparte(numar1, numar2);
            Calculator.AfiseazaRezultat(rezultatImpartire);
        }
    }
}