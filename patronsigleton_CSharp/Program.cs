using System;

namespace patronsigleton_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();

                Console.WriteLine("----------------Bienvenido a la Empresa Kerlin-------------");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("MENU: ");
                Console.WriteLine("Ingrese el numero de la accion que desea realizar: ");
                Console.WriteLine();
                Console.WriteLine("1. Creacion De Empleados");
                Console.WriteLine("2. Muestra de Empleados");
                Console.WriteLine("3. Salir");

                int Opcion = int.Parse(Console.ReadLine());

                switch (Opcion)
                {
                    case 1:
                        Console.Clear();
                        CrearEmpleados();
                        break;
                    case 2:
                        Console.Clear();
                        MostrarEmpleados();
                        break;
                    case 3:
                        continuar = false;
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("El tipo de empleado que ha ingresado no existe vuelva a intentarlo");
                        Console.WriteLine("Pulse ENTER para contnuar....");
                        Console.ReadKey();
                        break;
                }

            } while (continuar);
        }

        static void CrearEmpleados()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            string Nombre;
            string Direccion;
            string Apellido;

            Console.WriteLine("***********************************");
            Console.WriteLine("Bienenido al Generador de empleados");
            Console.WriteLine("***********************************");
            Console.WriteLine();
            Console.WriteLine("Vamos a Crear Un Nuevo Empleado");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Ingrese Nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Ingrese Apellido: ");
            Apellido = Console.ReadLine();
            Console.Write("Ingrese Direccion: ");
            Direccion = Console.ReadLine();
            Console.WriteLine("-Gerente");
            Console.WriteLine("-Vendedor");
            Console.WriteLine("-Empacador");
            Console.Write("Escriba el tipo de empleado que desea crear: ");
            string tipo = Console.ReadLine();
            switch (tipo)
            {
                case "Gerente":
                    Empleado_Gerente _Gerente = Empleado_Gerente.Crear_Empleado_Gerente(Nombre, Apellido, Direccion, tipo);
                    Empleado_Gerente.empleado_Gerente.Add(_Gerente);
                    Console.Clear();
                    break;
                case "Vendedor":
                    Empleado_Vendedor empleado_Vendedor = new Empleado_Vendedor(Nombre, Apellido, Direccion, tipo);
                    Empleado_Vendedor.empleados_Vendedores.Add(empleado_Vendedor);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Se ha creado Un nuevo Gerente!!!");
                    Console.WriteLine("Pulse ENTER para contnuar....");
                    Console.ReadKey();
                    break;
                case "Empacador":
                    Empleado_Empacador empleado_Empacador = new Empleado_Empacador(Nombre, Apellido, Direccion, tipo);
                    Empleado_Empacador.empleados_Empacadores.Add(empleado_Empacador);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Se ha creado Un nuevo Gerente!!!");
                    Console.WriteLine("Pulse ENTER para contnuar....");
                    Console.ReadKey();
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El tipo de empleado que ha ingresado no existe vuelva a intentarlo");
                    Console.WriteLine("Pulse ENTER para contnuar....");
                    Console.ReadKey();
                    break;
            }
        }

        static void MostrarEmpleados()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("MENU: ");
            Console.WriteLine();
            Console.WriteLine("1. Mostrar Gerentes");
            Console.WriteLine("2. Mostrar Vendedores");
            Console.WriteLine("3. Mostrar Empacadores");
            Console.WriteLine();
            Console.Write("Ingrese el numero de la accion que desea realizar: ");
            int Opcion = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            switch (Opcion)
            {
                case 1:
                    Console.Clear();
                    Empleado_Gerente.Mostrar_Gerentes();
                    break;
                case 2:
                    Console.Clear();
                    Empleado_Vendedor.Mostrar_Vendedores();
                    break;
                case 3:
                    Console.Clear();
                    Empleado_Empacador.Mostrar_Empacador();
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("La opcion que ha ingresado no existe vuelva a intentarlo");
                    Console.WriteLine("Pulse ENTER para contnuar....");
                    Console.ReadKey();
                    break;
            }
        }
    }
    }