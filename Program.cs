using System;
using Dotnet.Entities;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona Hero = new Persona("Raster", "Knight", 15);
            Persona Enemy = new Persona("Gladius", "Killer", 30);
            
            Console.WriteLine($"The name is {Hero}");
            Console.WriteLine($"The name is {Enemy}");
            Console.WriteLine(Hero.Attack());
        }
    }
}
