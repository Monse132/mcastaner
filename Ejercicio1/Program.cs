using System;

namespace Ejercicio1
{
    class CuentaBancaria
    {
        private string nombre;
        private double saldo;

        public CuentaBancaria(string nombre, double saldo)
        {
            this.nombre = nombre;
            this.saldo = saldo;
        }

        public void Depositar(double cantidad)
        {
            saldo += cantidad;
            Console.WriteLine($"Se ha depositado {cantidad} en la cuenta de {nombre}. Saldo actual: {saldo}");
        }

        public void Retirar(double cantidad)
        {
            if (cantidad > saldo)
            {
                Console.WriteLine($"No se puede retirar {cantidad}. Saldo insuficiente.");
            }
            else
            {
                saldo -= cantidad;
                Console.WriteLine($"Se ha retirado {cantidad} de la cuenta de {nombre}. Saldo actual: {saldo}");
            }
        }

        public void ObtenerSaldo()
        {
            Console.WriteLine($"El saldo de la cuenta de {nombre} es: {saldo}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Encapsulamiento
            Console.WriteLine($"Encapsulamiento:");

            CuentaBancaria cuenta = new CuentaBancaria("Juan", 1000);
            cuenta.ObtenerSaldo();
            cuenta.Depositar(800);
            cuenta.Retirar(200);
            cuenta.Retirar(800);
            cuenta.Retirar(5000); // Saldo insuficiente
            cuenta.ObtenerSaldo();

            //Herencia y Sobrescritura
            Console.WriteLine($"Herencia y Sobrescritura");

            Empleado empleado = new Empleado("Juan", 3000);
            empleado.MostrarInformacion();
            Console.WriteLine();
            Gerente gerente = new Gerente("Maria", 5000);
            gerente.MostrarInformacion();
            Console.WriteLine();
            Desarrollador desarrollador = new Desarrollador("Carlos", 4000);
            desarrollador.MostrarInformacion();

            //CALCULADORA
            Calculadora calc = new Calculadora();
            int resultado1 = calc.Sumar(5, 10); // 2 enteros
            int resultado2 = calc.Sumar(5, 10); // 2 enteros
            double resultado3 = calc.Sumar(2.6, 5.9); // 2 decimales
            Console.WriteLine($"Calculadora:");
            Console.WriteLine($"Suma de 5 + 10 = {resultado1}");
            Console.WriteLine($"Suma de 1 + 2 + 3 = {resultado2}");
            Console.WriteLine($"Suma de 4.5 + 3.2 = {resultado3}");


            // FIGURAS
            Console.WriteLine($"Figuras:");
            Figura figura1 = new Cuadrado(4);

            Figura figura2 = new Triangulo(5, 3);

            figura1.calcularArea();

            figura2.calcularArea();

            // – Interfaces y Polimorfismo
            Console.WriteLine($"Interfaces y Polimorfismo:");
            Animal miAnimal = new Animal();
            miAnimal.HacerSonido();

            Animal miPerro = new Perro();
            miPerro.HacerSonido();

            Animal miGato = new Gato();
            miGato.HacerSonido();  
        }
    }
}
