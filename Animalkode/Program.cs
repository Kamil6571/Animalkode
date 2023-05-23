using System;
using System.Collections.Generic;

public interface IPerson
{
    void create();
}

public class Animal : IPerson
{
    public int Id { get; set; }
    public string Color { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }

    public void create()
    {
        Console.WriteLine("This is an Animal");
    }

    public void DisplayAnimalDetails()
    {
        Console.WriteLine($"╔═════════════════════════════╗");
        Console.WriteLine($"║        Animal: {Name}           ║");
        Console.WriteLine($"║        ID: {Id}                ║");
        Console.WriteLine($"║        Color: {Color}          ║");
        Console.WriteLine($"║        Age: {Age}              ║");
        Console.WriteLine($"╚═════════════════════════════╝");
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        List<Animal> animalList = new List<Animal>()
        {
            new Animal() { Id = 1, Age = 5, Color = "red", Name = "Hansi" },
            new Animal() { Id = 2, Age = 15, Color = "blue", Name = "Bo" },
            new Animal() { Id = 3, Age = 25, Color = "yellow", Name = "Søren" },
            new Animal() { Id = 4, Age = 95, Color = "red", Name = "Søren" }
        };
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("==== Menu ====");
        Console.WriteLine("1. Vis alle dyr");
        Console.WriteLine("2. Vis kun det blå dyr");
        Console.WriteLine("==============");
        Console.WriteLine();

        Console.Write("Vælg en mulighed: ");
        string choice = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Red;

        switch (choice)
        {
            case "1":
                Console.WriteLine("=== Alle dyr ===");
                foreach (Animal animal in animalList)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    animal.DisplayAnimalDetails();
                }
                break;

            case "2":
                Console.WriteLine("=== Blå dyr ===");
                foreach (Animal animal in animalList)
                {
                    if (animal.Color == "blue")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        animal.DisplayAnimalDetails();
                    }
                }
                break;

            default:
                Console.WriteLine("Ugyldig mulighed.");
                break;
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Press Enter to exit...");
        Console.WriteLine("═══════════════════════");
        Console.ReadLine();
    }
}
