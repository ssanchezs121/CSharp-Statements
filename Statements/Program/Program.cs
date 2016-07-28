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
                        Console.Clear();
                        break;
                    case 'b':
                        concatenationStrings();
                        Console.Clear();
                        break;
                    case 'c':
                        loopANumber();
                        Console.Clear();
                        break;
                    case 'd':
                        proceed = false;
                        Console.WriteLine("Adios");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta");
                        break;
                }

                Console.ReadKey();

            } 
        }

        private static void loopANumber()
        {
            int value;

            Console.Write("Por Favor ingrese un numero \n");
            Console.ReadLine();
            value = Convert.ToInt32(Console.ReadLine());

            for (int result = 0; result < value; result++)
            {
                Console.WriteLine("El Valor de result es: \n" + result);

            }
            Console.ReadKey();
        }

        private static void concatenationStrings()
        {
            Console.WriteLine("Ingrese el primer texto por favor ");
            Console.ReadLine();
            string text1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo texto por favor");
            string text2 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("El resultado de la concatenacion es: "+ text1 + " " + text2);
            Console.ReadKey();

        }

        private static void addValues()
        {
            int result;

            Console.WriteLine("Digite un numero por favor:" );
            Console.ReadLine();
            int value1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite otro numero por favor:");
            int value2 = Convert.ToInt32(Console.ReadLine());


            result = value1 + value2;

            Console.WriteLine("El resultado de la suma es:" + result);
            Console.ReadKey();


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
