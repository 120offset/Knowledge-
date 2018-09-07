using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalFarm;


namespace FarmConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateFarm();
        }
        static void CreateFarm()
        {
            Console.WriteLine("You're going to create a farm with this program.");
            Console.WriteLine("Your farm will have four animals. They include:");
            Console.WriteLine("\nA chicken\ncow\nrabbit\nand goat\n");

            Console.WriteLine("Let's start off with the chicken first");
            Console.ReadLine();

            Chicken chicken = new Chicken("Charlie", 2, "seeds", "cluck");
            {
                Console.WriteLine($"\nYour chicken's name is {chicken.ChickenName}");
                Console.WriteLine($"{chicken.ChickenName} is {chicken.ChickenAge} years old");
                Console.WriteLine($"{chicken.ChickenName} likes to eat {chicken.ChickenFood}");
                Console.WriteLine($"{chicken.ChickenName} makes a {chicken.ChickenSound} sound");
            };

            Console.WriteLine("\nNow on to your cow");
            Console.ReadLine();

            Cow cow = new Cow("Bessie", 10, "grass", "MOOOO");
            {
                Console.WriteLine($"\nYour cow's name is {cow.CowName}");
                Console.WriteLine($"{cow.CowName} is {cow.CowAge} years old");
                Console.WriteLine($"{cow.CowName} likes to eat {cow.CowFood}");
                Console.WriteLine($"{cow.CowName} makes a {cow.CowSound} sound");
            };

            Console.WriteLine("\nWhat about your rabbit...");
            Console.ReadLine();

            Rabbit rabbit = new Rabbit("Roger", 11, "pizza with carrots", "What's up Doc!");
            {
                Console.WriteLine($"\nYour rabbit's name is {rabbit.RabbitName}");
                Console.WriteLine($"{rabbit.RabbitName} is {rabbit.RabbitAge} years old");
                Console.WriteLine($"{rabbit.RabbitName} likes to eat {rabbit.RabbitFood}");
                Console.WriteLine($"{rabbit.RabbitSound} is {rabbit.RabbitName}'s favorite thing to say");
            };

            Console.WriteLine("\nAnd finally, your lucky goat");
            Console.ReadLine();

            Goat goat = new Goat("Billy", 50, "vegan cheesecake", "Bahhh");
            {
                Console.WriteLine($"\n{goat.GoatName} is your goat's name");
                Console.WriteLine($"He's an old goat! He's {goat.GoatAge}");
                Console.WriteLine($"All he eats is {goat.GoatFood}");
                Console.WriteLine($"Around the farm you can hear him say {goat.GoatSound}!");
            };




            Console.WriteLine("\n\nHope you had fun today looking around your farm! ");
            Console.ReadLine();
            Environment.Exit(0);




        }
    }
}
