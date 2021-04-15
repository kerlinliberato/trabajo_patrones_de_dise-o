using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_factory.CSharp
{
    class Fabrica_Asociado
    {
        public static IAsociado GetAsociado(string nombre, string apellido, string direccion, int num_cuenta, int inversion)
        {
            if (inversion <= 999)
            {
                Asociado_Ahorrante asociado_Ahorrante = new Asociado_Ahorrante(nombre, apellido, direccion, num_cuenta);
                Asociado_Ahorrante.asociados_Ahorrantes.Add(asociado_Ahorrante);
                return asociado_Ahorrante;
            }
            if (inversion <= 1999)
            {
                Asociado_Inversor asociado_Inversor = new Asociado_Inversor(nombre, apellido, direccion, num_cuenta);
                Asociado_Inversor.asociados_Inversores.Add(asociado_Inversor);
                return asociado_Inversor;
            }
            else
            {
                Asociado_Accionista asociado_Accionista = new Asociado_Accionista(nombre, apellido, direccion, num_cuenta);
                Asociado_Accionista.asociados_Accionistas.Add(asociado_Accionista);
                return asociado_Accionista;
            }
        }
    }
}

    