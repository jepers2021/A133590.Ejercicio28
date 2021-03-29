using System;

namespace A133590.Ejercicio28
{
    class Program
    {
        static bool validarEntero(string ingreso, out int resultado)
        {
            bool exito = Int32.TryParse(ingreso, out resultado);
            if (!exito || resultado <= 0)
            {
                Console.WriteLine("Ingreso inválido. Terminando ejecución..");
                return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 28");
            Console.WriteLine("Programa que determina si un año ingresado es bisiesto.");

            int anyo;
            Console.Write("Por favor, ingrese el año: ");
            bool exito = validarEntero(Console.ReadLine(), out anyo);
            if (!exito)
            {
                Console.WriteLine("Presione cualquier tecla para continuar..");
                Console.ReadKey();
                return;
            }

            if(DateTime.IsLeapYear(anyo))
            {
                Console.WriteLine("El año ingresado es bisiesto.");
            }
            else
            {
                Console.WriteLine("El año ingresado no es bisiesto.");
            }

            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}
