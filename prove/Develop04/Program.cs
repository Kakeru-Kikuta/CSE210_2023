using System;

class Program
{
    static void Main(string[] args)
    {
        int userMenuInput = 0;
        List<string> menu =new List<string>
        {
            "Menu options:",
            " 1. Start breathing activity",
            " 2. Start reflecting activity",
            " 3, Start listening activity",
            " 4. Quit"
        };

        while (userMenuInput != 4)
        {
            Console.Clear();
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("Select a choice from the menu: ");
            userMenuInput = int.Parse(Console.ReadLine();)
            Console.Clear();

            switch (userMenuInput)
            {
                case 1:
                    BreathingActivity activity = new BreathingActivity();
                    activity.runActivityParentStart();
                    break;
                case 2:
                    ReflectingActivity activity = new ReflectingActivity();
                    activity.runActivityParentStart();
                    break;
                case 3: 
                    ListningActivity activity = new ListningActivity();
                    activity.runActivityParentStart();
                    break;
                case 4: 
                    activity.runActivityParentEnd();
                    break;

            }
        }
    }
}