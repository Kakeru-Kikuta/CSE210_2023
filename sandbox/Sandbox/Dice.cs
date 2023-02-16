using System;
using System.Collections.Generic;

class Dice:OddEven
{
    int numberOfDices = 2;
    int minDice = 1;
    int maxDice = 6;
    public void RollDices(int numberOfDices, int minDice, int maxDice):base(int num)
    {
        var diceResultList = new List<int>();
        var rand = new Random();
        for (int i = 0; < numberOfDices; i++)
        {
            var diceResult = rand.Next(minDice, maxDice + 1);
            diceResultList.Add(diceResult);
        }

        Console.WriteLine()
    }
}

