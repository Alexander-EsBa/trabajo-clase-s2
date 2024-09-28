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
            int horasTrabajadas;
            float costoHora;
            float sueldo;
            string linea;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===== EJERCICIO 1 =====");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\n$ Ingrese horas trabajadas por el operario: ");
            linea = Console.ReadLine();
            horasTrabajadas = int.Parse(linea);
            Console.Write("\n$ Ingrese el pago por hora: ");
            linea = Console.ReadLine();
            costoHora = float.Parse(linea);

            Console.ForegroundColor = ConsoleColor.Cyan;
            sueldo = horasTrabajadas * costoHora;
            Console.WriteLine("\n---> El sueldo total del operario es: " + sueldo);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n***** PRESIONE CUALQUIER TECLA PARA CONTINUAR *****\n");
            Console.ReadKey();
        }

        // Ejercicio 2
        public void ejercicio2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===== EJERCICIO 2 =====");
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

        // Ejercicio 3
        public void ejercicio3()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===== EJERCICIO 3 =====");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\n$ Ingrese el valor del lado del cuadrado: ");
            double lado = double.Parse(Console.ReadLine());
            double perimetro = 4 * lado;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n---> El perimetro del cuadrado es: " + perimetro);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n***** PRESIONE CUALQUIER TECLA PARA CONTINUAR *****\n");

            Console.ReadKey();
        }

        // Ejercicio 4
        public void ejercicio4()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===== EJERCICIO 4 =====");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\n$ Ingrese el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("\n$ Ingrese el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.Write("\n$ Ingrese el tercer número: ");
            int numero3 = int.Parse(Console.ReadLine());

            Console.Write("\n$ Ingrese el cuarto número: ");
            int numero4 = int.Parse(Console.ReadLine());

            int suma = numero1 + numero2;
            int producto = numero3 * numero4;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n---> La suma de los dos primeros números es: " + suma);
            Console.WriteLine("\n---> El producto del tercer y cuarto número es: " + producto);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n***** PRESIONE CUALQUIER TECLA PARA CONTINUAR *****\n");

            Console.ReadKey();
        }

        // Ejercicio 5
        public void ejercicio5()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===== EJERCICIO 5 =====");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\n$ Ingrese el primer número: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.Write("\n$ Ingrese el segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());

            Console.Write("\n$ Ingrese el tercer número: ");
            double numero3 = double.Parse(Console.ReadLine());

            Console.Write("\n$ Ingrese el cuarto número: ");
            double numero4 = double.Parse(Console.ReadLine());

            double suma = numero1 + numero2 + numero3 + numero4;
            double promedio = suma / 4;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n ---> La suma de los cuatro números es: " + suma);
            Console.WriteLine("\n ---> El promedio de los cuatro números es: " + promedio);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n***** PRESIONE CUALQUIER TECLA PARA CONTINUAR *****\n");

            Console.ReadKey();
        }

        // Ejercicio 6
        public void ejercicio6()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===== EJERCICIO 6 =====");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\n$ Ingrese el precio del artículo: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("\n$ Ingrese la cantidad que lleva el cliente: ");
            int cantidad = int.Parse(Console.ReadLine());

            double totalPagar = precio * cantidad;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n---> El total a pagar es: $" + totalPagar);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n***** PRESIONE CUALQUIER TECLA PARA CONTINUAR *****\n");

            Console.ReadKey();
        }

        // Ejercicio 7
        public void ejercicio7()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===== EJERCICIO 7 =====");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\n$ Ingrese el primer número: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.Write("\n$ Ingrese el segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());

            Console.Write("\n$ Ingrese el tercer número: ");
            double numero3 = double.Parse(Console.ReadLine());

            double raiz1 = Math.Sqrt(numero1);
            double raiz2 = Math.Sqrt(numero2);
            double raiz3 = Math.Sqrt(numero3);

            double resultado = raiz1 * raiz2 * raiz3;

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\n---> El resultado de multiplicar las raíces cuadradas de los tres números es: " + resultado);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n***** PRESIONE CUALQUIER TECLA PARA CONTINUAR *****\n");

            Console.ReadKey();
        }

        // Ejercicio 8
        public void ejercicio8()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===== EJERCICIO 8 =====");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n>>> Cálculo del área de un triángulo <<<");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n$ Ingrese la base del triángulo: ");
            double baseTriangulo = double.Parse(Console.ReadLine());

            Console.Write("\n$ Ingrese la altura del triángulo: ");
            double alturaTriangulo = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
            Console.WriteLine("\n---> El área del triángulo es: " + areaTriangulo);

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n>>> Cálculo del área de un círculo <<< ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n$ Ingrese el radio del círculo: ");
            double radioCirculo = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            double areaCirculo = Math.PI * Math.Pow(radioCirculo, 2);
            Console.WriteLine("\n---> El área del círculo es: " + areaCirculo);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n***** PRESIONE CUALQUIER TECLA PARA CONTINUAR *****\n");

            Console.ReadKey();
        }
        // Ejercicio 9
        public void ejercicio9()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===== EJERCICIO 9 =====");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\n$ Ingrese el tiempo en segundos: ");
            int segundos = int.Parse(Console.ReadLine());

            int segundosRestantes = 60 - (segundos % 60);

            if (segundosRestantes == 60)
            {
                segundosRestantes = 0;
            }


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n---> Los segundos restantes para llegar al siguiente minuto exacto son: " + segundosRestantes);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n***** PRESIONE CUALQUIER TECLA PARA CONTINUAR *****\n");

            Console.ReadKey();
        }   
        // Ejercicio 10
        public void ejercicio10()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===== EJERCICIO 10 =====");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\n$ Ingrese el nombre del curso: ");
            string nombreCurso = Console.ReadLine();

            Console.Write("\n$ Ingrese la cantidad de niños en el curso: ");
            int cantidadNinos = int.Parse(Console.ReadLine());

            Console.Write("\n$ Ingrese la cantidad de niñas en el curso: ");
            int cantidadNinas = int.Parse(Console.ReadLine());

            int totalAlumnos = cantidadNinos + cantidadNinas;

            double porcentajeNinos = (double)cantidadNinos / totalAlumnos * 100;
            double porcentajeNinas = (double)cantidadNinas / totalAlumnos * 100;

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\n---> Curso: " + nombreCurso);
            Console.WriteLine("\n---> Porcentaje de niños: " + porcentajeNinos + "%");
            Console.WriteLine("\n---> Porcentaje de niñas: " + porcentajeNinas + "%");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n***** PRESIONE CUALQUIER TECLA PARA CONTINUAR *****\n");

            Console.ReadKey();
        }

        // Ejercicio 11
        public void ejercicio11()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===== EJERCICIO 11 =====");
            Console.ForegroundColor = ConsoleColor.White;

            const double conversionKiloALibra = 2.20462;

            Console.Write("\n$ Ingrese la cantidad de kilos: ");
            double kilos = double.Parse(Console.ReadLine());

            double libras = kilos * conversionKiloALibra;

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\n---> " + kilos + " kilogramos es igual a " + libras + " libras.");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n***** PRESIONE CUALQUIER TECLA PARA CONTINUAR *****\n");

            Console.ReadKey();
        }

        // Ejercicio 12
        public void ejercicio12()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===== EJERCICIO 12 =====");
            Console.ForegroundColor = ConsoleColor.White;

            const double distancia = 96;

            Console.Write("\n$ Ingrese la velocidad del auto en km/h: ");
            double velocidad = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            if (velocidad <= 0)
            {
                Console.WriteLine("\n---> La velocidad debe ser mayor a 0.");
            }
            else
            {
                double tiempo = distancia / velocidad;
                Console.WriteLine("\n---> El tiempo estimado para ir de San José a Puntarenas es de: " + tiempo + " horas.");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n***** PRESIONE CUALQUIER TECLA PARA CONTINUAR *****\n");

            Console.ReadKey();
        }
    }
}
