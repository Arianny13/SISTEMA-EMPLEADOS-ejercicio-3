using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_EMPLEADOS
{
    internal class Gerente:Empleado
    {
        public string Cargo { get; set; }

        // Constructor de la clase Gerente
        public Gerente(string nombre, double salario, string departamento, string cargo)
            : base(nombre, salario, departamento)
        {
            Cargo = cargo;
        }

        // Método MostrarInformacion para incluir el cargo del gerente
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Salario: {Salario}, Departamento: {Departamento}, Cargo: {Cargo}");
        }
    }
}
