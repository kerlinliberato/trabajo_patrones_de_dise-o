using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_factory.CSharp
{
    class Fabrica_Empleado
    {
        public static IEmpleado GetEmpleado(string nombre, string apellido, string direccion, int num_cuenta, int horas_trabajo)
        {
            if (horas_trabajo == 8)
            {
                Empleado_Completo empleado_Completo = new Empleado_Completo(nombre, apellido, direccion, num_cuenta);
                Empleado_Completo.empleados_Completos.Add(empleado_Completo);
                return empleado_Completo;
            }
            if (horas_trabajo == 6)
            {
                Empleado_Temporero empleado_Temporero = new Empleado_Temporero(nombre, apellido, direccion);
                Empleado_Temporero.empleados_Temporeros.Add(empleado_Temporero);
                return empleado_Temporero;

            }
            if (horas_trabajo == 4)
            {
                Empleado_MedioTiempo empleado_MedioTiempo = new Empleado_MedioTiempo(nombre, apellido, direccion, num_cuenta);
                Empleado_MedioTiempo.empleados_MedioTiempo.Add(empleado_MedioTiempo);
                return empleado_MedioTiempo;
            }
            else
            {
                return new Retorno();
            }
        }
    }
}
