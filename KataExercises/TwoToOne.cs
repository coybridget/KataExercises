using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataExercises
{

    //Take 2 strings s1 and s2 including only letters from a to z.Return a new sorted string,
    //the longest possible, containing distinct letters,

    public class TwoToOne
    {
        public static string Longest(string s1, string s2)
        {
            string str = s1 + s2;

            string answer = new string(str.Distinct().ToArray());

            char[] c = answer.ToCharArray();

            Array.Sort(c);

            return new String(c);
        }
    }
}
