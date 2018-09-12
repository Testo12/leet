using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace U18SEP10X1
{
    class Program
    {
        static void Main(string[] args)
        {

            int active = 0;

            do
            {


                Console.WriteLine("Vilket programm? A,B,C,D,E,F,H,I eller Q för att avsluta?");
                String choice = Console.ReadLine();
                String Change = choice.ToLower();
                switch (Change)
                {


                    case "a":
                        System.Console.WriteLine("Skriv in en mening");
                        System.String quote = Console.ReadLine();
                        System.String wordd = quote;
                        wordd = System.Text.RegularExpressions.Regex.Replace(quote, @"\s+", " ");
                        int countWords = wordd.Trim().Split().Length;
                        System.Console.WriteLine("Din mening innehåller " + countWords + " ord.");
                        string[] words = quote.Split(' ');
                        foreach (string word in words)
                        { Console.WriteLine(word + " är " + word.Length + " tecken"); }

                        active = 1;
                        break;

                    case "b":
                        System.Console.WriteLine("Skriv en mening");
                        String text = Console.ReadLine();
                        words = text.Split(' ');
                        Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));
                        Array.Reverse(words);

                        for (int i = 0; i < words.Length; i++)
                        {
                            Console.WriteLine(words[i]);
                        }
                        Console.WriteLine(" ");
                        Array.Reverse(words);
                        for (int i = 0; i < words.Length; i++)
                        {
                            Console.WriteLine(words[i]);
                        }
                        Console.ReadLine();

                        active = 1;
                        break;

                    case "c":
                        System.Console.WriteLine("Skriv en mening");
                        String sentence = Console.ReadLine();
                        string txt = sentence.ToLower();
                        String[] part = txt.Split(' ', ',','?','!');

                        var list = new List<string>(part);
                        var q = list.GroupBy(b => b)
                                    .Select(g => new { Value = g.Key, Count = g.Count() })
                                    .OrderByDescending(b => b.Count);

                        foreach (var b in q){
                            Console.WriteLine("Ord: " + b.Value + " Antal: " + b.Count);
                        }

                        active = 1;
                        break;

                    case "d":

                        System.Console.WriteLine("Skriv en mening");
                        String line = Console.ReadLine();
                        string parts = line.ToLower();
                        String[] myStrings = line.Split();

                        string longText = line;

                        var count = CharacterCount.Count(longText);

                        foreach (var character in count)
                        {
                            Console.WriteLine("{0} - {1}", character.Key, character.Value);

                        }

                            active = 1;
                            break;
                        
                        case "e":

                        int k = 0;
                        do
                        {
                            System.Console.WriteLine("Skriv in ett ord, skriv in 'avsluta' för att avsluta ");
                            String input = Console.ReadLine();
                            String close = ("avsluta");
                            int c = string.Compare(input, close);
                            System.Console.WriteLine("Du skrev " + input);
                            if (c == 0) { k = 1; }



                        }
                        while (k != 1);

                        active = 1;
                        break;

                    case "f":

                        int l = 0;
                        do
                        {
                            System.Console.WriteLine(" Skriv in siffra mellan 1 och 21. ");
                            int guess = Convert.ToInt32(Console.ReadLine());
                            Random random = new Random();
                            int luck = random.Next(1, 21);

                            
                            if (guess == luck)
                            {
                                System.Console.WriteLine("Du gissa rätt! Tillbaka till menyn för ditt pris ");
                                l = 1;
                            }

                            else
                            {
                                System.Console.WriteLine("Du gissa tyvärr fel, försök igen!"+ " Rätt siffra var "+ luck);
                                l = 0;
                            }
                                ;
                        }
                        while (l != 1);

                        active = 1;
                        break;

                    case "h":
                    
                        string[] stringsForEncoding = { "4", "8", "( ", "|)", "3", "|=", "9", "|-|", "1", "!", "|<", "1", "(V)", "(\\)", "0", "|2", "(,)", "|Z", "5", "7", "|_|", "\\/", "`//", "x", "y", "z" };
                        string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
                        Console.Write("Skriv vad vill du översätta till LEET: ");
                        char[] toLeet = Console.ReadLine().ToCharArray();
                        int length = toLeet.Length;
                        string[] encodedCharacters = new string[length];
                        int leet = 0;
                        foreach (char normal in toLeet)
                        {
                            
                            if ((normal >= 'a' && normal <= 'z') || (normal >= 'A' && normal <= 'Z'))
                            {
                                int results = Array.FindIndex(alphabet, x => x.Contains(normal));
                                encodedCharacters[leet] = stringsForEncoding[results];
                            }

                            else
                            {
                                encodedCharacters[leet] = normal.ToString();
                            }
                            leet++;
                        }
                        Console.WriteLine(string.Join("", encodedCharacters));
                        








                        active = 1;
                        break;

                    case "i":


                        active = 1;
                        break;

                        System.Console.ReadLine();



                    case "q":
                        Application.Exit();
                        active = 0;
                        break;
                }
            


            }
            while (active != 0);





        }

        class CharacterCount
        {
            public static SortedDictionary<char, ulong> Count(string stringToCount)
            {
                SortedDictionary<char, ulong> characterCount = new SortedDictionary<char, ulong>();

                foreach (var character in stringToCount)
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }

                return characterCount;
            }

        }
    } }

