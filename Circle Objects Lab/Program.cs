using System;
using Circle_Objects_Lab;

List<Circle> circles = new List<Circle>();

Console.WriteLine("Welcome to the Circle Circumference and Area Calculator.");

//loop program
bool runProgram = true;
while (runProgram)
{
    double radius = 0;
    Console.Write("Please enter a radius (decimals acceptable): ");
    while (double.TryParse(Console.ReadLine(), out radius) == false)
    {
        Console.WriteLine("Not a number. Try again.");
    }
    int counter = 0;

    circles.Add(new Circle(radius));
    //Console.WriteLine($"Circle with radius {radius} added.");
    Console.Clear();
    Console.WriteLine(String.Format("{0,-15} {1,-15} {2, -15}", "Radius", "Circumference", "Area"));
    Console.WriteLine(String.Format("{0,-15} {1,-15} {2, -15}", "===========", "===========", "==========="));

    foreach (Circle c in circles)
    {
        Console.WriteLine(c.GetDetails());
        counter++;
    }
    while (true)
    {
        Console.WriteLine("Do you want to continue? y/n");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "y")
        {
            runProgram = true;
            break;
        }
        else if (choice == "n")
        {
            runProgram = false;
            Console.WriteLine($"You calculated {counter} circles. Goodbye!");
            break;
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}

Console.ReadLine();