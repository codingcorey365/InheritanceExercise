using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // DONE:  Be sure to follow best practice when creating your classes

            // DONE: Create a class Animal
            // DONE: give this class 4 members that all Animals have in common


            // DONE: Create a class Bird
            // DONE: give this class 4 members that are specific to Bird
            // DONE: Set this class to inherit from your Animal Class

            // DONE: Create a class Reptile
            // DONE: give this class 4 members that are specific to Reptile
            // DONE: Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird bird1 = new Bird();
            bird1.CanFly = true;
            bird1.IsNocturnal = true;
            bird1.HasHollowBones = true;
            bird1.HasFeathers = true;
            bird1.HasColor = true;
            bird1.HasDiet = true;
            bird1.IsMale = true; 
            bird1.MakesNoise = true;

            Console.WriteLine($"The first object bird, is bird1.");
            Console.WriteLine($"Can bird1 fly? It is {bird1.CanFly} that bird1 flys.");
            Console.WriteLine($"Is bird1 nocturnal? It is {bird1.IsNocturnal} that bird1 is nocturnal.");
            Console.WriteLine($"Does bird1 have hollow bones? It is {bird1.HasHollowBones} that bird1 has hollow bones.");
            Console.WriteLine($"Does bird1 have feathers? It is {bird1.HasFeathers} that bird1 has feathers.");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile reptile1 = new Reptile();
            reptile1.CanShed = true;
            reptile1.ColdBlooded = true;
            reptile1.HasScales = true;
            reptile1.HasLungs = true;
            reptile1.HasColor = true;
            reptile1.HasDiet = true;
            reptile1.IsMale = true;
            reptile1.MakesNoise = true;

            Console.WriteLine($"The first object reptile, is reptile 1");
            Console.WriteLine($"Can reptile1 shed? It is {reptile1.CanShed} that reptile1 can shed.");
            Console.WriteLine($"Is reptile1 coldblooded? It is {reptile1.ColdBlooded} that reptile1 is coldblooded.");
            Console.WriteLine($"Does reptile1 have scales? It is {reptile1.HasScales} that reptile1 has scales.");
            Console.WriteLine($"Does reptile1 have lungs. It is {reptile1.HasLungs} that reptile1 has lungs.");
        }
    }
}
