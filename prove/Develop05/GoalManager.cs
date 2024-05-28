using System;
using System.Collections.Generic;
using System.IO;

namespace eternal_quest
{
    class GoalManager
    {
        private int _score;
        private List<Goal> _goals;

        public GoalManager()
        {
            _score = 0;
            _goals = new List<Goal>();
        }

        public void Start()
        {
            int choice;

            do
            {
                DisplayMenu();
                Console.Write("Enter your choice (1-6): ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine();
                    HandleMenuChoice(choice);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number (1-6).");
                }

            } while (choice != 6);
        }

        private void DisplayMenu() // display menu
        {
            Console.WriteLine("Eternal Quest Menu");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
        }

        private void HandleMenuChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;

                case 2:
                    ListGoalDetails();
                    break;

                case 3:
                    SaveGoals();
                    break;

                case 4:
                    LoadGoals();
                    break;

                case 5:
                    RecordEvent();
                    break;

                case 6:
                    Console.WriteLine("Exiting program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a number from 1 to 6.");
                    break;
            }

            Console.WriteLine();
        }

        private void CreateGoal() // create goal
        {
            Console.WriteLine("Choose the type of goal:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Enter your choice (1-3): ");

            if (int.TryParse(Console.ReadLine(), out int goalTypeChoice))
            {
                switch (goalTypeChoice)
                {
                    case 1:
                        CreateSimpleGoal();
                        break;

                    case 2:
                        CreateEternalGoal();
                        break;

                    case 3:
                        CreateChecklistGoal();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a number from 1 to 3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number (1-3).");
            }
        }

        private void CreateSimpleGoal()
        {
            Console.Write("Enter short name for the goal: ");
            string shortName = Console.ReadLine();

            Console.Write("Enter description for the goal: ");
            string description = Console.ReadLine();

            do
            {
                Console.Write("Enter points for the goal: ");
                if (int.TryParse(Console.ReadLine(), out int points))
                {
                    Goal simpleGoal = new SimpleGoal(shortName, description, points);
                    _goals.Add(simpleGoal);
                    Console.WriteLine("Simple Goal created successfully.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input for points. Please enter a valid number.");
                }

            } while (true);
        }

        private void CreateEternalGoal()
        {
            Console.Write("Enter short name for the goal: ");
            string shortName = Console.ReadLine();

            Console.Write("Enter description for the goal: ");
            string description = Console.ReadLine();

            do
            {
                Console.Write("Enter points for the goal: ");
                if (int.TryParse(Console.ReadLine(), out int points))
                {
                    Goal eternalGoal = new EternalGoal(shortName, description, points);
                    _goals.Add(eternalGoal);
                    Console.WriteLine("Eternal Goal created successfully.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input for points. Please enter a valid number.");
                }
            } while (true);
        }

        private void CreateChecklistGoal()
        {
            Console.Write("Enter short name for the goal: ");
            string shortName = Console.ReadLine();

            Console.Write("Enter description for the goal: ");
            string description = Console.ReadLine();

            do
            {
                Console.Write("Enter points for the goal: ");
                if (int.TryParse(Console.ReadLine(), out int points))
                {
                    do
                    {
                        Console.Write("Enter target for the checklist: ");
                        if (int.TryParse(Console.ReadLine(), out int target))
                        {
                            do
                            {
                                Console.Write("Enter bonus for completing the checklist: ");
                                if (int.TryParse(Console.ReadLine(), out int bonus))
                                {
                                    Goal checklistGoal = new ChecklistGoal(shortName, description, points, target, bonus);
                                    _goals.Add(checklistGoal);
                                    Console.WriteLine("Checklist Goal created successfully.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input for bonus. Please enter a valid number.");
                                }
                            } while (true);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for target. Please enter a valid number.");
                        }
                    } while (true);


                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input for points. Please enter a valid number.");
                }
            } while (true);
        }

        private void ListGoalDetails()
        {
            string undoneStatus = "[ ]";
            string doneStatus = "[X]";



            Console.WriteLine("List of Goals:");

            int index = 1;
            int totalScore = 0;

            foreach (var goal in _goals)
            {
                totalScore += goal.GetCurrentScore();
                string goalStatus = goal.IsComplete() ? doneStatus : undoneStatus;
                Console.WriteLine($"{index}. {goalStatus} {goal.GetDetailsString()}");
                index++;
            }
            _score = totalScore;
            Console.WriteLine($"\nTotal Score: {_score}");
        }

        private void SaveGoals()
        {
            Console.Write("Enter the name of the file to save goals: ");
            string fileName = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (var goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }

            Console.WriteLine("Goals saved successfully.");
        }

        private void LoadGoals()
        {
            do
            {
                Console.Write("Enter the name of the file to load goals: ");
                string fileName = Console.ReadLine();

                if (File.Exists(fileName))
                {
                    _goals.Clear();

                    string[] lines = File.ReadAllLines(fileName);

                    foreach (string line in lines)
                    {
                        CreateGoalFromString(line);
                    }

                    Console.WriteLine("Goals loaded successfully.");
                    break;
                }
                else
                {
                    Console.WriteLine("File not found. No goals loaded.");
                }
            } while (true);
        }

        private void CreateGoalFromString(string goalString)
        {
            Console.WriteLine(goalString);

            string[] parts = goalString.Split(',');

            if (parts.Length < 4)
            {
                Console.WriteLine($"Invalid format for goal string: {goalString}");
                return;
            }

            string[] goalTypeAndShortName = parts[0].Split(':');


            int.TryParse(parts[parts.Length - 1], out int currentScore);

            string goalType = goalTypeAndShortName[0];
            string shortName = goalTypeAndShortName[1];
            string description = parts[1];
            bool status = parts[3] == "True";

            if (int.TryParse(parts[2], out int points))
            {
                switch (goalType)
                {
                    case nameof(SimpleGoal):
                        _goals.Add(new SimpleGoal(shortName, description, points, status, currentScore));
                        break;

                    case nameof(EternalGoal):
                        _goals.Add(new EternalGoal(shortName, description, points, currentScore));
                        break;

                    case nameof(ChecklistGoal):

                        if (int.TryParse(parts[3], out int amountCompleted) &&
                            int.TryParse(parts[4], out int target) &&
                            int.TryParse(parts[5], out int bonus))
                        {
                            ChecklistGoal checklistGoal = new ChecklistGoal(shortName, description, points, target, bonus, currentScore);
                            checklistGoal._amountCompleted = amountCompleted; // Set the amountCompleted
                            _goals.Add(checklistGoal);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid format for checklist goal string: {goalString}");
                        }
                        break;

                    default:
                        Console.WriteLine($"Unknown goal type: {goalType}");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"Invalid format for points: {parts[3]}");
            }
        }

        private void RecordEvent()
        {
            Console.WriteLine("Choose the goal to record an event for:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }

            Console.Write("Enter your choice (1-{0}): ", _goals.Count);

            if (int.TryParse(Console.ReadLine(), out int goalChoice) && goalChoice >= 1 && goalChoice <= _goals.Count)
            {
                Goal selectedGoal = _goals[goalChoice - 1];

                if (selectedGoal._goalType == "eternalGoal")
                {
                    int newScore = selectedGoal.GetCurrentScore() + selectedGoal._points;
                    selectedGoal.SetCurrentScore(newScore);
                }
                else if (selectedGoal._goalType == "checkListGoal")
                {
                    selectedGoal.RecordEvent();

                    if (selectedGoal.IsComplete())
                    {
                        selectedGoal.SetCurrentScore(selectedGoal.GetCurrentScore() + selectedGoal.GetBonus());
                        Console.WriteLine($"\nHurray! You received {selectedGoal.GetBonus()} bonus points!");
                    }
                    else
                    {
                        selectedGoal.SetCurrentScore(selectedGoal.GetCurrentScore());
                    }

                }
                else
                {
                    selectedGoal.RecordEvent();
                    selectedGoal.SetCurrentScore(selectedGoal._points);
                }


                Console.WriteLine("Event recorded successfully.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a number from 1 to {0}.", _goals.Count);
            }
        }
    }
}