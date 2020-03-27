using System;

namespace EjemploAves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Aves aguila = new Aguila() as Aguila;
            Aves pinguino = new Pinguino();
            
            
        }
    }
}
