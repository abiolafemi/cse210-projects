using System;
using System.Collections.Generic;
using System.IO;
namespace eternal_quest
{
    class Program
    {
        static void Main()
        {
            GoalManager goalManager = new GoalManager(); // create new goal manager
            goalManager.Start();
        }
    }
}