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


                    Console.WriteLine("Vilket programm? A,B,C,D,E,F eller Q för att avsluta?");
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
                        String[] part = txt.Split(' ');

                        var list = new List<string> (part);
                        var q = list.GroupBy(x => x)
                                    .Select(g => new { Value = g.Key, Count = g.Count() })
                                    .OrderByDescending(x => x.Count);

                        foreach (var x in q)
                        {
                            Console.WriteLine("Ord: " + x.Value + " Antal: " + x.Count);
                        }


                        active = 1;
                            break;

                        case "d":
                            
                            active = 1;
                            break;

                        case "e":
                           
                            active = 1;
                            break;

                        case "f":

                           

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

            }
    }

