namespace Saikrishna_Assignment1
{
    /// <summary>
    /// Author: Saikrishna Mantri
    /// Description: Assignment on Virtual Pet Simulator
    /// Date: 01/30/2025
    /// Version: 1.0
    /// </summary>
    internal class VirtualPetSimulator
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Welcome to VIRTUAL PET SIMULATOR PROJECT!");

            // Pet creation
            string petTypeInput;
            string petType = "Unknown";

            while (true)
            {
                Console.WriteLine("\nPlease choose a type of Pet:" +
                    "\n1. Cat" +
                    "\n2. Dog" +
                    "\n3. Rabbit");
                petTypeInput = Console.ReadLine();

                Console.WriteLine($"\nUser Input: {petTypeInput}");

                petType = petTypeInput switch
                {
                    "1" => "Cat",
                    "2" => "Dog",
                    "3" => "Rabbit",
                    _ => "Unknown"
                };

                if (petType == "Unknown")
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
                else
                {
                    Console.WriteLine($"You've chosen a {petType}.");
                    break;
                }
            }

            Console.WriteLine("\nWhat would you like to name your pet?");
            string petName = Console.ReadLine();

            Console.WriteLine($"\nWelcome, {petName} the {petType}! Let's take care of your pet.");

            // Initial stats
            int hunger = 7;
            int happiness = 7;
            int health = 7;

            bool isRunning = true;

            while (isRunning)
            {
                // Display menu
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine($"1. Feed your {petName}");
                Console.WriteLine($"2. Play with your {petName}");
                Console.WriteLine($"3. Let your {petName} rest");
                Console.WriteLine($"4. Check {petName} status");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                Console.WriteLine($"\nUser Input: {choice}");

                switch (choice)
                {
                    // Feed the pet
                    case "1":                     
                        // Reduce hunger
                        hunger = Math.Max(1, hunger - 2);
                        // Increase health
                        health = Math.Min(10, health + 1); 
                        Console.WriteLine($"\nYou fed {petName}. Hunger decreases, and health improves slightly.");
                        break;
                    // Play with the pet
                    case "2":
                        // Increase happiness
                        happiness = Math.Min(10, happiness + 2);
                        // Increase hunger
                        hunger = Math.Min(10, hunger + 1); 
                        Console.WriteLine($"\nYou played with {petName}.His Happiness increased, but he's a bit hungry.");
                        break;
                    // Let the pet rest
                    case "3":                        
                        // Increase health
                        health = Math.Min(10, health + 2);
                        // Decrease happiness
                        happiness = Math.Max(1, happiness - 1); 
                        Console.WriteLine($"\n{petName} rested. Health increased, but happiness decreased slightly.");
                        break;
                    // Check pet status
                    case "4":
                        Console.WriteLine("\nPet Status:");
                        //hunger status
                        Console.WriteLine($"Hunger: {hunger}/10");
                        //happiness status
                        Console.WriteLine($"Happiness: {happiness}/10");
                        //health status
                        Console.WriteLine($"Health: {health}/10");

                        //warning for hunger
                        if (hunger >= 8) Console.WriteLine("Warning: Your pet is very hungry!");
                        //warning for happiness
                        if (happiness <= 2) Console.WriteLine("Warning: Your pet is very unhappy!");
                        //warning for health
                        if (health <= 2) Console.WriteLine("Warning: Your pet's health is critical!");
                        break;
                    // Exit the application
                    case "5":
                        Console.WriteLine($"\nGoodbye! Thanks for playing with {petName}.");
                        isRunning = false;
                        break;
                    //Invalid choice
                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.");
                        break;
                }

                // Simulate time passing
                // Hunger increases over time
                hunger = Math.Min(10, hunger + 1);

                // Happiness decreases over time
                happiness = Math.Max(1, happiness - 1); 

                //Health decreases over time
                health = Math.Max(1, health - 1);
            }
        }
    }
}
