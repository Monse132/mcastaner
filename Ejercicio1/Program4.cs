using System;

namespace Ejercicio1
{
    // Clase base abstracta
    abstract class Figura
    {
        // Método abstracto sin implementación
        public abstract void calcularArea();
    }

    class Cuadrado : Figura
    {
        public double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public override void calcularArea()
        {
            Console.WriteLine($"El área del cuadrado es: {lado * lado}");
        }
    }

    class Triangulo : Figura
    {
        public double baseTriangulo;
        public double altura;

        public Triangulo(double baseTriangulo, double altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }

        public override void calcularArea()
        {
            Console.WriteLine($"El área del triángulo es: {(baseTriangulo * altura) / 2}");
        }
    }
}   