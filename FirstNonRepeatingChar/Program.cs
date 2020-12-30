using System;
using System.Collections.Generic;

namespace FirstNonRepeatingChar
{
    class Program
    {
        static void Main(string[] args)
        {
            char outlier;

            Console.WriteLine("This program takes a String of characters, and will return the First non repeated \n" +
                              "character inside that string. Enter a string and the program will catch the first \n" +
                              "nonrepeated character.");

            //Cast the user's input to a string of chars, and send it to the function
            String UserInput = Console.ReadLine();
            outlier = FirstNonRepeatingChar(UserInput);

            //Make sure the user enters a valid string
            while (UserInput.Equals(null))
            {
                Console.WriteLine("Please enter valid input: ");
                outlier = FirstNonRepeatingChar(UserInput);
            }

            //If the function finds no repeating chars, then the first if statment will run, otherwise the else state ment will
            if (outlier == '\0')
            {
                Console.WriteLine("The string you entered has no non repeating characters. Meaning every \n" +
                                  "Character you entered was the exact same.");
            }
            else
                Console.WriteLine("The first non repeating character inside the string you entered was = " + outlier);
        }

        static char FirstNonRepeatingChar(string UserInput)
        {
            Dictionary<char, int> CharCounter = new Dictionary<char, int>();

            char currentChar = UserInput[0];


            for (int i = 0; i < UserInput.Length; i++)
            {


                if (i == 0)
                {
                    CharCounter.Add(UserInput[i], 1);
                    break;
                }

                //if a repeating char is found, increment the value of that repeating char inside the dictionary
                if ((i > 0) && (CharCounter.ContainsKey(currentChar)))
                {
                    CharCounter[UserInput[i]]++;
                }

                else
                    CharCounter.Add(UserInput[i], 1);
            }

            for (int i = 0; i < UserInput.Length; i++)
            {
                //Indexer syntax
                if ( (CharCounter[currentChar] == 1) && (!CharCounter.ContainsKey(currentChar)) )
                    return currentChar;
            }
            
            return '\0';
        }
    }
}



