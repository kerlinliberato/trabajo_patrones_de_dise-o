using System;

namespace Patron_factory.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Programa
            bool Continuar = true;

            do
            {
                int Opcion;

                Console.Clear();

                Console.WriteLine("----------------Bienvenido a la Banca De La Esquina-------------");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("MENU: ");
                Console.WriteLine();
                Console.WriteLine("1. Menu Manejo De Empleados");
                Console.WriteLine("2. Menu Manejo De Asociados");
                Console.WriteLine("3. Salir");
                Console.Write("Ingrese el numero del menu al que desea ingresar: ");
                Opcion = int.Parse(Console.ReadLine());

                switch (Opcion)
                {
                    case 1:
                        Console.Clear();
                        MenuEmpleados();
                        break;
                    case 2:
                        Console.Clear();
                        MenuAsociados();
                        break;
                    case 3:
                        Continuar = false;
                        break;
                    default:
                        Default();
                        break;
                }

            } while (Continuar);
            #endregion

            #region Codigo de Funciones
            void MenuEmpleados()
            {
                int opcion;

                Console.WriteLine("**** Bienvenido al Modulo manejo de Empleados ****");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("1. Agregar Empleado");
                Console.WriteLine("2. Mostrar Empleados De Tiempo Completo");
                Console.WriteLine("3. Mostrar Empleados De Medio Tiempo ");
                Console.WriteLine("4. Mostrar Empleados Temporeros");
                Console.WriteLine();
                Console.Write("Ingrese el numero de la opcion que desea: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Menu_AgregarEmpleado();
                        break;
                    case 2:
                        Empleado_Completo.Mostrar_EmpleadosCompletos();
                        break;
                    case 3:
                        Empleado_MedioTiempo.Mostrar_MediosTiempos();
                        break;
                    case 4:
                        Empleado_Temporero.Mostrar_Temporeros();
                        break;
                    default:
                        Default();
                        MenuEmpleados();
                        break;
                }

            }

            void MenuAsociados()
            {
                int opcion;

                Console.WriteLine("**** Bienvenido al Modulo manejo de Asociados ****");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("1. Agregar Un Asociado");
                Console.WriteLine("2. Mostrar Asociados Ahorrantes");
                Console.WriteLine("3. Mostrar Asociados Inversionistas ");
                Console.WriteLine("4. Mostrar Asociados Accionistas ");
                Console.WriteLine();
                Console.Write("Ingrese el numero de la opcion que desea: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Menu_AgregarAsociado();
                        break;
                    case 2:
                        Asociado_Ahorrante.Mostrar_AsociadosAhorrantes();
                        break;
                    case 3:
                        Asociado_Inversor.Mostrar_AsociadosInversionistas();
                        break;
                    case 4:
                        Asociado_Accionista.Mostrar_AsociadosAccionistas();
                        break;
                    case 5:
                        Console.WriteLine("Presione ENTER para regresar al menu principal.......");
                        Console.ReadKey();
                        break;
                    default:
                        Default();
                        MenuAsociados();
                        break;
                }
            }

            void Default()
            {
                Console.Clear();
                Console.WriteLine("La opcion que usted ha elegido es incorrecta o no es valida \n, pulse ENTER para volver al menu.............");
                Console.ReadKey();
            }
            #endregion

            #region Funciones_Factoy
            void Menu_AgregarEmpleado()
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al Modulo Para Registro De Empleados");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine();

                Console.Write("Ingrese Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese Apellido: ");
                string apellido = Console.ReadLine();
                Console.Write("Ingrese Direccion: ");
                string direccion = Console.ReadLine();
                Console.Write("Ingrese Numero de Cuenta: ");
                int num_cuenta = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la cantidad de horas que va a trabajar su empleado: ");
                int horas_trabajo = int.Parse(Console.ReadLine());

                IEmpleado fabrica_empleado = Fabrica_Empleado.GetEmpleado(nombre, apellido, direccion, num_cuenta, horas_trabajo);
                fabrica_empleado.Contratar();

                Console.ReadKey();

            }

            void Menu_AgregarAsociado()
            {
                int inversion;

                Console.Clear();
                Console.WriteLine("Bienvenido al Modulo Para Registrar Asociados");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine();

                Console.Write("Ingrese Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese Apellido: ");
                string apellido = Console.ReadLine();
                Console.Write("Ingrese direccion: ");
                string direccion = Console.ReadLine();
                Console.Write("Ingrese Numero de Cuenta: ");
                int num_cuenta = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la cantidad de dinero que desea invertir: ");
                inversion = int.Parse(Console.ReadLine());

                IAsociado fabrica_asociados = Fabrica_Asociado.GetAsociado(nombre, apellido, direccion, num_cuenta, inversion);
                fabrica_asociados.Agregar();

                Console.ReadKey();
            }

            #endregion 
        }
    }
}
