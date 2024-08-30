using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool contains = false;

            if (string.Equals(words, null) || words.Contains(null))
            {
                return contains;
            }
            
            if (ignoreCase)
            {
                word = word.ToLower();
                List<string> lowercase = words.Select(x => x.ToLower()).ToList();

                contains = lowercase.Contains(word);
            }

            if (!ignoreCase)
            {
                contains = words.Contains(word);
            }
            return contains;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num >= 0)
            {
                if (num == 2 || num == 3)
                {
                    return true;
                }
                if (num == 1)
                {
                    return false;
                }
                return num % 2 != 0 && num % 3 != 0;
            }
            return false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uindex;

            for (int i = 0; i < str.Length; i++)
            {
                uindex = true;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uindex = false;
                    }
                }

                if (uindex)
                {
                    index = i;
                }
            }

            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                int currCount = 1;
                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if(numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currCount++;
                }

                if (currCount > count)
                {
                    count = currCount;
                }
            }

            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count == 0 || n < 0 || n > elements.Count)
            {
                return new double[0];
            }

            List<double> everyNElement = new List<double>();
            foreach (var num in elements)
            {
                if (num % n == 0)
                {
                    everyNElement.Add(num);
                }
            }

            return everyNElement.ToArray();
        }
    }
}
