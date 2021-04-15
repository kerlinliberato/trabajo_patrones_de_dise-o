using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_factory.CSharp
{
    class Empleado_Completo : Empleado_MedioTiempo, IEmpleado
    {
        public static List<Empleado_Completo> empleados_Completos = new List<Empleado_Completo>()
        {

        };
        public Empleado_Completo(string nombree, string apellidoo, string direccionn, int num_cuentaa) : base(nombree, apellidoo, direccionn, num_cuentaa)
        {

        }
        public void Contratar()
        {
            Console.Clear();
            Console.WriteLine("Acaba de Contratar un empleado de Tiempo Completo");
        }

        public static void Mostrar_EmpleadosCompletos()
        {
            Console.Clear();
            Console.WriteLine("Entrando al modulo Muestra de Empleados de Tiempo Completo.......");
            Console.WriteLine("Pulse ENTER para entrar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Lista de Empleados Tiempo Completo: ");
            Console.WriteLine();

            Console.WriteLine("Actualmente hay  " + empleados_Completos.Count + " Empleados de Tiempo Completo");
            Console.WriteLine();
            foreach (Empleado_Completo empleado in empleados_Completos)
            {
                Console.WriteLine(empleado);
                Console.WriteLine();

            }
            Console.WriteLine("Estas Son todos los empleados de Tiempo Completo Registrados...");
            Console.WriteLine("  Presione ENTER para volver al menu.......");
            Console.ReadKey();
        }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre} \nApellido: {this.Apellido} \nDireccion: {this.Direccion} \nTipo de Empleado: Tiempo Completo \nHoras De Trabajo: 4 \nMetodo de Pago: Cuenta Bancaria \nNumero de Cuenta: {this.Num_Cuenta.ToString("D11")}";
        }
    }
}