using System;

namespace Ejercicio1
{
    class Empleado
    {
        public string Nombre { get; set; }
        public double Salario { get; set; }

        public Empleado(string nombre, double salario)
        {
            Nombre = nombre;
            Salario = salario;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Salario: {Salario}");
        }
    }

    class Gerente : Empleado
    {
        public Gerente(string nombre, double salario) : base(nombre, salario) { }

        public override void MostrarInformacion()
        {
            // Llamamos al método de la clase base (Empleado)
            base.MostrarInformacion();
            Console.WriteLine("Rol: Gerente");
            Console.WriteLine("Responsabilidades: Supervisar equipos y tomar decisiones estratégicas.");
        }
    }

    class Desarrollador : Empleado
    {
        public Desarrollador(string nombre, double salario) : base(nombre, salario) { }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Rol: Desarrollador");
            Console.WriteLine("Responsabilidades: Escribir código y mantener el software.");
        }
    }
}
