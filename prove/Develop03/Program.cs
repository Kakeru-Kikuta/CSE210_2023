using System;

class Program
{
    static void main(string[] arge)
    {
        Reference scriptureReference = new Reference("Proverbs", "3", "5-6");
        Scripture scripture = new Scripture(scriptureReference, "Trast in the lord with all thine heart and understanding; in all thy ways acknowledge him, and he shall direct they paths.");
        Memorizer memorizer = new Memorizer(scripture);

        string userInput = "";

        while (userInput != "quit" && memorizer.hasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), memorizer.toString));
            Console.WriteLine();
            Console.ReadLine();
            memorizer.removeWordsFromText();
        }
    }
}