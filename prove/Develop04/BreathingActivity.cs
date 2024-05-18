using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") {}


    public override void Run()
    {
        DisplayStartingMessage();

        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            elapsedTime += 4;

            Console.WriteLine("Breathe Out...");
            ShowCountDown(4);
            elapsedTime += 4;
        }

        DisplayEndingMessage();
    }
}