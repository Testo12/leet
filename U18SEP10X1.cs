using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                            System.Console.Write("Hej! ");
                            System.Console.WriteLine("Vad heter du?");
                            System.String name = Console.ReadLine();
                            System.Console.WriteLine("God dag " + name + " !"); //Första delen av koden.
                            active = 1;
                            break;
                        case "b":
                            System.Console.WriteLine("Vad är ditt förnamn?");
                            System.String firstname = Console.ReadLine();
                            System.Console.WriteLine("Var är ditt efternamn " + firstname + "?");
                            System.String lastname = Console.ReadLine();
                            System.Console.WriteLine("Hej " + firstname + lastname); //Andra delen av Koden.
                            active = 1;
                            break;

                        case "c":
                            System.Console.WriteLine("Vilken är din favoriträtt?");
                            System.String food1 = Console.ReadLine();
                            System.String longest = food1;
                            System.Console.WriteLine("Vilken är andra favoriträtt?");
                            System.String food2 = Console.ReadLine();
                            if (food2.Length > longest.Length) { longest = food2; }
                            System.Console.WriteLine("Vilken är tredje favoriträtt?");
                            System.String food3 = Console.ReadLine();
                            if (food3.Length > longest.Length) { longest = food3; }
                            System.Console.WriteLine("Dina favoriträtter är " + food1 + "  " + food2 + "  " + food3);
                            System.Console.WriteLine(food1 + " består av " + food1.Length + " bokstäver.");
                            System.Console.WriteLine(food2 + " består av " + food2.Length + " bokstäver.");
                            System.Console.WriteLine(food3 + " består av " + food3.Length + " bokstäver.");
                            System.Console.WriteLine("Den maträtten med flest bokstäver är " + longest + " på " + longest.Length + " bokstäver."); //Tredje Delen av koden.
                            active = 1;
                            break;

                        case "d":
                            System.Console.WriteLine("Skriv ditt favoritcitat på minst fem ord?");
                            System.String quote = Console.ReadLine();
                            System.String wordd = quote;
                            wordd = System.Text.RegularExpressions.Regex.Replace(quote, @"\s+", " ");
                            int countWords = wordd.Trim().Split().Length;  //Hittade på näter för jag inte fatta skiten.
                            System.Console.WriteLine("Ditt citat innehåller " + countWords + " ord.");
                            string[] words = quote.Split(' ');
                            foreach (string word in words)
                            { Console.WriteLine(word); }
                            //Fjärde delen av koden.
                            active = 1;
                            break;

                        case "e":
                            System.Console.WriteLine("Skriv in en palindrom (Ett ord eller fras som blir detsamma läst fram och baklänges)");
                            System.String palindrome = Console.ReadLine();
                            char[] array = palindrome.ToCharArray();
                            Array.Reverse(array);
                            string backwards = new string(array);
                            System.Console.WriteLine(palindrome + " är " + backwards + " baklänges"); //Femte delen av koden.
                            active = 1;
                            break;

                        case "f":

                            System.Console.WriteLine("Skriv in ett antal tal ");
                            int amount = Convert.ToInt32(Console.ReadLine());
                            int[] numbers = new int[amount];
                            int i = 0;
                            for (i = 0; i < amount; i++)
                            {
                                int spots = 1 + i;
                                System.Console.WriteLine("Skriv in ditt " + spots + ":a nummer.");
                                numbers[i] = Convert.ToInt32(Console.ReadLine());



                            }
                            int sum = numbers.Sum();
                            int min = numbers.Min();
                            int max = numbers.Max();
                            int medium = sum / amount;
                            System.Console.WriteLine("Summan av dina tal är " + sum);
                            System.Console.WriteLine("Ditt minsta av dina tal är " + min);
                            System.Console.WriteLine("Ditt största av dina tal är " + max);
                            System.Console.WriteLine("Medelvärdet av dina tal är " + medium);


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
}
