using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataExercises
{
    //You need to write a function that reverses the words in a given string. A word can also fit an empty string. If this is not clear enough, here are some examples:
    //Kata.Reverse("Hello World"); // -> "World Hello"
    //Kata.Reverse("Hi There."); // -> "There. Hi"
  public class ReversingWords
    {
        public string reverseWords(string text)
        {
            string[] myArray = text.Split(' ');

            Array.Reverse(myArray);

            string reverse = string.Join(" ", myArray);

            return reverse;
        }
    }
}
