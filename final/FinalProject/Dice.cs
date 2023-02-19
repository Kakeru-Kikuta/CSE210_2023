using System;
using System.Collections.Generic;

class Dice : OddEven
{
    int numberOfDices = 2;
    int minDice = 1;
    int maxDice = 6;
    public void rollDices(int numberOfDices, int minDice, int maxDice) : base()
    {
        var diceResultList = new List<int>();
        var rand = new Random();
        for (int i = 0, < numberOfDices; i++)
        {
            var diceResult = rand.Next(minDice, maxDice + 1);
            diceResultList.Add(diceResult);
        }
        
        num = diceResult;
        base.IsEven(num);
        if (diceResult == 0)
        {
            Console.Write("丁 / Even");
        }
        if (diceResult != 0)
        {
            Console.Write("半 / Odd");
        }


    }
}

