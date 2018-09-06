using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GeneralKnowledge.Test.App.Tests
{
    /// <summary>
    /// Basic string manipulation exercises
    /// </summary>
    public class StringTests : ITest
    {
        public void Run()
        {
            // TODO:
            // Complete the methods below

            AnagramTest();
            GetUniqueCharsAndCount();
        }

        private void AnagramTest()
        {
            var word = "stop";
            var possibleAnagrams = new string[] { "test", "tops", "spin", "post", "mist", "step" };

            foreach (var possibleAnagram in possibleAnagrams)
            {
                Console.WriteLine(string.Format("{0} > {1}: {2}", word, possibleAnagram, possibleAnagram.IsAnagram(word)));
            }
        }

        private void GetUniqueCharsAndCount()
        {
            // TODO:
            // Write an algoritm that gets the unique characters of the word below 
            // and counts the number of occurences for each character found


            var word = "xxzwxzyzzyxwxzyxyzyxzyxzyzyxzzz";
            Dictionary<char, int> pool = new Dictionary<char, int>();
            foreach (char element in word.ToCharArray())
            {
                try
                {
                    pool.Add(element, 1);
                }
                catch
                {
                    pool[element] += 1;
                }
            }
            List<char> keyList = new List<char>(pool.Keys);

            Console.WriteLine("List of unique characters and their occurences:");
            foreach (char value in keyList)
            {
                Console.WriteLine(value + " " + pool[value]);
            }

        }
    }

    public static class StringExtensions
    {
        // TODO: 
        // Write logic to determine whether a is an anagram of b
        public static bool IsAnagram(this string a, string b)
        {
            Dictionary<char, int> aPool = new Dictionary<char, int>();
            Dictionary<char, int> bPool = new Dictionary<char, int>();
            foreach (char element in b.ToCharArray())
            {
                try
                {
                    bPool.Add(element, 1);
                }
                catch
                {
                    bPool[element] += 1;
                }
            }

            foreach (char element in a.ToCharArray())
            {
                try
                {
                    aPool.Add(element, 1);
                }
                catch
                {
                    aPool[element] += 1;
                }
            }

            foreach (char element in a.ToCharArray())
            {
                try
                {
                    if (aPool[element] != bPool[element])
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }

            }


            return true;
        }
    }
}
