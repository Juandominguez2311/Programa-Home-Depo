using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHomeDepo
{
    class Menu
    {
        public static bool MenuPrincipal()
        {
            Console.Clear();
            int opcionIngresada;
            bool seguirEnElPrograma = true;

            OpcionesMenuPrincipal();

            opcionIngresada = Funciones.ValidarEntero(1, 6);
            Console.Clear();
            switch (opcionIngresada)
            {
                case 1:

                    SubMenuMostrarInformacion();
                    break;

                case 2:
                    LogicaDelPrograma.AgregarProducto();
                    LogicaDelPrograma.MostrarTodos();


                    break;

                case 3:
                    LogicaDelPrograma.ModificarValorProducto();
                    LogicaDelPrograma.MostrarTodos();
                    break;

                case 4:
                    LogicaDelPrograma.EliminarPorNombre();
                    LogicaDelPrograma.MostrarTodos();
                    break;
                case 5:
                    SubMenuFacturacion();
                    break;

                case 6:
                    seguirEnElPrograma = false;
                    break;

            }

            return seguirEnElPrograma;

        }

        /// <summary>
        /// crea encabezado de cada seccion
        /// </summary>
        public static void DibujarEncabezado(string textAMostrar)
        {
            string titulo = "*********** " + textAMostrar.Trim() + " ***********";
            string asterisquitos = string.Empty;

            for (int i = 0; i < titulo.Length; i++)
            {
                asterisquitos += "*";
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine(asterisquitos);
            Console.WriteLine(titulo);
            Console.WriteLine(asterisquitos);
            Console.WriteLine();
            Console.ResetColor();
        }

        /// <summary>
        /// opciones del menu principal
        /// </summary>
        public static void OpcionesMenuPrincipal()
        {
            DibujarEncabezado("Menu Principal");
            Console.WriteLine("\nIngrese una opcion\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     1. Mostrar Productos");
            Console.WriteLine("     2. Alta Productos");
            Console.WriteLine("     3. Modificación Productos");
            Console.WriteLine("     4. Eliminación Productos");
            Console.WriteLine("     5. Facturacion");
            Console.WriteLine("     6. Salir");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nIngrese una opcion");
            Console.ResetColor();
        }

        public static void OpcionesSubMenuMostrarInformacion()
        {
            DibujarEncabezado("Menu Mostrar");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Seccion Mostrar Informacion");
            Console.WriteLine("\nIngrese una opcion\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     1. Mostrar Todos  ");
            Console.WriteLine("     2. Mostrar Por Categoria");
            Console.WriteLine("     3. Buscar por nombre y mostrar");
            Console.WriteLine("     4. Buscar por Id y mostrar");
            Console.WriteLine("     5. Mostrar por stock");
            Console.WriteLine("     6. Volver al menu principal");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nIngrese una opcion");
            Console.ResetColor();

        }

        /// <summary>
        /// Sub menu de Mostrar
        /// </summary>
        public static void SubMenuMostrarInformacion()
        {
            int opcionIngresada;
            bool seguirEnElSubmenu;

            do
            {
                seguirEnElSubmenu = true;
                Console.Clear();

                OpcionesSubMenuMostrarInformacion();

                opcionIngresada = Funciones.ValidarEntero(1, 6);

                Console.Clear();
                switch (opcionIngresada)
                {
                    case 1:
                        LogicaDelPrograma.MostrarTodos();
                        seguirEnElSubmenu = SeguirEn("Mostrar Todos");
                        break;
                    case 2:
                        LogicaDelPrograma.BuscarPorCategoriaYMostrar();
                        seguirEnElSubmenu = SeguirEn("Mostrar Todos");
                        break;

                    case 3:
                        LogicaDelPrograma.BuscarPorNombreYMostrar();
                        seguirEnElSubmenu = SeguirEn("Mostrar Todos");
                        break;
                    case 4:
                        LogicaDelPrograma.BuscarPorIDYMostrar();
                        seguirEnElSubmenu = SeguirEn("Mostrar Todos");
                        break;
                    case 5:
                        LogicaDelPrograma.MostrarPorCantidadStock();
                        seguirEnElSubmenu = SeguirEn("Mostrar todos");
                        break;
                    case 6:
                        seguirEnElSubmenu = false;
                        break;
                }




            } while (seguirEnElSubmenu == true);

        }
        /// <summary>
        /// opciones Menu Facturacion
        /// </summary>
        public static void MenuFacturacion()
        {
            DibujarEncabezado("Menu Facturacion");
            Console.WriteLine("\nIngrese una opcion\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     1. Mostrar facturacion total");
            Console.WriteLine("     2. Producto que mas facturo");
            Console.WriteLine("     3. Facturacion de mayor a menor");
            Console.WriteLine("     4. Volver al menu principal");


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nIngrese una opcion");
            Console.ResetColor();

        }
        /// <summary>
        /// MenuFacturacion
        /// </summary>
        public static void SubMenuFacturacion()
        {
            int opcionIngresada;
            bool seguirEnElSubmenu;

            do
            {
                seguirEnElSubmenu = true;
                Console.Clear();

                MenuFacturacion();

                opcionIngresada = Funciones.ValidarEntero(1, 4);
                Console.Clear();
                switch (opcionIngresada)
                {
                    case 1:
                        LogicaDelPrograma.RecaudacionesTotales();
                        seguirEnElSubmenu = SeguirEn("Facturacion");
                        break;
                    case 2:
                        LogicaDelPrograma.FacturacionTotal();
                        seguirEnElSubmenu = SeguirEn("Facturacion");
                        break;

                    case 3:
                        LogicaDelPrograma.FacturacionMayorMenor();
                        seguirEnElSubmenu = SeguirEn("Facturacion");
                        break;

                    case 4:
                        seguirEnElSubmenu = false;
                        break;
                }
            } while (seguirEnElSubmenu == true);

        }



        public static bool SeguirEn(string auxUbicacion)
        {
            string datoIngresado;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nDesea continuar en " + auxUbicacion.ToUpper() + "?\n");

            MostrarPresionarTecla("V", " para volver al Menu anterior");
            MostrarPresionarTecla("M", " para volver al Menu Principal");

            datoIngresado = Funciones.ValidarOpciones(Console.ReadLine());

            if (datoIngresado == "v")
                return true;
            else
                return false;

        }

        public static void MostrarPresionarTecla(string tecla, string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nPresione ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(" " + tecla + " ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(mensaje);
            Console.WriteLine();
        }

    }
}

