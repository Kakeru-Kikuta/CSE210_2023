using System;

class Program
{
    static void Main(string[] args)
    {
        int menuUserentry = 0;
        while (menuUserentry != 2)
        {
            Menu menu = new Menu();
            menu.DsiplayMenu();
            menuUserentry = menu.DisplayGetMenu();

            TimeCounter num = new TimeCounter();

            Dice rollDice = new Dice();


            if (menuUserentry == 2)
            {
                break;
            }

            Console.WriteLine ("Thank you for playing.");
        }    

        
    }
}