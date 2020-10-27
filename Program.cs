using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Week1MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string adjective0 = "Wooly";
            string adjective1 = "immaculate";
            string adjective2 = "pre-licked";
            string adjective3 = "bizarre";

            string noun0 = "Mammoth";
            string noun1 = "penthouse";
            string noun2 = "platypus";

            string verbPastTense0 = "dashed";
            string verbPastTense1 = "high-fived";

            string adverb0 = "hastily";
            string adverb1 = "nonchalantly";

            string verb0 = "belly crawl";
            
            //Using string concatination.
            Console.WriteLine
                ("Today I went to the zoo. I saw a " + adjective0 + " " + noun0 + " jumping up and down in its tree." +
                " He " + verbPastTense0 + " " + adverb0 + " through the large tunnel that led to its " + adjective1 + " " + noun1 +
                ". I got some peanuts and passed them through the cage to a gigantic grey " + noun2 + " towering above my head." +
                " Feeding that animal made me hungry. I went to get a " + adjective2 + " scoop of ice cream. It filled my stomach. " +
                " Afterwards I had to " + verb0 + " " + adverb1 + " to catch our bus. " +
                "When I got home I " + verbPastTense1 + " my mom for a " + adjective3 + " day at the zoo.");
            Console.WriteLine();

            //Using string tokenization.
            Console.WriteLine("Today I went to the zoo. I saw a {0}{1} jumping up and down in its tree. He {2}{3} through the large tunnel that led to its {4}{5}. I got some peanuts and passed them through the cage to a gigantic grey {6} towering above my head. Feeding that animal made me hungry. I went to get a {7} scoop of ice cream. It filled my stomach. Afterwards I had to {8}{9} to catch our bus. When I got home I {10} my mom for a {11} day at the zoo.", adjective0, noun0,
               verbPastTense0, adverb0, adjective1, noun1, noun2, adjective2, verb0, adverb1, verbPastTense1, adjective3);
            Console.WriteLine();

            //Using string interpolation
            Console.WriteLine($"Today I went to the zoo. I saw a {adjective0} {noun0} jumping up and down in its tree. He {verbPastTense0} {adverb0} through the large tunnel that led to its {adjective1} {noun1}. I got some peanuts and passed them through the cage to a gigantic grey {noun2} towering above my head. Feeding that animal made me hungry. I went to get a {adjective2} scoop of ice cream. It filled my stomach. Afterwards I had to {verb0} {adverb1} to catch our bus. When I got home I {verbPastTense1} my mom for a {adjective3} day at the zoo.");
            Console.ReadLine();
            */
            Console.WriteLine("Let's write a Mad Libs story");
            Console.WriteLine("Do you remember Schoolhouse Rock? It was a series of television snippets that taught english, history and math." +
                " You're gonna wanna remember the english series for this game. And so I unpacked my adjectives... an adjective is a word that describes, " +
                "give an adjective, please.");
            string adjective0 = Console.ReadLine();
            Console.WriteLine("A noun is a person, place or thing. Let's add a noun to our story");
            string noun0 = Console.ReadLine();
            Console.WriteLine("Use a past tense verb, you know an action word that describes something that has already happened");
            string verbPastTense0 = Console.ReadLine();
            Console.WriteLine("Lolli Lolli Lolli get your adverbs here... " +
                "an adverb modifies or qualifies, it answers what?, how?, when?, why?, or where?; example: he sings loudly - 'loudly' is the adverb. Give an adverb now");
            string adverb0 = Console.ReadLine();
            Console.WriteLine("Unpack your another adjective.");
            string adjective1 = Console.ReadLine();
            Console.WriteLine("Give a noun that your adjective describes.");
            string noun1 = Console.ReadLine();
            Console.WriteLine("I'll take another noun for 2 hundred, Alex!");
            string noun2 = Console.ReadLine();
            Console.WriteLine("We really like adjectives! Give another one here.");
            string adjective2 = Console.ReadLine();
            Console.WriteLine("Verbs are action words. Give a verb, please.");
            string verb0 = Console.ReadLine();
            Console.WriteLine("I feel like a cheerleader.. Give an adverb! Yeah!");
            string adverb1 = Console.ReadLine();
            Console.WriteLine("It's time for another past tense verb.");
            string verbPastTense1 = Console.ReadLine();
            Console.WriteLine("Last but not least, one last adjective and then we'll read our story");
            string adjective3 = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Today I went to the zoo. I saw a " + adjective0 + " " + noun0 + " jumping up and down in its tree." +
               " He " + verbPastTense0 + " " + adverb0 + " through the large tunnel that led to its " + adjective1 + " " + noun1 +
               ". I got some peanuts and passed them through the cage to a gigantic grey " + noun2 + " towering above my head." +
               " Feeding that animal made me hungry. I went to get a " + adjective2 + " scoop of ice cream. It filled my stomach. " +
               " Afterwards I had to " + verb0 + " " + adverb1 + " to catch our bus. " +
               "When I got home I " + verbPastTense1 + " my mom for a " + adjective3 + " day at the zoo.");
            Console.ReadLine();
        
            Console.WriteLine();

        }
    }
}
