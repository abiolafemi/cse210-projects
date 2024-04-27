using System;

class Program
{
    static void Main(string[] args)
    {
        // Get the list of numbers from the user
		List<int> numbers = new List<int>();
		while (true)
		{
			Console.Write("Enter number: ");
			int number = Convert.ToInt32(Console.ReadLine());
			if (number == 0) break;
			numbers.Add(number);
		}

		// Compute the sum
		int sum = numbers.Sum();
		Console.WriteLine($"The sum is: {sum}");

        // Compute the average
		double average = numbers.Average();
		Console.WriteLine($"The average is: {average}");

		// Find the maximum number
		int max = numbers.Max();
		Console.WriteLine($"The largest number is: {max}");

		// Stretch Challenge: Find the smallest positive number
		int smallestPositive = numbers.Where(x => x > 0).Min();
		Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Stretch Challenge: Sort the numbers and display the sorted list
		List<int> sortedNumbers = numbers.OrderBy(x => x).ToList();
		Console.WriteLine("The sorted list is: " + string.Join(" ", sortedNumbers));



    }
}