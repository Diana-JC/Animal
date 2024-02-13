using System;

// Clase base
class Animal
{
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido genérico.");
    }
}

// Clases derivadas
class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El perro ladra: ¡Guau, guau!");

    }
}

class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El gato maulla: ¡Miau, miau!");

 
    }
}

class Program
{
    static void Main()
    {
        // Crear instancias de las clases derivadas
        Perro miPerro = new Perro();
        Gato miGato = new Gato();

     

        Console.WriteLine("\nMi perro:");
        miPerro.HacerSonido();

        Console.WriteLine("\nMi gato:");
        miGato.HacerSonido();
    }
}