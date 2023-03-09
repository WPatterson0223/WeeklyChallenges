using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) { return false; }
            var answer = words.Where(x => x != null).Select(x => x.ToLower());
            if (!ignoreCase)
            {
                return words.Contains(word);
            }
            return answer.Contains(word.ToLower());
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2) { return false; }
            if (num == 2) { return true; }
            for (int i = 2; i <= (int)Math.Ceiling(Math.Sqrt(num)); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int answer = -1;
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                count = 0;
                for (int x = 0; x < str.Length; x++)
                {
                    if (str[i] == str[x])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    answer = i;
                }
            }
            return answer;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 1;
            int answer = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    count++;
                    if (count > answer)
                    {
                        answer = count;
                    }
                }
                else
                {
                    count = 1;
                }
            }
            return answer;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> answer = new List<double>();
            if (n < 1 || elements == null) { return answer.ToArray(); }

            for (int i = n - 1; i < elements.Count; i += n)
            {
                answer.Add(elements[i]);
            }
            return answer.ToArray();
        }
    }
}
