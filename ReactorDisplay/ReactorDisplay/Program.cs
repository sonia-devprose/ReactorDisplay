using System;

namespace ReactorDisplay

{
    class Program

    {
        static void Main (string[] args)
        {
            // Prompt the user to enter the reactor core temperature
            Console.WriteLine("Enter the reactor core temperature: ");

            // Read the core temperature as a float (allows for decimal values)
            float temp = float.Parse(Console.ReadLine());

            // Display the core temperature entered by the user

            Console.WriteLine("The core temperature is: " + temp);

            // Prompt the user to enter the radiation level in the reactor

            Console.WriteLine("Enter the radiation level: ");

            // Read the radiation level as a double (allows for more precision in decimal values)
            float level = float.Parse(Console.ReadLine());

            // Display the radiation level entered by the user

            Console.WriteLine("The radiation level is: " + level);

            // Ask the user if the reactor is operational (expects a boolean response: true/false)
            Console.WriteLine("Is the reactor operational (true/false): ");

            // Read the operational status as a boolean (true or false)
            string status = Console.ReadLine();

            // Display whether the reactor is operational, showing yes/no based on user input

            if (status == "yes")
            {
                Console.WriteLine("The reactor is operational.");

            }

            else
            {

                Console.WriteLine("The reactor is not operational.");
            }
            


        }





    }






}
