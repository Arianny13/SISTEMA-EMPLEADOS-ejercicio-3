using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_EMPLEADOS
{
    internal class Trabajador:Empleado
    {
        public int HorasTrabajadas { get; set; }

        // Constructor de la clase Trabajador
        public Trabajador(string nombre, double salario, string departamento, int horasTrabajadas)
            : base(nombre, salario, departamento)
        {
            HorasTrabajadas = horasTrabajadas;
        }

        // Método MostrarInformacion para incluir las horas trabajadas del trabajador
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Salario: {Salario}, Departamento: {Departamento}, Horas Trabajadas: {HorasTrabajadas}");
        }
    }
}
