using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxPersonas = 0;

            Console.Write("Ingrese un número máximo de personas: ");
            while (!int.TryParse(Console.ReadLine(), out maxPersonas) || maxPersonas <= 0)
            {
                Console.WriteLine("Error: Por favor ingrese un número válido mayor que cero.");
            }

            Console.WriteLine("=============================");
            Console.WriteLine("El número máximo establecido es de " + maxPersonas + " personas.");
            Console.WriteLine("Presione una tecla para comenzar a contar...");

            Console.ReadKey();

            for (int i = 1; i <= maxPersonas; i++)
            {
                Console.WriteLine("Contando el numero de personas " + i);
            }

            Console.ReadKey();
        }
    }
}
