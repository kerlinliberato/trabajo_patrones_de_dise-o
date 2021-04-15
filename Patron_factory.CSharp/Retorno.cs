using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_factory.CSharp
{
    class Retorno : IEmpleado
    {
        public void Contratar()
        {
            Console.WriteLine("Solo puede agregar empleados que trabajen: 4, 6,  o 8 Horas............... \nComuniquese con su Desarrollador de Software para habilitar mas posibilidades...............");
        }
    }
}
