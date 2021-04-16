using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace GC_Exercise_26_27_28
{
    class Program
    {
        //prompt the user to enter text. 
        //Count and output how many vowels were in the string
        static void Main(string[] args)
        {
            //Exercise 26

            bool vLoop = true;
            while (vLoop)
            {
                Console.WriteLine("Exercise 26");
                Console.WriteLine("Enter some text");
                string userinput = Console.ReadLine();
                Console.WriteLine($"There were {HowManyVowels(userinput)} vowel(s)");

                //Vowels continue?
                bool vConLoop = true;
                while (vConLoop)
                {
                    Console.WriteLine("Continue? y/n");
                    string vCon = Console.ReadLine().ToLower();

                    switch (vCon)
                    {
                        case "y":
                            vConLoop = false;
                            vLoop = true;
                            break;
                        case "n":
                            vConLoop = false;
                            vLoop = false;
                            break;
                        default:
                            Console.WriteLine("I didn't catch that");
                            vConLoop = true;
                            break;
                    }
                }
            }
            // Exercise 27
            bool cLoop = true;
            while (cLoop)
            {
                Console.WriteLine("Exercise 27");
                Console.WriteLine("Enter some text");
                string userinput2 = Console.ReadLine();
                Console.WriteLine($"There were {HowManyConsonants(userinput2)} consonants");


                //Consonants Continue?
                bool cConLoop = true;
                while (cConLoop)
                {
                    Console.WriteLine("Continue? y/n");
                    string cCon = Console.ReadLine().ToLower();

                    switch (cCon)
                    {
                        case "y":
                            cConLoop = false;
                            cLoop = true;
                            break;
                        case "n":
                            cConLoop = false;
                            cLoop = false;
                            break;
                        default:
                            Console.WriteLine("I didn't catch that");
                            cConLoop = true;
                            break;
                    }
                }
            }


            //Exercise 28
            bool vrLoop = true;
            while (vrLoop)
            {
                Console.WriteLine("Exercise 28");
                Console.WriteLine("Enter some text");
                string userInput3 = Console.ReadLine();
                Console.WriteLine(VowelsRemoved(userInput3));


                bool vrConLoop = true;
                while (vrConLoop)
                {
                    Console.WriteLine("Continue? y/n");
                    string cCon = Console.ReadLine().ToLower();

                    switch (cCon)
                    {
                        case "y":
                            vrConLoop = false;
                            vrLoop = true;
                            break;
                        case "n":
                            vrConLoop = false;
                            vrLoop = false;
                            break;
                        default:
                            Console.WriteLine("I didn't catch that");
                            vrConLoop = true;
                            break;
                    }
                }
            }
        }

        public static int HowManyVowels(string input)
        {
            int vowelCount = 0;
            foreach (char letter in input)
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }

        public static int HowManyConsonants(string input2)
        {
            int consCount = 0;
            foreach (char letter in input2)
            {
                if (letter != 'a' && letter != 'e' && letter != 'i' && letter != 'o' && letter != 'u')
                {
                    consCount++;
                }
            }
            return consCount;
        }

        public static string VowelsRemoved(string input3)
        {
            Regex noVowels = new Regex("[aAeEiIoOuU]");
            return noVowels.Replace(input3, "");
        }
    }
}

