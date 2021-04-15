using System;
using System.Collections.Generic;
using System.Text;

namespace patronsigleton_CSharp
{
    class Empleado_Empacador
    {
        public static List<Empleado_Empacador> empleados_Empacadores = new List<Empleado_Empacador>()
        {

        };

        private string nombre;
        private string apellido;
        private string direccion;
        private string tipo_empleado;

        public Empleado_Empacador(string nombre, string apellido, string direccion, string tipo_empleado)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Tipo_empleado = tipo_empleado;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Tipo_empleado { get => tipo_empleado; set => tipo_empleado = value; }

        public static void Mostrar_Empacador()
        {
            Console.Clear();
            Console.WriteLine("Entrando al modulo Muestra de Empacadores.......");
            Console.WriteLine("Pulse ENTER para entrar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Lista de Empacadores: ");
            Console.WriteLine();

            Console.WriteLine("Actualmente hay  " + empleados_Empacadores.Count + " Empleados Empacadores");
            Console.WriteLine();
            foreach (Empleado_Empacador empleado_ in empleados_Empacadores)
            {
                Console.WriteLine(empleado_);
                Console.WriteLine();

            }
            Console.WriteLine("Estas Son todos los empacadores registrados...");
            Console.WriteLine("  Presione ENTER para volver al menu.......");
            Console.ReadKey();
        }
    }
    }