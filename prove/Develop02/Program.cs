using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Demo
{   
    public class Prompt
    {
        public static void Main(String[] args)
        {
            Version _promptList = new List<string>
            _promptList.Add("Who was the most interesting person I interested with todday?");
            _promptList.Add("What was the best part of my day?");
            _promptList.Add("How did I see the hand of the Lord in my life today?");
            _promptList.Add("What was the strongest emotion I felt today?");
            _promptList.Add("If I had one thing I could do over today, what would it be?");
            
            var ramdom = new Random();
            int index = ramdom.Next(_promptList.Count);
            Console.WriteLine(_promptList[index]);

        }

    


    }

}
