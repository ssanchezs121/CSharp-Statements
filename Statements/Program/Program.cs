using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool proceed = true;
            while (proceed)
            {
               char selection = printMenu();
                switch (selection)
                {
                    case 'a':
                        addValues();
                        break;
                    case 'b':
                        concatenationStrings();
                        break;
                    case 'c':
                        loopANumber();
                        break;
                    case 'd':
                        proceed = false;
                        Console.WriteLine("Adios");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opcion Incorreca");
                        break;
                }
               
            } 
        }

        private static void loopANumber()
        {
            throw new NotImplementedException();
        }

        private static void concatenationStrings()
        {
            throw new NotImplementedException();
        }

        private static void addValues()
        {
            throw new NotImplementedException();
        }

        static char printMenu()
        {
            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine("a - Sumar dos valores.");
            Console.WriteLine("b - Concantenar dos Strings.");
            Console.WriteLine("c - Iterar un numero.");
            Console.WriteLine("d - Salir.");
            char option = (char)Console.Read();
            Console.WriteLine();
            return option;
        }
    }
}
