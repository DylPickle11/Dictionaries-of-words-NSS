using System;
using System.Collections.Generic;

namespace DictionariesOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "I am excited to learn C#!");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);

            // create another Dictionary and add that to the list
            Dictionary<string, string> musicWord = new Dictionary<string, string>();
            musicWord.Add("word", "rubato");
            musicWord.Add("definition", "The temporary disregarding of strict tempo to allow an expressive quickening or slackening, usually without altering the overall pace.");
            musicWord.Add("part of speech", "noun");
            musicWord.Add("example sentence", "The Chopin pieces typically require use of rubato");
            dictionaryOfWords.Add(musicWord);

            dictionaryOfWords.ForEach(dict =>
            {
                foreach (KeyValuePair<string, string> wordData in dict)
                {
                    Console.WriteLine($"{wordData.Key}: {wordData.Value}");
                }
            });

            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            //Iterate the List of Dictionaries
            //foreach (List<Dictionary<string, string>> dict in dictionaryOfWords)
            {
                // Iterate the KeyValuePairs of the Dictionary
                // foreach ()
                // {
                //     Console.WriteLine($"{wordData.Key}: {wordData.Value}");
                // }
            }
        }
    }
}