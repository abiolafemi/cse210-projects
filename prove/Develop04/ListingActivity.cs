using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") {}

    public override void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);

        ShowCountDown(5);
        Console.WriteLine("Start listing...");

        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        int elapsedTime = 0;
        DateTime startTime = DateTime.Now;

        while (elapsedTime < _duration)
        {
            string item = Console.ReadLine();
            userList.Add(item);
            elapsedTime = (int)(DateTime.Now - startTime).TotalSeconds;
        }

        return userList;
    }
}