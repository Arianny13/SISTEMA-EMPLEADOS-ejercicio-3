using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_EMPLEADOS
{
    internal class Empleado
    {        
        public string Nombre { get; set; }
        public decimal Salario { get; set; }
        public string Departamento { get; set; }

        // Constructor de la clase base
        public Empleado(string nombre, double salario, string departamento)
        {
            Nombre = nombre;
            Salario = salario;
            Departamento = departamento;
        }

        // Método para imprimir información del empleado
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Salario: {Salario}, Departamento: {Departamento}");
        }

    }
}
