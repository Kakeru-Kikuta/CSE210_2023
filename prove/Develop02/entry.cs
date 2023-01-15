using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace entryCode
{
    public class entry
    {
        static void Main(string[] args)
        {
            Console.Write("Current Date and Time is: ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.ReadLine();

        }

        string fileName = "journal_history.txt";
        string journal_entry = outputFile.ReadLine();
        public static async Task journalEmtry()
        {
            string entry = WriteLine($"{journal_entry}");
            using StreamWriter file = new("WirteLine2.txt", append:true);
            await file.WriteLineAsync("Fourth line");
        }
    }
}
