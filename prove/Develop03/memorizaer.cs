using System;

class Memorizer
{
    private Scripture scripture;
    private List<string> scripturteTextList;

    public Memorizer(Scripture _scripture)
    {
        scripture = _scripture;
        scripturteTextList = new List<string>();
        convertTextToList();
    }

    private void convertTextToList()
    {
        scripturteTextList = scripture.toString().Split(" ").ToList();
    }

    public void removeWordsFromText()
    {
        int unmWordsToRemove = new Random().Next(2,4);
        int wordsRemoved = 0;

        do
        {
            int rndIndex = new Random().Next(0, scripturteTextList.Count());
            scripturteTextList[rndIndex] = new string('_', scripturteTextList[rndIndex].Length);
            wordsRemoved++;

        }while (wordsRemoved != unmWordsToRemove);
    }

    public override string ToString()
    {
        return string.Join(" ", scripturteTextList);
    }

    public bool hasWordsLeft()
    {
        bool retvalue = false;

        foreach (string word in scripturteTextList)
        {
            if (word.Contains("_") == false)
            {
                retvalue = true;
                break;
            }
        }

        return retvalue;
    }
}