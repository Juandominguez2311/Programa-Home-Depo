using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHomeDepo
{
    class LogicaDelPrograma
    {
        static string[,] MatrizProductos = new string[12, 3];

        static string[,] MatrizStock = new string[12, 3];

        static int[,] MatrizFacturacion = new int[12, 2];

        /// <summary>
        /// Inicia el programa. 
        /// </summary>
        public static void IniciarPrograma()
        {
            bool seguirEnElPrograma = true;
            LogicaDelPrograma.LlenarMatriz();

            do
            {

                seguirEnElPrograma = Menu.MenuPrincipal();

            } while (seguirEnElPrograma == true);

        }

        /// <summary>
        /// MUESTRA TODOS LOS DATOS
        /// </summary>
        public static void MostrarTodos()
        {
            Menu.DibujarEncabezado("Mostrar todos");

            for (int fila = 0; fila < MatrizProductos.GetLength(0); fila++)
            {
                for (int columna = 0; columna < MatrizProductos.GetLength(1); columna++)
                {
                    if (!string.IsNullOrEmpty(MatrizProductos[fila, 0]))
                    {
                        if (columna == 0)
                            Console.Write("{0,-3}| ", MatrizProductos[fila, columna]);
                        else if (columna == 1)
                            Console.Write("{0,-20}| ", MatrizProductos[fila, columna]);
                        else
                            Console.Write("{0,-17}| ", MatrizProductos[fila, columna]);

                    }

                }

                for (int columna = 0; columna < MatrizStock.GetLength(1); columna++)
                {
                    if (!string.IsNullOrEmpty(MatrizStock[fila, 0]))
                    {
                        if (columna == 0)
                            Console.Write("{0,-3}| ", MatrizStock[fila, columna]);
                        else if (columna == 1)
                            Console.Write("{0,-3}| ", MatrizStock[fila, columna]);
                        else
                            Console.WriteLine("{0,-3}| ", MatrizStock[fila, columna]);
                    }
                }


            }

        }

        /// <summary>
        /// llenamos las matrices con sus valores iniciales para simular que haya info
        /// </summary>
        public static void LlenarMatriz()
        {
            //ID
            MatrizProductos[0, 0] = "1";
            MatrizProductos[1, 0] = "2";
            MatrizProductos[2, 0] = "3";
            MatrizProductos[3, 0] = "4";
            MatrizProductos[4, 0] = "5";

            //NOMBRE PRODUCTO
            MatrizProductos[0, 1] = "maceta";
            MatrizProductos[1, 1] = "vela";
            MatrizProductos[2, 1] = "jabon";
            MatrizProductos[3, 1] = "lampara";
            MatrizProductos[4, 1] = "semilla frutilla";
            //CATEGORIA
            MatrizProductos[0, 2] = "jardineria";
            MatrizProductos[1, 2] = "bazar";
            MatrizProductos[2, 2] = "cuidado personal";
            MatrizProductos[3, 2] = "bazar";
            MatrizProductos[4, 2] = "jardineria";

            //STOCK
            MatrizStock[0, 0] = "100";
            MatrizStock[1, 0] = "30";
            MatrizStock[2, 0] = "25";
            MatrizStock[3, 0] = "50";
            MatrizStock[4, 0] = "100";
            //PRECIO
            MatrizStock[0, 1] = "90";
            MatrizStock[1, 1] = "60";
            MatrizStock[2, 1] = "30";
            MatrizStock[3, 1] = "70";
            MatrizStock[4, 1] = "10";
            //VENTAS
            MatrizStock[0, 2] = "50";
            MatrizStock[1, 2] = "120";
            MatrizStock[2, 2] = "135";
            MatrizStock[3, 2] = "100";
            MatrizStock[4, 2] = "40";


        }

        /// <summary>
        /// Muestra los productos por cantidad de stock
        /// </summary>
        public static void MostrarPorCantidadStock()
        {

            Menu.DibujarEncabezado("BUSCAR POR Stock");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Seccion Mostrar Informacion");
            Console.WriteLine("\nIngrese una opcion\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1: Stock mayor a 100");
            Console.WriteLine("2: Stock menor a 100");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Ingrese una opcion");
            Console.ResetColor();
            int opcionStock;
            opcionStock = Funciones.ValidarEntero(1, 2);
            Console.Clear();
            switch (opcionStock)
            {
                case 1:
                    Menu.DibujarEncabezado("MOSTRAR STOCK MAYOR A 100");
                    for (int fila = 0; fila < MatrizProductos.GetLength(0); fila++)
                    {
                        int stock;
                        if (!string.IsNullOrEmpty(MatrizStock[fila, 0]))
                        {
                            stock = int.Parse(MatrizStock[fila, 0]);

                            if (stock >= 100)
                            {
                                for (int columna = 0; columna < MatrizProductos.GetLength(1); columna++)
                                {
                                    if (columna == 0)
                                        Console.Write("{0,-3}| ", MatrizProductos[fila, columna]);
                                    else if (columna == 1)
                                        Console.Write("{0,-20}| ", MatrizProductos[fila, columna]);
                                    else
                                        Console.Write("{0,-17}| ", MatrizProductos[fila, columna]);
                                }
                                for (int columna = 0; columna < MatrizStock.GetLength(1); columna++)
                                {
                                    if (columna == 0)
                                        Console.Write("{0,-5}| ", MatrizStock[fila, columna]);
                                    else if (columna == 1)
                                        Console.Write("{0,-5}| ", MatrizStock[fila, columna]);
                                    else
                                        Console.WriteLine("{0,-5}| ", MatrizStock[fila, columna]);
                                }

                            }
                        }
                    }
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Write("");
                    break;

                case 2:
                    Menu.DibujarEncabezado("MOSTRAR STOCK MENOR A 100");
                    for (int fila = 0; fila < MatrizProductos.GetLength(0); fila++)
                    {
                        int stock;
                        if (!string.IsNullOrEmpty(MatrizStock[fila, 0]))
                        {
                            stock = int.Parse(MatrizStock[fila, 0]);

                            if (stock < 100)
                            {
                                for (int columna = 0; columna < MatrizProductos.GetLength(1); columna++)
                                {
                                    if (columna == 0)
                                        Console.Write("{0,-3}| ", MatrizProductos[fila, columna]);
                                    else if (columna == 1)
                                        Console.Write("{0,-20}| ", MatrizProductos[fila, columna]);
                                    else
                                        Console.Write("{0,-17}| ", MatrizProductos[fila, columna]);
                                }
                                for (int columna = 0; columna < MatrizStock.GetLength(1); columna++)
                                {
                                    if (columna == 0)
                                        Console.Write("{0,-5}| ", MatrizStock[fila, columna]);
                                    else if (columna == 1)
                                        Console.Write("{0,-5}| ", MatrizStock[fila, columna]);
                                    else
                                        Console.WriteLine("{0,-5}| ", MatrizStock[fila, columna]);
                                }

                            }
                        }
                    }
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Write("");
                    break;


            }



        }


        /// <summary>
        /// Agrega un Producto a las tablas
        /// </summary>
        public static void AgregarProducto()
        {
            Menu.DibujarEncabezado("Agregar producto");
            int opcionIngresada;
            string id = "";
            bool datoInsertado = false;
            Console.WriteLine("Ingrese el id del nuevo producto");
            opcionIngresada = Funciones.ValidarNumero();
            for (int fila = 0; fila < MatrizProductos.GetLength(0); fila++)
            {
                if (string.IsNullOrEmpty(MatrizProductos[fila, 1]) == false && MatrizProductos[fila, 0].ToLower().Contains(opcionIngresada.ToString()))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ID repetida , ingrese otra ID");
                    Console.ResetColor();
                    opcionIngresada = Funciones.ValidarNumero();
                }
                else
                { id = opcionIngresada.ToString(); }
            }


            Console.WriteLine("Ingrese el nombre del producto");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la categoria del producto");
            string CategoriaPrueba = Console.ReadLine();
            string Categoria = "";
            if (CategoriaPrueba.ToLower() == "bazar" | CategoriaPrueba == "jardineria" | CategoriaPrueba == "cuidado personal")
            {
                Categoria = CategoriaPrueba;
            }
            else
            {
                Console.WriteLine("Ingrese una categoria valida ");
                Console.WriteLine(" Las categorias validas son bazar , jardineria y cuidado personal ");
                CategoriaPrueba = Console.ReadLine();
                if (CategoriaPrueba.ToLower() == "bazar" | CategoriaPrueba == "jardineria" | CategoriaPrueba == "cuidado personal")
                {
                    Categoria = (CategoriaPrueba);
                }
            }
            Console.WriteLine("Ingrese la cantidad de unidades en stock");
            int StockPrueba = int.Parse(Console.ReadLine());
            string Stock = "";
            if (StockPrueba > 0)
            {
                Stock = StockPrueba.ToString();
            }
            else
            {
                Console.WriteLine("Ingrese la cantidad de unidades en stock");
                StockPrueba = int.Parse(Console.ReadLine());
                if (StockPrueba > 0)
                {
                    Stock = StockPrueba.ToString();
                }

            }
            Console.WriteLine("Ingrese el precio por unidad");
            int PrecioPrueba = int.Parse(Console.ReadLine());
            string Precio = "";
            if (PrecioPrueba > 0)
            {
                Precio = PrecioPrueba.ToString();
            }
            else
            {
                Console.WriteLine("Ingrese el precio por unidad");
                PrecioPrueba = int.Parse(Console.ReadLine());
                if (PrecioPrueba > 0)
                {
                    Precio = PrecioPrueba.ToString();
                }

            }
            Console.WriteLine("Ingrese la cantidad de ventas");
            int VentasPrueba = int.Parse(Console.ReadLine());
            string Ventas = "";
            if (VentasPrueba > 0)
            {
                Ventas = VentasPrueba.ToString();
            }
            else
            {
                Console.WriteLine("Ingrese la cantidad de ventas");
                PrecioPrueba = int.Parse(Console.ReadLine());
                if (PrecioPrueba > 0)
                {
                    Precio = PrecioPrueba.ToString();
                }

            }

            for (int fila = 0; fila < MatrizProductos.GetLength(0); fila++)
            {
                if (string.IsNullOrEmpty(MatrizProductos[fila, 0]))
                {
                    MatrizProductos[fila, 0] = id;
                    MatrizProductos[fila, 1] = Nombre.ToLower();
                    MatrizProductos[fila, 2] = Categoria;

                    datoInsertado = true;
                    break;
                }
            }
            for (int fila = 0; fila < MatrizStock.GetLength(0); fila++)
            {
                if (string.IsNullOrEmpty(MatrizStock[fila, 0]))
                {
                    MatrizStock[fila, 0] = Stock;
                    MatrizStock[fila, 1] = Precio;
                    MatrizStock[fila, 2] = Ventas;

                    datoInsertado = true;
                    break;
                }
            }

            Console.Clear();
            if (datoInsertado == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Datos insertados correctamente");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("No se pudieron insertar los datos");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }


        }
        /// <summary>
        /// Buscamos por categoria
        /// </summary>

        public static void BuscarPorCategoriaYMostrar()
        {
            Menu.DibujarEncabezado("BUSCAR POR CATEGORIA");
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese la categoria a buscar");

            string categoria = Console.ReadLine();


            while (string.IsNullOrEmpty(categoria.Trim()))
            {
                Console.WriteLine("Ingrese categoria valida");

                categoria = Console.ReadLine();
            }
            for (int fila = 0; fila < MatrizProductos.GetLength(0); fila++)
            {

                //primero tenemos que ver si no es nulo o vacio ese registro y despues, si no lo es, pasamos los valores a minuscula para que al comparar no haya problemas. Usamos .Contains para ver si ese valor de DATO existe aunque sea en parte en el registro matrizNombresElementos[fila, 1]. Devuelve true si existe
                if (string.IsNullOrEmpty(MatrizProductos[fila, 2]) == false && MatrizProductos[fila, 2].ToLower().Contains(categoria.ToLower()))
                {
                    for (int columna = 0; columna < MatrizProductos.GetLength(1); columna++)
                    {
                        if (columna == 0)
                            Console.Write("{0,-3}| ", MatrizProductos[fila, columna]);
                        else if (columna == 1)
                            Console.Write("{0,-20}| ", MatrizProductos[fila, columna]);
                        else
                            Console.Write("{0,-17}| ", MatrizProductos[fila, columna]);
                    }
                    for (int columna = 0; columna < MatrizStock.GetLength(1); columna++)
                    {
                        if (columna == 0)
                            Console.Write("{0,-5}| ", MatrizStock[fila, columna]);
                        else if (columna == 1)
                            Console.Write("{0,-5}| ", MatrizStock[fila, columna]);
                        else
                            Console.WriteLine("{0,-5}| ", MatrizStock[fila, columna]);
                    }

                }
            }

        }

        /// <summary>
        /// Modifica un producto
        /// </summary>
        public static void ModificarValorProducto()
        {
            Menu.DibujarEncabezado("MODIFICAR PRODUCTO");

            Console.WriteLine("Ingrese el producto a modificar");
            string producto = Console.ReadLine();


            while (string.IsNullOrEmpty(producto.Trim()))
            {
                Console.WriteLine("Ingrese el producto valido a buscar");

                producto = Console.ReadLine();
            }
            for (int fila = 0; fila < MatrizProductos.GetLength(0); fila++)
            {

                if (string.IsNullOrEmpty(MatrizProductos[fila, 1]) == false && MatrizProductos[fila, 1].ToLower().Contains(producto.ToLower()))
                {
                    for (int columna = 0; columna < MatrizProductos.GetLength(1); columna++)
                    {
                        Console.Write("{0} | ", MatrizProductos[fila, columna]);
                    }
                    for (int columna = 0; columna < MatrizStock.GetLength(1); columna++)
                    {
                        Console.Write("{0} | ", MatrizStock[fila, columna]);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("");

                    int opcionIngresada;
                    Console.WriteLine("Desea Modificar el producto?");
                    Console.WriteLine("1 : SI , MODIFICAR");
                    Console.WriteLine("2 : NO , CONSERVAR PRODUCTO");
                    opcionIngresada = Funciones.ValidarEntero(1, 2);
                    switch (opcionIngresada)
                    {
                        case 1:
                            Console.Clear();
                            Menu.DibujarEncabezado("MODIFICAR PRODUCTO");

                            for (fila = 0; fila < MatrizProductos.GetLength(0); fila++)
                            {
                                Console.WriteLine("Ingrese el id del nuevo producto");

                                int Idingresada;
                                string id = "";

                                Idingresada = Funciones.ValidarNumero();
                                for (fila = 0; fila < MatrizProductos.GetLength(0); fila++)
                                {
                                    if (string.IsNullOrEmpty(MatrizProductos[fila, 1]) == false && MatrizProductos[fila, 0].ToLower().Contains(Idingresada.ToString()))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("ID repetida , ingrese otra ID");
                                        Console.ResetColor();
                                        Idingresada = Funciones.ValidarNumero();
                                    }
                                    else
                                    { id = Idingresada.ToString(); }
                                }
                                /*Console.WriteLine("Ingrese el id del nuevo producto");
                                string id = Console.ReadLine();
                                */
                                Console.WriteLine("Ingrese el nombre del producto");
                                string Nombre = Console.ReadLine();
                                Console.WriteLine("Ingrese la categoria del producto");
                                string CategoriaPrueba = Console.ReadLine();
                                string Categoria = "";
                                if (CategoriaPrueba.ToLower() == "bazar" | CategoriaPrueba == "jardineria" | CategoriaPrueba == "cuidado personal")
                                {
                                    Categoria = CategoriaPrueba;
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una categoria valida /n Las categorias validas son bazar , jardineria y cuidado personal /n");
                                    CategoriaPrueba = Console.ReadLine();
                                    if (CategoriaPrueba.ToLower() == "bazar" | CategoriaPrueba == "jardineria" | CategoriaPrueba == "cuidado personal")
                                    {
                                        Categoria = (CategoriaPrueba);
                                    }
                                }
                                Console.WriteLine("Ingrese la cantidad de unidades en stock");
                                int StockPrueba = int.Parse(Console.ReadLine());
                                string Stock = "";
                                if (StockPrueba > 0)
                                {
                                    Stock = StockPrueba.ToString();
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese la cantidad de unidades en stock");
                                    StockPrueba = int.Parse(Console.ReadLine());
                                    if (StockPrueba > 0)
                                    {
                                        Stock = StockPrueba.ToString();
                                    }

                                }
                                Console.WriteLine("Ingrese el precio por unidad");
                                int PrecioPrueba = int.Parse(Console.ReadLine());
                                string Precio = "";
                                if (PrecioPrueba > 0)
                                {
                                    Precio = PrecioPrueba.ToString();
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese el precio por unidad");
                                    PrecioPrueba = int.Parse(Console.ReadLine());
                                    if (PrecioPrueba > 0)
                                    {
                                        Precio = PrecioPrueba.ToString();
                                    }

                                }
                                Console.WriteLine("Ingrese la cantidad de ventas");
                                int VentasPrueba = int.Parse(Console.ReadLine());
                                string Ventas = "";
                                if (VentasPrueba > 0)
                                {
                                    Ventas = VentasPrueba.ToString();
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese la cantidad de ventas");
                                    PrecioPrueba = int.Parse(Console.ReadLine());
                                    if (PrecioPrueba > 0)
                                    {
                                        Precio = PrecioPrueba.ToString();
                                    }

                                }

                                for (fila = 0; fila < MatrizProductos.GetLength(0); fila++)
                                {
                                    if (string.IsNullOrEmpty(MatrizProductos[fila, 1]) == false && MatrizProductos[fila, 1].ToLower().Contains(producto.ToLower()))
                                    {

                                        MatrizProductos[fila, 0] = id;
                                        MatrizProductos[fila, 1] = Nombre.ToLower();
                                        MatrizProductos[fila, 2] = Categoria;
                                    }
                                }
                                for (fila = 0; fila < MatrizStock.GetLength(0); fila++)
                                {
                                    if (string.IsNullOrEmpty(MatrizProductos[fila, 1]) == false && MatrizProductos[fila, 1].ToLower().Contains(producto.ToLower()))
                                    {
                                        MatrizStock[fila, 0] = Stock;
                                        MatrizStock[fila, 1] = Precio;
                                        MatrizStock[fila, 2] = Ventas;
                                    }
                                }

                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("PRODUCTO MODIFICADO");
                                Console.ReadLine();


                            }
                            break;
                        case 2:
                            Console.Write("Producto Conservado");
                            Console.WriteLine("");
                            Console.ReadLine();
                            Console.ResetColor();
                            break;
                    }
                }

            }
        }

        /// <summary>
        /// buscamos por nombre
        /// </summary>
        public static void BuscarPorNombreYMostrar()
        {
            Menu.DibujarEncabezado("BUSCAR POR NOMBRE");
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese dato a buscar");

            string dato = Console.ReadLine();

            while (string.IsNullOrEmpty(dato.Trim()))
            {
                Console.WriteLine("Ingrese dato valido a buscar");

                dato = Console.ReadLine();
            }
            Console.Clear();
            Menu.DibujarEncabezado("BUSCAR POR NOMBRE");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("El producto seleccionado es :");
            Console.WriteLine();
            Console.ResetColor();
            for (int fila = 0; fila < MatrizProductos.GetLength(0); fila++)
            {

                //primero tenemos que ver si no es nulo o vacio ese registro y despues, si no lo es, pasamos los valores a minuscula para que al comparar no haya problemas. Usamos .Contains para ver si ese valor de DATO existe aunque sea en parte en el registro matrizNombresElementos[fila, 1]. Devuelve true si existe
                if (string.IsNullOrEmpty(MatrizProductos[fila, 1]) == false && MatrizProductos[fila, 1].ToLower().Contains(dato.ToLower()))
                {
                    for (int columna = 0; columna < MatrizProductos.GetLength(1); columna++)
                    {
                        Console.Write("{0} | ", MatrizProductos[fila, columna]);
                    }
                    for (int columna = 0; columna < MatrizStock.GetLength(1); columna++)
                    {
                        Console.Write("{0} | ", MatrizStock[fila, columna]);
                    }
                    Console.WriteLine();
                }
            }

        }

        /// <summary>
        /// Busca y muestra un producto por ID
        /// </summary>
        public static void BuscarPorIDYMostrar()
        {
            Menu.DibujarEncabezado("BUSCAR POR Id");
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese id a buscar");

            string idABuscar = Console.ReadLine();

            while (string.IsNullOrEmpty(idABuscar.Trim()))
            {
                Console.WriteLine("Ingrese dato valido a buscar");

                idABuscar = Console.ReadLine();
            }
            Console.Clear();
            Menu.DibujarEncabezado("BUSCAR POR Id");

            for (int fila = 0; fila < MatrizProductos.GetLength(0); fila++)
            {
                if (string.IsNullOrEmpty(MatrizProductos[fila, 1]) == false && MatrizProductos[fila, 0].ToLower().Contains(idABuscar.ToLower()))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("El producto seleccionado es :");
                    Console.WriteLine();
                    Console.ResetColor();
                    for (int columna = 0; columna < MatrizProductos.GetLength(1); columna++)
                    {
                        Console.Write("{0} | ", MatrizProductos[fila, columna]);
                    }
                    for (int columna = 0; columna < MatrizStock.GetLength(1); columna++)
                    {
                        Console.Write("{0} | ", MatrizStock[fila, columna]);
                    }
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// Elimina un Producto 
        /// </summary>
        public static void EliminarPorNombre()
        {
            Menu.DibujarEncabezado("ELIMINAR PRODUCTO");
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese el producto a Eliminar");

            string producto = Console.ReadLine();
            while (string.IsNullOrEmpty(producto.Trim()))
            {
                Console.WriteLine("Ingrese el producto valido a buscar");

                producto = Console.ReadLine();
            }
            for (int fila = 0; fila < MatrizProductos.GetLength(0); fila++)
            {

                if (string.IsNullOrEmpty(MatrizProductos[fila, 1]) == false && MatrizProductos[fila, 1].ToLower().Contains(producto.ToLower()))
                {
                    for (int columna = 0; columna < MatrizProductos.GetLength(1); columna++)
                    {
                        Console.Write("{0} | ", MatrizProductos[fila, columna]);
                    }
                    for (int columna = 0; columna < MatrizStock.GetLength(1); columna++)
                    {
                        Console.Write("{0} | ", MatrizStock[fila, columna]);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("");

                    int opcionIngresada;
                    Console.WriteLine("Desea eliminar el producto?");
                    Console.WriteLine("1 : SI , ELIMINAR");
                    Console.WriteLine("2 : NO , CONSERVAR PRODUCTO");
                    opcionIngresada = Funciones.ValidarEntero(1, 2);
                    switch (opcionIngresada)
                    {
                        case 1:
                            for (fila = 0; fila < MatrizProductos.GetLength(0); fila++)
                            {

                                //primero tenemos que ver si no es nulo o vacio ese registro y despues, si no lo es, pasamos los valores a minuscula para que al comparar no haya problemas. Usamos .Contains para ver si ese valor de DATO existe aunque sea en parte en el registro matrizNombresElementos[fila, 1]. Devuelve true si existe
                                if (MatrizProductos[fila, 1].ToLower().Contains(producto.ToLower()))
                                {
                                    for (int columna = 0; columna < MatrizProductos.GetLength(1); columna++)
                                    {
                                        MatrizProductos[fila, columna] = null;
                                    }
                                    for (int columna = 0; columna < MatrizStock.GetLength(1); columna++)
                                    {
                                        MatrizStock[fila, columna] = null;
                                    }
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("PRODUCTO ELIMINADO");
                                    Console.ReadLine();
                                    break;
                                }
                            }
                            break;
                        case 2:
                            Console.Write("Producto Conservado");
                            Console.WriteLine("");
                            Console.ReadLine();
                            Console.ResetColor();
                            break;
                    }
                }

            }
        }

        //FACTURACION
        /// <summary>
        /// Muestra cuanto facturo cada producto
        /// </summary>
        public static void RecaudacionesTotales()
        {
            Menu.DibujarEncabezado("Facturacion Por Producto");
            for (int fila = 0; fila < MatrizFacturacion.GetLength(0); fila++)
            {

                if (!string.IsNullOrEmpty(MatrizProductos[fila, 0]))
                {

                    MatrizFacturacion[fila, 0] = int.Parse(MatrizProductos[fila, 0]);
                    MatrizFacturacion[fila, 1] = int.Parse(MatrizStock[fila, 1]) * int.Parse(MatrizStock[fila, 2]);

                }



                if (!string.IsNullOrEmpty(MatrizProductos[fila, 0]))
                {

                    Console.Write("{0,-3}| ", MatrizFacturacion[fila, 0]);

                    Console.WriteLine("{0,-3}| ", MatrizFacturacion[fila, 1]);
                }

            }
            Console.Read();
            Console.WriteLine();
        }

        /// <summary>
        /// Muestra la facturacion total del local
        /// </summary>
        public static void FacturacionTotal()
        {
            Menu.DibujarEncabezado("Facturacion Total");
            for (int fila = 0; fila < MatrizFacturacion.GetLength(0); fila++)
            {

                if (!string.IsNullOrEmpty(MatrizProductos[fila, 0]))
                {

                    MatrizFacturacion[fila, 0] = int.Parse(MatrizProductos[fila, 0]);
                    MatrizFacturacion[fila, 1] = int.Parse(MatrizStock[fila, 1]) * int.Parse(MatrizStock[fila, 2]);

                }
            }
            Console.WriteLine();

            int FacturacionTotal = 0;
            Console.Clear();
            Menu.DibujarEncabezado("Facturacion Total");
            for (int fila = 0; fila < MatrizFacturacion.GetLength(0); fila++)
            {

                if (!string.IsNullOrEmpty(MatrizProductos[fila, 0]))
                {

                    FacturacionTotal = FacturacionTotal += (MatrizFacturacion[fila, 1]);
                }
            }
            Console.WriteLine("LA FACTURACION TOTAL ES DE {0}", FacturacionTotal);
        }

        /// <summary>
        /// Muestra la facturacion de mayor a menor
        /// </summary>
        public static void FacturacionMayorMenor()
        {
            Menu.DibujarEncabezado("Facturacion de mayor a menor");
            for (int fila = 0; fila < MatrizFacturacion.GetLength(0); fila++)
            {

                if (!string.IsNullOrEmpty(MatrizProductos[fila, 0]))
                {

                    MatrizFacturacion[fila, 0] = int.Parse(MatrizProductos[fila, 0]);
                    MatrizFacturacion[fila, 1] = int.Parse(MatrizStock[fila, 1]) * int.Parse(MatrizStock[fila, 2]);

                }
            }
            Console.WriteLine();
            for (int fila = 0; fila < MatrizFacturacion.GetLength(0) - 1; fila++)
            {
                for (int filaPrueba = fila + 1; filaPrueba < MatrizFacturacion.GetLength(0); filaPrueba++)
                {
                    if (MatrizFacturacion[fila, 1] < MatrizFacturacion[filaPrueba, 1])
                    {
                        int idTemporal = MatrizFacturacion[fila, 0];
                        int facturacionTemporal = MatrizFacturacion[fila, 1];
                        MatrizFacturacion[fila, 0] = MatrizFacturacion[filaPrueba, 0];
                        MatrizFacturacion[fila, 1] = MatrizFacturacion[filaPrueba, 1];
                        MatrizFacturacion[filaPrueba, 0] = idTemporal;
                        MatrizFacturacion[filaPrueba, 1] = facturacionTemporal;
                    }
                }
            }
            for (int fila = 0; fila < MatrizFacturacion.GetLength(0); fila++)
            {
                if (!string.IsNullOrEmpty(MatrizProductos[fila, 0]))
                {

                    Console.Write("{0,-3}| ", MatrizFacturacion[fila, 0]);

                    Console.WriteLine("{0,-6}| ", MatrizFacturacion[fila, 1]);
                }

            }
            Console.WriteLine();
            Console.ReadLine();

        }


    }
}

