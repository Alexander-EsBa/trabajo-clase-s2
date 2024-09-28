using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_clase_s2
{
    internal class ejercicios
    {
        // Ejercicio 1
        public void ejercicio1()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===== EJERCICIO 1 =====");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\n$ Ingrese el primer numero entero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("\n$ Ingrese el segundo numero enter: ");
            int numero2 = int.Parse(Console.ReadLine());

            int suma = numero1 + numero2;
            int producto = numero1 * numero2;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n---> La suma de los dos numeros ingresados es: " + suma);
            Console.WriteLine("\n---> La multiplicacion de los dos numeros ingresados es: " + producto);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n***** PRESIONE CUALQUIER TECLA PARA CONTINUAR *****\n");

            Console.ReadKey();
        }
        // Ejercicio 2
        // Ejercicio 3
        // Ejercicio 4
        // Ejercicio 5
        // Ejercicio 6
        // Ejercicio 7
        // Ejercicio 8
        // Ejercicio 9
        // Ejercicio 10
        // Ejercicio 11
        // Ejercicio 12
    }
}
