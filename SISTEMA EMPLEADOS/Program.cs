namespace SISTEMA_EMPLEADOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado("Juan", 30000, "Recursos Humanos");
            empleado1.MostrarInformacion();

            Gerente gerente1 = new Gerente("Maria", 50000, "Ventas", "Gerente de Ventas");
            gerente1.MostrarInformacion();

            Trabajador trabajador1 = new Trabajador("Pedro", 20000, "Producción", 160);
            trabajador1.MostrarInformacion();
        }
    }
}
