using System;

class Animal
{
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido");
    }
}

class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El perro ladra");
    }
}


class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El Gato hace miau");
    }
}


