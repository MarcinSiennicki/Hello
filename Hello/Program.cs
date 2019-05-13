using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();
            for (; ; )
            {
                Greeting();
                Age();
                Settings();
            }
        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;

            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + maxLong);
        }

        /// <summary>
        /// ustawienia
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        /// <summary>
        /// Wypisujemy komunikat zalezny od wieku 
        /// </summary>
        private static void Age()
        {
            Console.Write("podaj wiek ");

            int age;

            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("pij piwo");
            }

            else if (result == false)
                Console.WriteLine("wprowadziłes niepoprawny wiek");

            else
                Console.WriteLine("pij mleko");
        }
        /// <summary>
        /// wypisuje powitanie
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wpisz imeie");

            string name = Console.ReadLine();
            Console.WriteLine("Witaj " + name);
        }
    }
}
