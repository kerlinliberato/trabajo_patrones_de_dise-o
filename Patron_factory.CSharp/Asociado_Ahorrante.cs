using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_factory.CSharp
{
    class Asociado_Ahorrante : IAsociado
    {
        public static List<Asociado_Ahorrante> asociados_Ahorrantes = new List<Asociado_Ahorrante>()
        {

        };

        private string nombre;
        private string apellido;
        private string direccion;
        private int num_cuenta;

        public Asociado_Ahorrante(string nombree, string apellidoo, string direccionn, int num_cuentaa)
        {
            this.Nombre = nombree;
            this.Apellido = apellidoo;
            this.Direccion = direccionn;
            this.Num_cuenta = num_cuentaa;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Num_cuenta { get => num_cuenta; set => num_cuenta = value; }

        public void Agregar()
        {
            Console.Clear();
            Console.WriteLine("Se acaba de Agregar un Asociado Ahorrante");
        }

        public static void Mostrar_AsociadosAhorrantes()
        {
            Console.Clear();
            Console.WriteLine("Entrando al modulo Muestra de Asociados Ahorrantes.......");
            Console.WriteLine("Pulse ENTER para entrar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Lista de Asociados Ahorrantes: ");

            Console.WriteLine();

            Console.WriteLine("Actualmente hay  " + asociados_Ahorrantes.Count + " Asociados Ahorrantes");
            Console.WriteLine();
            foreach (Asociado_Ahorrante asociado in asociados_Ahorrantes)
            {
                Console.WriteLine(asociado);
                Console.WriteLine();

            }
            Console.WriteLine("Estas Son todos los Asociados Ahorrantes Registrados...");
            Console.WriteLine("  Presione ENTER para volver al menu.......");
            Console.ReadKey();
        }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre} \nApellido: {this.Apellido} \nDireccion: {this.Direccion} \nTipo de Asociado: Ahorrante \nNumero de Cuenta: {this.Num_cuenta.ToString("D11")}";
        }
    }
}
