using System;
using System.Collections.Generic;


namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            var sentence = " This is going to be a really, really, really, really ,really long text that will need to be summarized";
            var summary = SummarizedText(sentence);
            Console.WriteLine(summary);
          
        }
        //this method should really be in a different class.
        static string SummarizedText(string text, int maxLength = 20)
        {

            if (text.Length < maxLength)
            {
                return text;
            }
            else
            {
                var words = text.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                        break;
                }

                var summary = String.Join(" ", summaryWords) + "...";
                return summary;
            }



        }
    }
}

