using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_factory.CSharp
{
    class Empleado_Temporero : IEmpleado
    {
        public static List<Empleado_Temporero> empleados_Temporeros = new List<Empleado_Temporero>()
        {

        };

        private string nombre;
        private string apellido;
        private string direccion;
        public Empleado_Temporero(string Nombree, string Apellidoo, string Direccionn)
        {
            this.Nombre = Nombree;
            this.Apellido = Apellidoo;
            this.Direccion = Direccionn;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public void Contratar()
        {
            Console.Clear();
            Console.WriteLine("Acaba de contratar un empleado temporero....\nPor lo tanto su numero de cuenta ya no se usara para su pago.......");
        }

        public static void Mostrar_Temporeros()
        {
            Console.Clear();
            Console.WriteLine("Entrando al modulo Muestra de empleados Temporeros.......");
            Console.WriteLine("Pulse ENTER para entrar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Lista de Empleados Temporeros: ");
            Console.WriteLine();

            Console.WriteLine("Actualmente hay  " + empleados_Temporeros.Count + " Empleados de Tiempo Completo");
            Console.WriteLine();
            foreach (Empleado_Temporero empleado in empleados_Temporeros)
            {
                Console.WriteLine(empleado);
                Console.WriteLine();

            }
            Console.WriteLine("Estas Son todos los empleados de tiempo Completo registrados...");
            Console.WriteLine("  Presione ENTER para volver al menu.......");
            Console.ReadKey();
        }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre} \nApellido: {this.Apellido} \nDireccion: {this.Direccion} \nTipo de Empleado: Temporero \nHoras De Trabajo: 6 \nMetodo de Pago: Cobra por Cheque";
        }
    }
}

