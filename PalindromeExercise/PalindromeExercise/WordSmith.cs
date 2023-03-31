using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {

        }

        public bool IsAPalindrome(string word)
        {
            if(word == null || word.Length == 0) //checking to see if user entered words wrong
            {
                return false;
            }
            var reversed = ""; //string.Empty; can be used as well

            for(var i = word.Length - 1; i >= 0; i--) //working backwards to check palindrome words
            {
                reversed += word.ToLower()[i];
            }

            if(reversed == word.ToLower()) //checking if words are true palindromes or false 
            {
                return true;
            }
            else
            {
                return false;
            }

            //return (word?.Length == 0) ? false : word?.Replace(" ", "").ToLower().SequenceEqual(word?Replace(" ", "").ToLower().Reverse()) ?? false;
        }
    }
}
