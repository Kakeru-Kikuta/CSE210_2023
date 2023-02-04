
class AllGoals
{
    private List<Goal> allGoals = new List<Goal>();
    private int totalPoints;

    public int getTotalPoint()
    {
        return totalPoints;
    }
    public void addGoal(Goal _goal)
    {
        allGoals.Add(Goal _goal);
    }

    public void DisplayGoals()
    {
        if (allGoals.Count() == 0)
        {
            Console.WriteLine("No goals have been created or loaded.");
        }
        foreach (Goal goal in allGoals)
        {
            Console.WriteLine(goal.ToString());
        }
    }

    public void SaveGoals()
    {
        if (allGoals.Count() == 0)
        {
            Console.WriteLine("There are no goals to save.");
            return;
        }

        string fileToSave = DisplayGetGoalFile();
        List<string> saveGoal = new List<string>();
        saveGoal.Add(totalPoints.ToString());

        foreach (Goal goal in allGoals)
        {
            saveGoal.Add(goal.toCSVRecord());
        }

        SaveLoadCSV.SaveToCSV(saveGoal, fileToSave);

        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals(string _filePath = "")
    {
        List<string> fileGoals;
        if (File.Exists(_filePath))
        {
            fileGoals  = SaveLoadCSV.LoadFromCSV(_filePath);
        }
        else
        {
            fileGoals = SaveLoadCSV.LoadFromCSV(DisplayGetGoalFile());
        }
        Goal goal = null;
        foreach (string goalInFile in fileGoals)
        {
            string[] goalParts = goalInFile.Split("|");
            int goalType = int.Parse(goalParts[0]);
            switch (goalType)
            {
                case 1:
                    goal = new SimpleGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]),
                        bool.Parse(goalParts[4]));
                    break;
            }

            if (goal != null && allGoals.Contains(goal) == false)
            {
                allGoals.Add(goal);
            }
        }
        Console.WriteLine("\nGoals loaded.\n");
    }

    public string DisplayGetGoalFile()
    {
        Console.Write("Waht is the filename for the goal file? ");
        return Directory.GetCurrentDirectory() + "\\Files\\" + Console.ReadLine();
    }

    public void DisplayGoalsRecordEvent()
    {
        Console.WriteLine("The goals are: ");
        foreach (Goal goal in allGoals)
        {
            Console.WriteLine(string.Format("{0} {1}", allGoals.IndexOf(goal) + 1, goal.getGoalName()));
        }

        Console.Write("Which goal did you accomplish? ");
        int RecordEcent = int.Parse(Console.ReadLine()) - 1;
        allGoals[RecordEcent].RecordEvent();
        totalPoints += allGoals[RecordEcent].getGoalPoint();

        Console.WriteLine(string.Format("You now have {0} points. ", totalPoints.ToString()));
    }
}