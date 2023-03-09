using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int answer = 0;
            for (int i = 1; answer <= startNumber; i++)
            {
                answer = i * n;
            }
            return answer;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            businesses.Where(x => x.TotalRevenue == 0).Select(x => x.Name = "CLOSED").ToArray();
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) { return false; }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int answer = 0;
            if (numbers == null) { return 0; }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    answer += numbers[i];
                }
            }
            return answer;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0) { return ""; }
            string answer = "";
            foreach (string word in words)
            {
                if (word.Trim().Length > 0)
                {
                    answer += word.Trim() + " ";
                }
            }
            if (answer.Length == 0) { return ""; }
            answer = answer.Trim();
            return answer += ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null) { return new double[0]; }
            double[] answer = new double[elements.Count / 4];
            int count = 0;
            if (elements == null || elements.Count < 4)
            {
                return new double[0];
            }
            for (int i = 3; i < elements.Count; i += 4)
            {
                answer[count] = elements[i];
                count++;
            }
            return answer;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            int answer;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int x = 0; x < nums.Length; x++)
                {
                    if (i == x) { continue; }
                    answer = nums[i] + nums[x];
                    if (answer == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
