using System;
using System.Collections.Generic;
using System.IO;

namespace eternal_quest
{
    class EternalGoal : Goal
    {
        public EternalGoal(string shortName, string description, int points, int currentScore = 0) : base(shortName, description, points, "eternalGoal", currentScore)
        {
            // Implementation for initializing eternalGoal
        }

        public override void RecordEvent() { }
        public override int GetBonus() { return 0; }

        public override bool IsComplete()
        {
            // Implementation for checking completion status of EternalGoal
            return false;
        }

        public override string GetDetailsString() // Implementation for getting details of eternalGoal
        {
            return $"{_shortName} ({_description})";
        }

        public override string GetStringRepresentation()
        {
            return $"{nameof(EternalGoal)}:{_shortName},{_description},{_points},{GetCurrentScore()}";
        }
    }
}