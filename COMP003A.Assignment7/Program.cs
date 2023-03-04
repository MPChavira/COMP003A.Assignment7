/*
 * Author: MichaelPerez Chavira 
 * Course: COMP003A
 * Purpose: Week 7 Assignment: Basic Data Structures
 */

using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using static System.Collections.Specialized.BitVector32;

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("Array - CharacterCounter Section");
    
            Console.WriteLine("Please enter a letter");
            char characterInput = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Please enter a word: ");
            string word = Console.ReadLine();
            int count = CharacterCounter(characterInput, word);
            Console.WriteLine($"There are {count} letter {characterInput} in the word {word}. ");

            SectionSeparator("Array - IsPalindrome Section");

           
            Console.WriteLine("Please enter a word to check if it is a palindrome: ");
            string wordInput = Console.ReadLine();
            bool isPalindrome = IsPalindrome(wordInput);
            Console.WriteLine($"Is the word '{wordInput}' a palindrome: {isPalindrome}");
            
            SectionSeparator("List - Add Section");
           
            List<string> names = new List<string>();
            char userInput = default;
            do
            {
                Console.Write("Enter a name to add to the list: ");
                string name = Console.ReadLine();
                names.Add(name);

                Console.Write("Press any key to add more or (e) to exit: ");
                userInput = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (userInput != 'e');

            SectionSeparator("List - Traversal Section");

            TraverseList(names);

            SectionSeparator("List - Reverse Traversal Section");

            TraverseListReverse(names);

        }
        static void SectionSeparator(string text)
        {
            Console.WriteLine();
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine($"{text}");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine();
        }
       static int CharacterCounter(char characterInput, string word)
        {
            int count = 0;
            characterInput = char.ToLower(characterInput);
            word = word.ToLower();
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == characterInput)
                {
                    count++;
                }
            }

            return count;         
        }
        static bool IsPalindrome(string word)
        {
            string reverseWord = "";
            word = word.ToLower();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverseWord += word[i];
            }
            return word == reverseWord;
        }
        static void TraverseList(List<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
        static void TraverseListReverse(List<string> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }

    }
}