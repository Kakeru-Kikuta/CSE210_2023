using System.Diagnostics;

class Activity
{
    private string startingMessage, endingMessage, description, activityName;
    static int spinnerCounter, userSessionLengthInput = 0;

    public Activity()
    {
        spinnerCounter = userSessionLengthInput = 0;
    }

    public void setActivityName(string _activityName)
    {
        activityName = _activityName;
    }

    public void setDescription(string _description)
    {
        description = _description;
    }

    public int getUserSeddionLengthInput()
    {
        return userSessionLengthInput;
    }

    public void displayStartingMessage()
    {
        startingMessage = string.Format("Welcome to the {0}.", activityName);
        Console.WriteLine(startingMessage);
        Console.WriteLine();
    }

    public void displayDescription()
    {
        Console.WriteLine(description);
        Console.WriteLine();
    }

    public void displayEndingMessage()
    {
        endingMessage = string.Format("You have completed another {0} seconds of the {1}",
            userSessionLengthInput, activityName);

        Console.WriteLine();
        Console.WriteLine("Well done!");
        displaySpinner(3);
        Console.WriteLine();
        Console.WriteLine(endingMessage);
        Console.WriteLine();
        displaySpinner(3);
    }
    public void displaySpinner(int numSecondsToRun)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            spinnerCounter++;
            switch (spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200); 
        }

        Console.Write(" ");
    }

    public void displayGetSeddionLength()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        userSessionLengthInput = int.Parse(Console.ReadLine());
    }

    public void displayGetReady()
    {
        Console.WriteLine("Get ready...");
        displaySpinner(5);
    }

    public void runActivityParentStart()
    {
        displayStartingMessage();
        displayDescription();
        displayGetSeddionLength();
        displayGetReady();
    }

    public void runActivityParentEnd()
    {
        displayEndingMessage();
    }
}