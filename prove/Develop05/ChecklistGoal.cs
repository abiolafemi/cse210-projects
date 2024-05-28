using System;
using System.Collections.Generic;
using System.IO;

namespace eternal_quest
{
    class ChecklistGoal : Goal
    {
        public int _amountCompleted; // number of times the goal has been completed
        private int _target;
        private int _bonus;

        public ChecklistGoal(string shortName, string description, int points, int target, int bonus, int currentScore = 0) : base(shortName, description, points, "checkListGoal", currentScore)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }

        public override void RecordEvent() // record event
        {
            _amountCompleted++;

            int newSore = _amountCompleted * _points;

            SetCurrentScore(newSore);
        }

        public override int GetBonus()
        {
            return _bonus;
        }

        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }

        public override string GetDetailsString()
        {
            return $"{_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
        }

        public override string GetStringRepresentation()
        {
            return $"{nameof(ChecklistGoal)}:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus},{GetCurrentScore()}";
        }
    }
}