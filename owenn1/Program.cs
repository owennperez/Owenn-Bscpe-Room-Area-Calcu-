using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            double lengthRoom, widthRoom, personArea = 0, areaRoom, numberPeople;

            Console.WriteLine("Hello Goodday, Welcome to Room Area Calculator");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter room length (in meters): ");
            lengthRoom = double.Parse(Console.ReadLine());

            Console.Write("Enter room width (in meters): ");
            widthRoom = double.Parse(Console.ReadLine());

            int choice = 0;
            while (choice < 1 || choice > 3)
            {
                //This is average size of human
                Console.WriteLine("Choose the average size of people with a small space:");
                Console.WriteLine("1. Adult men (1.00 m)");
                Console.WriteLine("2. Adult women (0.90 sq. m)");
                Console.WriteLine("3. Children (0.75 sq. m)");
                Console.Write("Enter your choice (1, 2, or 3): ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                    choice = 0; // reset choice to trigger the loop again
                }
                else
                {
                    switch (choice)
                    {
                        case 1:
                            personArea = 1.00;
                            break;
                        case 2:
                            personArea = 0.90;
                            break;
                        case 3:
                            personArea = 0.75;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                            choice = 0; //BALIK SA UMPISA
                            break;
                    }
                }
            }

            // Calculate room area and number of people
            areaRoom = lengthRoom * widthRoom;
            numberPeople = Math.Floor(areaRoom / personArea);

            Console.WriteLine($"Dear {name}, the room has an area of {areaRoom:F2} square meters.");
            Console.WriteLine($"An average of {numberPeople} people can fit in the room.");
            Console.WriteLine($"Thank you, {name}!");

            Console.Write("Do you want to enter another set of data? (Y/N) ");
            string answer = Console.ReadLine();

            if (answer.ToLower() != "y")
            {
                break;
            }
        }

        Console.WriteLine("THANKYOU FOR USING THE AREA CALCULATOR!");
    }
}