using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Selectați tipul de conversie:");
            Console.WriteLine("1. Din Celsius în Fahrenheit");
            Console.WriteLine("2. Din Fahrenheit în Celsius");

            int optiune;
            while (!int.TryParse(Console.ReadLine(), out optiune) || (optiune != 1 && optiune != 2))
            {
                Console.WriteLine("Introduceți o opțiune validă (1 sau 2).");
            }

            double temperatura;
            string unitateInitiala, unitateFinala;

            if (optiune == 1)
            {
                Console.WriteLine("Introduceți temperatura în Celsius:");
                temperatura = Convert.ToDouble(Console.ReadLine());
                unitateInitiala = "℃";
                unitateFinala = "℉";
                double rezultat = CelsiusToFahrenheit(temperatura);
                Console.WriteLine("{0} {1} este egală cu {2} {3}", temperatura, unitateInitiala, rezultat, unitateFinala);
            }
            else
            {
                Console.WriteLine("Introduceți temperatura în Fahrenheit:");
                temperatura = Convert.ToDouble(Console.ReadLine());
                unitateInitiala = "℉";
                unitateFinala = "℃";
                double rezultat = FahrenheitToCelsius(temperatura);
                Console.WriteLine("{0} {1} este egală cu {2} {3}", temperatura, unitateInitiala, rezultat, unitateFinala);
            }
        }

        static double CelsiusToFahrenheit(double temperaturaCelsius)
        {
            return temperaturaCelsius * 9 / 5 + 32;
        }

        static double FahrenheitToCelsius(double temperaturaFahrenheit)
        {
            return (temperaturaFahrenheit - 32) * 5 / 9;
        }
    }

}
