using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture object (e.g., John 3:16)
        var reference = new Reference("John", 3, 16);
        var scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        // Main loop for hiding words until scripture is completely hidden
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");

            string input = Console.ReadLine()?.ToLower();
            if (input == "quit")
                break;

            // Hide random words each time the user presses Enter
            scripture.HideRandomWords(3); // Example: Hide 3 words at a time
        }

        Console.WriteLine("You've hidden all words in the scripture. Press any key to exit.");
        Console.ReadKey();
    }
}