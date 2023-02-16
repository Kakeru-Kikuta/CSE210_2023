using System;

class Menu
{
    private List<string> menu;
    private int menuUserentry;

    public Menu()
    {
        menu = new List<string>
        {
            "MENU:",
            "   1. Start",
            "   2. QUIT"
        };
    }

    public void DsiplayMenu()
    {
        foreach (string menuItem in menu)
        {
            Console.WriteLine(menuItem);
        }
    }

    public int DisplayGetMenu()
    {
        Console.Write("Select a choice from the menu: ");
        return int.Parse(Console.ReadLine());
    }

    public int GetMainMenuSelectoin()
    {
        return menuUserentry;
    }
}