using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Console_App
{
    class Program
    {
        static void Main(string [] arg)
        {
           // Inserting both random numbers into a variable
            int a = Rand_array();
            int b= Rand_index();
            //Program introduction
            Console.WriteLine("MPS ASSIGNMENT 5\nTHE HANGMAN GAME!\nRULES!\nNote : All user inputs should be in small Characters.\nHit Ctrl C to Exit\nYou only have Five Lives\n");

            //All arrays and elements to be guessed
            string[] fruit = { "orange","mango","melon","lime","lemon","garlic","grape","spinach","pears","plums"};
            string[] colour = { "violet","wine","pink","brown","tan","red","blue","grey","black","white"};
            string[] country = {"serbia","china","turkey","iceland","korea" ,"spain","egypt","uae","brazil","ethopia"};
            string[] name = { "joseph","drogba","Faith","ronald","justin","bruyne","sterling","bale","arnold","jack"};
            string[] food = { "sandwich","pie","rice","fish","bagel","yam","tacos","lobster","beans","maize"};

            //Jagged array containing all array to be guessed
            string[][] cartegories = new string[][] {
                fruit,
                colour,
                country,
                name,
                food,
            };
            string type="";

            //Hint to tell player the cartegory guessed by the compiler
            if (a == 0)
                type = "Fruit";
            if (a == 1)
                type = "Colour";
            if (a == 2)
                type = "Country";
            if (a == 3)
                type = "Name";
            if (a == 4)
                type = "Food";

            //output in program
            Console.WriteLine("\nYour word is a {0}.\nGoodluck!\n",type);
            Console.Write("\t\t");

            //Length of the word
            int wordlength = cartegories[a][b].Length;
            //The word put in a 'word' variable
            string word = cartegories[a][b];
            //The lines that update during program
            string wordline="";
            //The variable used to update wordline variable with letters
            int letter_index;

            //for loop creating underscores based on the length of the word
            for (int x = 0; x < wordlength; x++) {
                wordline += "_ ";
            }

            //little output in program
            Console.WriteLine(wordline);
            Console.WriteLine("\nStart guessing : )\n");
            //guess variable where we guess letters into
            char guess = 'a';

           // for loop controlling the hangman game
            for(int x=5; x > 0;)
            {
                Console.Write("\n{0} tries left : ",x);
                if (wordline.Contains("_"))
                { }
                else
                {
                    Console.WriteLine("\n\nCONGRATS!! YOU'RE AWESOME! YOU WON!\n\nThe answer : {0}", word);
                    break;
                }
                guess = Convert.ToChar(Console.ReadLine());
                if (word.Contains(guess))
                {
                    Console.WriteLine("Correct!");
                    letter_index = word.IndexOf(guess)*2;
                    wordline = wordline.Insert(letter_index,Convert.ToString(guess));
                    wordline = wordline.Remove(letter_index + 1, 1);
                }
                else { 
                    Console.WriteLine("Wrong!");
                    if (x == 1)
                        Console.WriteLine("\nYou lost! Never give up! The answer : {0}.\nTRY AGAIN!", word);
                        --x;
                }
                Console.WriteLine("\n\t{0}", wordline);


            }
        static int Rand_array()
        {
            Random arr = new Random();
            return arr.Next(0, 5);
        }
        //Random number used to get the element index inside the random array chosen
        static int Rand_index() { 
            Random index = new Random();
            return index.Next(0, 10);
        }
        
            Console.WriteLine("\n\n\n Created by Shaqeel Less ");
            Console.ReadLine();
	    }
    }
}




