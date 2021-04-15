using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_factory.CSharp
{
    class Asociado_Inversor : Asociado_Ahorrante, IAsociado
    {
        public static List<Asociado_Inversor> asociados_Inversores = new List<Asociado_Inversor>()
        {

        };
        public Asociado_Inversor(string nombree, string apellidoo, string direccionn, int num_cuentaa) : base(nombree, apellidoo, direccionn, num_cuentaa)
        {

        }
        public void Agregar()
        {
            Console.Clear();
            Console.WriteLine("Se acaba de Agregar un Asociado Inversionista");
        }

        public static void Mostrar_AsociadosInversionistas()
        {
            Console.Clear();
            Console.WriteLine("Entrando al modulo Muestra de Asociados Inversionistas.......");
            Console.WriteLine("Pulse ENTER para entrar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Lista de Asociados Inversionistas: ");

            Console.WriteLine();

            Console.WriteLine("Actualmente hay  " + asociados_Inversores.Count + " Asociados Inversionistas");
            Console.WriteLine();
            foreach (Asociado_Inversor asociado in asociados_Inversores)
            {
                Console.WriteLine(asociado);
                Console.WriteLine();

            }
            Console.WriteLine("Estas Son todos los Asociados Inversores Registrados...");
            Console.WriteLine("  Presione ENTER para volver al menu.......");
            Console.ReadKey();
        }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre} \nApellido: {this.Apellido} \nDireccion: {this.Direccion} \nTipo de Asociado: Inversionista \nNumero de Cuenta: {this.Num_cuenta.ToString("D11")}";
        }
    }
}
