using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for their grade percentage
        Console.Write("Input your grade percentage: ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        // Print the letter grade
        Console.WriteLine($"Your grade is: {letter}");

       // Check if the user passed the course and display a message accordingly
       if (gradePercentage >= 70)
       {
        Console.WriteLine("Congratulations! You passed the course.");
       }
       else
       {
        Console.WriteLine("Keep working hard for next time!");
       }
    }

    
}