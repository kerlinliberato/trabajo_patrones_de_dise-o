using System;
using System.Collections.Generic;
using System.Text;

namespace patronsigleton_CSharp
{
    class Empleado_Vendedor
    {
        public static List<Empleado_Vendedor> empleados_Vendedores = new List<Empleado_Vendedor>()
        {

        };

        private string nombre;
        private string apellido;
        private string direccion;
        private string tipo_empleado;

        public Empleado_Vendedor(string nombre, string apellido, string direccion, string tipo_empleado)
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

        public static void Mostrar_Vendedores()
        {
            Console.Clear();
            Console.WriteLine("Entrando al modulo Muestra de Vendedores.......");
            Console.WriteLine("Pulse ENTER para entrar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Lista de Vendedores: ");
            Console.WriteLine();

            Console.WriteLine("Actualmente hay  " + empleados_Vendedores.Count + " Empleados vendedores");
            Console.WriteLine();
            foreach (Empleado_Vendedor vendedor in empleados_Vendedores)
            {
                Console.WriteLine(vendedor);
                Console.WriteLine();

            }
            Console.WriteLine("Estas Son todos los vendedores registrados...");
            Console.WriteLine("  Presione ENTER para volver al menu.......");
            Console.ReadKey();
        }
    }
}