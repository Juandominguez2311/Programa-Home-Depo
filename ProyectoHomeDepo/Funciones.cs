using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHomeDepo
{
    class Funciones
    {
        public static int ValidarEntero(int opcionMin, int opcionMax)
        {
            int opcion;

            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < opcionMin || opcion > opcionMax)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Reingrese opcion valida.\nIngrese una opcion entre {0} y {1}", opcionMin, opcionMax);
            }
            Console.ResetColor();

            return opcion;

        }

        public static string ValidarOpciones(string datoIngresado)
        {
            while (string.IsNullOrEmpty(datoIngresado) || (datoIngresado.ToLower().Trim() != "v" && datoIngresado.ToLower().Trim() != "m"))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Reingrese opcion valida.\nIngrese una opcion entre V o M");
                datoIngresado = Console.ReadLine();
            }
            Console.ResetColor();

            return datoIngresado;

        }
        /// <summary>
        /// Valida que el valor ingresado sea un numero
        /// </summary>
        /// <returns></returns>
        public static int ValidarNumero()
        {
            int numeroCorrecto;


            while (!int.TryParse(Console.ReadLine(), out numeroCorrecto))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Reingrese opcion valida.\nIngrese un numero");
            }
            Console.ResetColor();

            return numeroCorrecto;

        }
    }
}

