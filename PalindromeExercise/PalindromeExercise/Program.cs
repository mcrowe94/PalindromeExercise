﻿using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var pal = new WordSmith();

            Console.WriteLine("Please enter a potential Palindrome!");

            var word = Console.ReadLine();
            var result = pal.IsAPalindrome(word);

            //Console.WriteLine($"It is {result} that word is a Palindrome!");
            Console.WriteLine((result) ? $"{word} is a Palindrome!" : $"{word} is NOT a Palindrome!");
        }
    }
}
