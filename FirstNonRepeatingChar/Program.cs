using System;

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

            char[] UserInput = Console.ReadLine().ToCharArray();
            outlier = FirstNonRepeatingChar(UserInput);

            if (outlier == '\0')
            {
                Console.WriteLine("The string you entered has no non repeating characters. Meaning every \n" +
                                  "Character you entered was the exact same.");
            }
            else
                Console.WriteLine("The first non repeating character inside the string you entered was = " + outlier);
        }

       static char FirstNonRepeatingChar(char[] input)
        {
            char outlier = '\0';
            char FirstChar;

            FirstChar = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                if (FirstChar != input[i])
                { 
                    outlier = input[i];
                    break;
                }
            }

            return outlier;
        }
    }
}
