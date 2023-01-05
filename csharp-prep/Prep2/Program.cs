using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program shows your grade. Enter your grade percentage.");
        string enterdGrade = Console.ReadLine();
        int grade = int.Parse (enterdGrade);

        string output = "";

        if (grade >= 90)
        {
            output = "A";
        }
        else if (grade >= 80)
        {
            output = "B";
        }
        else if (grade >= 70)
        {
            output = "C";
        }
        else if (grade >= 60)
        {
            output = "D";
        }
        else
        {
            output = "F";
        }

        Console.WriteLine($"Your grade is: {output}");
        
        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}