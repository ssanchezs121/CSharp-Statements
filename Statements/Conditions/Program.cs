using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un Caracter:");
            char c = (char)Console.Read(); //Casting para converti tipo de Variable

            // Condicion tipo if

            if (Char.IsLetter(c)) {
                if (char.IsLetter(c))
                {
                    Console.WriteLine("El Caracter es una minuscula");
                }
                else
                {
                    Console.WriteLine("El Caracter es una mayuscula");
                }

            }
            else
            {
                Console.WriteLine("El Caracter no es una letra");
            }
            Console.ReadKey();
        }
    }
}
