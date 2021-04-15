using System;
using System.Collections.Generic;
using System.Text;

namespace patronsigleton_CSharp
{
    class Empleado_Gerente
    {
        public static List<Empleado_Gerente> empleado_Gerente = new List<Empleado_Gerente>()
        {

        };

        private string nombre;
        private string apellido;
        private string direccion;
        private string tipo_empleado;

        private static Empleado_Gerente _gerente;

        private Empleado_Gerente(string nombre, string apellido, string direccion, string tipo_empleado)
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

        public static Empleado_Gerente Crear_Empleado_Gerente(string nombre, string apellido, string direccion, string Tipo)
        {
            if (_gerente == null)
            {
                _gerente = new Empleado_Gerente(nombre, apellido, direccion, Tipo);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Se ha creado Un nuevo Gerente!!!");
                Console.WriteLine("Pulse ENTER para contnuar....");
                Console.ReadKey();
            }
            return _gerente;
        }
        public static void Mostrar_Gerentes()
        {
            Console.Clear();
            Console.WriteLine("Entrando al modulo Muestra de Gerentes.......");
            Console.WriteLine("Pulse ENTER para entrar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("El gerente Actual es: ");
            Console.WriteLine();
            foreach (Empleado_Gerente gerente in Empleado_Gerente.empleado_Gerente)
            {
                Console.WriteLine(gerente);
                Console.WriteLine();

            }
            Console.WriteLine("  Presione ENTER para volver al menu.......");
            Console.ReadKey();
        }
        public override string ToString()
        {
            return $"Datos Gerente: \nNombre: {this.Nombre} \nApellido: {this.Apellido} \nDirección: {this.Direccion} \nTipo: {this.Tipo_empleado} ";
        }

    }
}