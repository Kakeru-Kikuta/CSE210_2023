using System;

class ReflectingActivity : Activity
{
    List<string> prompt, questions;
    public ReflectingActivity() : base()
    {
        setActivityName("Reflecting Activity");

        setDescription("This activity will help you reflect on times in your life when you have" + 
         " Shown strength and resilience. This will help you recognize the power you have and how you" + 
         " can use it in other aspects of your life");

        prompt = new List<string>
        {
            "--- Think of time when you stoop up for someone else. ---",
            "--- Think of a time when you did something really difficult. ---",
            "--- Think of a time when you helped someone in need. ---",
            "--- Think of a itme when you did something truly selfless. ---"
        };

        questions = new List<string>
        {
            "Why was this experience meaningful to you? ",
            "Have you ever dine anything like this before? ",
            "How did you get started? ",
            "How did you feel when it was complete? ",
            "What mede this time difficult than other times when you were not as successful? ",
            "What is your favorite thing about this exoerience? ",
            "What could you learn form this experience that applies to other situations? ",
            "What did you learn about yourelf through this experience? ",
            "How can you keep this experience in mind in the future? "
        };    
    }

    public void runActivity()
    {
        runActivityParentStart();
        displayPrompt();
        displayCountDown(5);
        Console.Clear();
        displayQuestions();
        runActivityParentEnd();
    }

    public void displayPrompt()
    {
        Console.Clear();
        Console.WriteLine("Consider the following: ");
        Console.WriteLine();

        int randomIndex = new Random() .Next(0, prompt.Count());
        Console.WriteLine(prompt[randomIndex]);
        Console.WriteLine();

        Console.WriteLine("When you have someting in mind, press enter to continue. ");
        Console.WriteLine();

        Console.WriteLine("Now ponder on each of the following questions as thay related to this experience.");
    }

    public void displayCountDown(int numSecondsToRun)
    {
        for (int i = 1; i <= numSecondsToRun; i++)
        {
            Console.Write(string.Format("You may begun in: {0}", i));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }

    public void displayQuestions()
    {
        Console.Clear();
        Console.WriteLine("Consider the following: ");
        Console.WriteLine();

        int randomIndex = new Random() .Next(0, prompt.Count());
        Console.WriteLine(prompt[randomIndex]);
        Console.WriteLine();

    }
    
}