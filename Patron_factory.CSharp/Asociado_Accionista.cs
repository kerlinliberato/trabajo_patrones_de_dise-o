using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_factory.CSharp
{
    class Asociado_Accionista : Asociado_Ahorrante, IAsociado
    {
        public static List<Asociado_Accionista> asociados_Accionistas = new List<Asociado_Accionista>()
        {

        };
        public Asociado_Accionista(string nombree, string apellidoo, string direccionn, int num_cuentaa) : base(nombree, apellidoo, direccionn, num_cuentaa)
        {

        }
        public void Agregar()
        {
            Console.Clear();
            Console.WriteLine("Se acaba de Agregar un Asociado Accionista");
        }

        public static void Mostrar_AsociadosAccionistas()
        {
            Console.Clear();
            Console.WriteLine("Entrando al modulo Muestra de Asociados Accionistas.......");
            Console.WriteLine("Pulse ENTER para entrar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Lista de Asociados Accionistas: ");

            Console.WriteLine();

            Console.WriteLine("Actualmente hay  " + asociados_Accionistas.Count + " Asociados Accionistas");
            Console.WriteLine();
            foreach (Asociado_Accionista asociado in asociados_Accionistas)
            {
                Console.WriteLine(asociado);
                Console.WriteLine();

            }
            Console.WriteLine("Estas Son todos los Asociados Accionistas Registrados...");
            Console.WriteLine("  Presione ENTER para volver al menu.......");
            Console.ReadKey();
        }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre} \nApellido: {this.Apellido} \nDireccion: {this.Direccion} \nTipo de Asociado: Accionista \nNumero de Cuenta: {this.Num_cuenta.ToString("D11")}";
        }
    }
}
