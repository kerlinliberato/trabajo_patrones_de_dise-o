using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_factory.CSharp
{
    class Empleado_MedioTiempo : IEmpleado
    {
        public static List<Empleado_MedioTiempo> empleados_MedioTiempo = new List<Empleado_MedioTiempo>()
        {

        };

        private string nombre;
        private string apellido;
        private string direccion;
        private int num_Cuenta;

        public Empleado_MedioTiempo(string nombree, string apellidoo, string direccionn, int num_cuentaa)
        {
            this.Nombre = nombree;
            this.Apellido = apellidoo;
            this.Direccion = direccionn;
            this.Num_Cuenta = num_cuentaa;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Num_Cuenta { get => num_Cuenta; set => num_Cuenta = value; }

        public static void Mostrar_MediosTiempos()
        {
            Console.Clear();
            Console.WriteLine("Entrando al modulo Muestra de Empleados de Medio Tiempo.......");
            Console.WriteLine("Pulse ENTER para entrar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Lista de Empleados Medio Tiempo: ");
            Console.WriteLine();

            Console.WriteLine("Actualmente hay  " + empleados_MedioTiempo.Count + " Empleados de Medio Tiempo");
            Console.WriteLine();
            foreach (Empleado_MedioTiempo empleado in empleados_MedioTiempo)
            {
                Console.WriteLine(empleado);
                Console.WriteLine();

            }
            Console.WriteLine("Estas Son todos los empleados de Medio Tiempo Registrados...");
            Console.WriteLine("  Presione ENTER para volver al menu.......");
            Console.ReadKey();
        }

        public void Contratar()
        {
            Console.Clear();
            Console.WriteLine("Acaba de Contratar un empleado de Medio Tiempo");
        }
        public override string ToString()
        {
            return $"Nombre: {this.Nombre} \nApellido: {this.Apellido} \nDireccion: {this.Direccion} \nTipo de Empleado: Medio Tiempo \nHoras De Trabajo: 4 \nMetodo de Pago: Cuenta Bancaria \nNumero de Cuenta: {this.Num_Cuenta.ToString("D11")}";
        }
    }
}