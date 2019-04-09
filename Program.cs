using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
        Dictionary<string, string> stocks = new Dictionary<string, string>();
        stocks.Add("GM", "General Motors");
        stocks.Add("CAT", "Caterpillar");
        // Add a few more of your favorite stocks
        stocks.Add("PAT", "Patriots");
        stocks.Add("GE", "General Electric");

        List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();
        purchases.Add (new Dictionary<string, double>(){ {"GE", 230.21} });
        purchases.Add (new Dictionary<string, double>(){ {"GE", 580.98} });
        purchases.Add (new Dictionary<string, double>(){ {"GE", 406.34} });
        purchases.Add (new Dictionary<string, double>(){ {"GM", 406.34} });
        purchases.Add (new Dictionary<string, double>(){ {"PAT", 578.98} });
        purchases.Add (new Dictionary<string, double>(){ {"CAT", 600.59} });

        /*
    Define a new Dictionary to hold the aggregated purchase information.
    - The key should be a string that is the full company name.
    - The value will be the total valuation of each stock


    From the three purchases above, one of the entries
    in this new dictionary will be...
        {"General Electric", 1217.53}

    Replace the questions marks below with the correct types.
*/
        Dictionary<string, double> stockReport = new Dictionary<string, double>();

        /*
        Iterate over the purchases and record the valuation
        for each stock.
        */
        foreach (Dictionary<string, double> purchase in purchases)
        {
            foreach (KeyValuePair<string, double> stock in purchase)
            {
                // Does the full company name key already exist in the `stockReport`?
                if (stockReport.ContainsKey(stocks[stock.Key]))
                {
                // If it does, update the total valuation
                    stockReport[stocks[stock.Key]] += stock.Value;
                } else
                {
                /*
                    If not, add the new key and set its value.
                    You have the value of "GE", so how can you look
                    the value of "GE" in the `stocks` dictionary
                    to get the value of "General Electric"?
                */
                    stockReport.Add(stocks[stock.Key], stock.Value);
                }

                foreach(KeyValuePair<string, double> item in stockReport)
                {
                    Console.WriteLine($"The position in {item.Key} is worth ${item.Value}");
                    // Console.WriteLine($"The position in {item.Key} is worth ${item.Value.ToString()}");
                }


    }
}
                List<string> planetList = new List<string>()
                {
                    "Mercury",
                    "Venus",
                    "Earth",
                    "Mars",
                    "Jupiter",
                    "Saturn",
                    "Uranus",
                    "Neptune",
                };

                List<Dictionary<string, string>> planetProbes = new List<Dictionary<string, string>>();
                planetProbes.Add(new Dictionary<string, string>() { {"Mercury", "Mariner 10" } });
                planetProbes.Add(new Dictionary<string, string>() { {"Mercury", "MESSENGER" } });
                planetProbes.Add(new Dictionary<string, string>() { {"Venus", "Pioneer Venus Orbiter" } });
                planetProbes.Add(new Dictionary<string, string>() { {"Venus", "Galileo" } });
                planetProbes.Add(new Dictionary<string, string>() { {"Mars", "Curiosity" } });
                planetProbes.Add(new Dictionary<string, string>() { {"Mars", "Insight" } });
                planetProbes.Add(new Dictionary<string, string>() { {"Jupiter", "Juno" } });
                planetProbes.Add(new Dictionary<string, string>() { {"Jupiter", "Europa Clipper" } });
                planetProbes.Add(new Dictionary<string, string>() { {"Saturn", "Voyager 1" } });
                planetProbes.Add(new Dictionary<string, string>() { {"Saturn", "Cassini" } });
                planetProbes.Add(new Dictionary<string, string>() { {"Uranus", "Voyager 2" } });
                planetProbes.Add(new Dictionary<string, string>() { {"Neptune", "Voyager 2" } });

                // iterate planets
                foreach (string planet in planetList)
                {
                    List<string> matchingProbes = new List<string>();

                // iterate planetProbes
                    foreach(Dictionary<string, string> probe in planetProbes)
                    {
                        foreach(KeyValuePair<string, string> kvp in probe)
                        /*
                            Does the current Dictionary contain the key of
                            the current planet? Investigate the ContainsKey()
                            method on a Dictionary.

                            If so, add the current spacecraft to `matchingProbes`.
                        */
                        if (planet == kvp.Key)
                        {
                            matchingProbes.Add(kvp.Value);
                        }

                    }

                    /*
                        Use String.Join(",", matchingProbes) as part of the
                        solution to get the output below. It's the C# way of
                        writing `array.join(",")` in JavaScript.
                    */
                    Console.WriteLine($"{planet}: {String.Join(", ", matchingProbes)}");

                }


        //      Lightning Exercise
        Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
        idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
        idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
        idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
        idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
        idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
        idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
        idioms.Add("Grain", new List<string> { "Take","what","someone","says","with","a","grain","of","salt" });
        idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
        idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
        idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

        foreach (KeyValuePair<string, List<string>> item in idioms)
        {
            // When I was trying this before I seen answer I was forgetting the { before String.Join
            Console.WriteLine($"{item.Key}: {String.Join(" ", item.Value)}");
        }

        // Jenna Lightning Exercise
        // Ariana's boyfriends
            // Pete Davidson
            // Ricky Alvarez
            // Big Sean
            // Jai Brooks
            // Nathan Sykes
            // Graham Phillips

            Dictionary<string, string> boyfriends = new Dictionary<string, string>();
            boyfriends.Add("Pete Davidson", "boyfriend");
            boyfriends.Add("Ricky Alvarez", "boyfriend");
            boyfriends.Add("Big Sean", "boyfriend");
            boyfriends.Add("Jai Brooks", "boyfriend");
            boyfriends.Add("Nathan Sykes", "boyfriend");
            boyfriends.Add("Graham Phillips", "boyfriend");
            // // Add Ariana's boyfriends to the boyfriends dictionary with the {key name, value boyfriend} ex. {Big Sean, boyfriend}
            // // I want you to change the value boyfriend to ex-boyfriend ex {Big Sean, ex-boyfriend}, if Pete Davidson change the value to ex-fiance ex {Pete Davidson, ex-fiance}

            Dictionary<string, string> previousBoyfriends = new Dictionary<string, string> ();

            foreach (KeyValuePair<string, string> boyf in boyfriends)
            {
                if (boyf.Key == "Pete Davidson")
                {
                    previousBoyfriends[boyf.Key] = "ex-fiance";
                } else
                {
                    previousBoyfriends[boyf.Key] = "ex-boyfriend";
                }
            }

            foreach (KeyValuePair<string, string> boyf in previousBoyfriends) {
                Console.WriteLine($"Ariana's {boyf.Value} is {boyf.Key} ");
            }

        Dictionary<string, string> wordDefinitions = new Dictionary<string, string>();
        wordDefinitions.Add("leave", "go");
        wordDefinitions.Add("dog", "four legged furry animal");

        foreach (KeyValuePair<string, string> item in wordDefinitions)
        {
            Console.WriteLine($"The definition of {item.Key} is {item.Value}");
        }

        // Now, we are going to rebuild the structure of our data. Instead of one dictionary with key value pairs for words and definitions.
        // We want to track more than just the word and its definition, so we are going to build a list of dictionaries.
            
            // Make a new list 
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            // We want to track the following about each word: word, definition, part of speech, example sentence

            /*
                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
             */
            
            // create dictionary to represent a few word
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            excitedWord.Add("word", "walk");
            excitedWord.Add("definition", "on your feet");
            excitedWord.Add("part of speech", "noun");
            excitedWord.Add("part of sentence", "I want to walk out of here");


            // Add dictionaries to your list
            dictionaryOfWords.Add(excitedWord);
            // create another dictionary and add that to the list

            // loop over your list of dictionaries and output the data

            /*
            Example output for one word in the list of dictionaries:
                word: excited
                definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                part of speech: adjective
                example sentence: I am excited to learn C#!
             */

            // iterate list
            foreach (Dictionary<string, string> words in dictionaryOfWords)
            {
                // iterate key value pair of dictionary
                foreach (KeyValuePair<string, string> kvp in excitedWord)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
            }
            }

        }
    }
