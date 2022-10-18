using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - reverse a string

            Console.WriteLine("Task 1. Please enter your sentence to be reversed down below!");
            var str0 = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Reverse();

            Console.WriteLine(string.Join(" ", str0));


            // Task 2 - count capital and small letters in a string

            Console.WriteLine("Task 2. Please enter a word to count capital letters!");
            string str1 = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                if (char.IsUpper(str1[i]))
                {
                    count++;
                }
            }
            Console.WriteLine("Amount of capital letters: " + count);
            
            int count2 = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (!char.IsUpper(str1[i]))
                {
                    count2++;
                }
            }
            Console.WriteLine("Amount of non-capital letters: " + count2);


            // Task 3 - find the longest word 

            Console.WriteLine("Task 3. Please enter your sentence to find the longest word!");
            string[] str2 = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            int maxLength = 0;
            int index = 0;

            for (int i = 0; i < str2.Length; i++)
            {
                if (str2[i].Length > maxLength)
                {
                    maxLength = str2[i].Length;
                    index = i;
                }
            }
            Console.WriteLine("The longest word: ", str2[index]);


            // Task 4 - replace all dots with exclamation marks

            Console.WriteLine("Task 4. Please enter the sentences to replace dots!");

            string str3 = Console.ReadLine();
            Console.WriteLine("Replaced '.' to '!': " + str3.Replace('.', '!'));


            // Task 5* - check if the string is palindrome

            Console.WriteLine("Task 5. Please enter the word to check if it's palindrome!");
            string str4 = Console.ReadLine();

            for (int i = 0; i < str4.Length; i++)
            {
                if (str4[i] != str4[str4.Length - i - 1])
                {
                    Console.WriteLine("This word is not palindrome!");
                }
                else { Console.WriteLine("Congrats! This word is palindrome!"); }
            }
        }
    }
}
