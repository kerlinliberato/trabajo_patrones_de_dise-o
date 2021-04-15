using System;

namespace Patron_facade_Csharp
{
    public class Nomina
    {
        public double ObtenerSalarioEmpleado(string idEmpleado)
        {
            // Simulamos los empleados de la compañía
            var empleados = new List<Empleado>()
            {
                new Empleado() {Id = "1", Nombre = "Empleado 1", Salario = 1500000},
                new Empleado() {Id = "2", Nombre = "Empleado 2", Salario = 2000000},
                new Empleado() {Id = "3", Nombre = "Empleado 3", Salario = 3000000},
                new Empleado() {Id = "4", Nombre = "Empleado 4", Salario = 4000000},
            };

            // ... Operaciones complejas y calculos del negocio.

            return empleados.First(c => c.Id.Equals(idEmpleado)).Salario;
        }
    }
    public class Beneficio
    {
        public List<dominio.Beneficio> ObtenerrBeneficiosEmpleado(string idEmpleado)
        {
            // ... Buscar beneficios del empleado en particular.

            // ... Calculos para determinar si el empleado tiene un beneficio o no.

            return new List<dominio.Beneficio>()
            {
                new dominio.Beneficio {Nombre = "Prima extralegal 1", Valor = 2000000},
                new dominio.Beneficio {Nombre = "Prima extralegal 2", Valor = 1000000},
                new dominio.Beneficio {Nombre = "Subsidio para hijos", Valor = 500000}
            };
        }
        public class Incentivo
        {
            public List<dominio.Incentivo> ObtenerIncentivosEmpleado(string idEmpleado)
            {
                // ... Buscar incentivos otorgados al empleado con reglas de negocio.

                return new List<dominio.Incentivo>()
            {
                new dominio.Incentivo {Concepto = "Bono por cumplimiento", Valor = 200000},
                new dominio.Incentivo {Concepto = "Bono por felicitaciones del cliente", Valor = 200000}
            };
            }
            public class EmpleadoFacade
            {
                public double ObtenerTotalIngresosEmpleado(string idEmpleado)
                {
                    var nomina = new Nomina.Nomina();
                    var beneficio = new Beneficio();
                    var incentivo = new Incentivo();

                    var salario = nomina.ObtenerSalarioEmpleado(idEmpleado);
                    var totalBeneficios = beneficio.ObtenerrBeneficiosEmpleado(idEmpleado).Sum(c => c.Valor);
                    var totalIncentivos = incentivo.ObtenerIncentivosEmpleado(idEmpleado).Sum(c => c.Valor);

                    return salario + totalBeneficios + totalIncentivos;
                }
                class Program
                {
                    static void Main(string[] args)
                    {
                        Console.Write("Digite la identificación del empleado para obtener su total de ingresos ...");
                        var idEmpleado = Console.ReadLine();

                        var empleadoFacade = new EmpleadoFacade();
                        var salario = empleadoFacade.ObtenerTotalIngresosEmpleado(idEmpleado);
                        Console.Write("Los ingresos totales del empleado con identificación {0}, son: {1}", idEmpleado, salario);
                        Console.ReadLine();
                    }
                }

