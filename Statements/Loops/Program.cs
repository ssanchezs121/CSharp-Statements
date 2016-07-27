using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;

            Console.Write("Por Favor ingrese un numero");
            value = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < value; i++)
            {
                Console.WriteLine("El Valor de i es:" + i); // Concatenar
            }

            int u = value;

            while (u >= 0)
            {
                Console.WriteLine("El Valor de u es:" + u);
                u--;
            }
            bool active = true;

            while (active)
            {
                Console.WriteLine("El Stado es " + active);
            
            }
            

            Console.ReadKey();
        }


    }
}
