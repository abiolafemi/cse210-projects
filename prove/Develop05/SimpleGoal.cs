using System;
using System.Collections.Generic;
using System.IO;

namespace eternal_quest
{
    class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string shortName, string description, int points, bool status = false, int currentScore = 0) : base(shortName, description, points, "simpleGoal", currentScore)
        {
            _isComplete = status;
        }

        public override void RecordEvent()
        {
            _isComplete = true;

        }

        public override int GetBonus() { return 0; }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetDetailsString()
        {
            return $"{_shortName} ({_description})";
        }

        public override string GetStringRepresentation()
        {
            return $"{nameof(SimpleGoal)}:{_shortName},{_description},{_points},{_isComplete},{GetCurrentScore()}";
        }
    }
}