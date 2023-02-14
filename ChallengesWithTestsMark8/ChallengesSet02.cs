using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return (Char.IsLetter(c)) ? true : false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0) ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0) ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0) ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            else
            {
                return numbers.Min() + numbers.Max();
            }

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            int sumAnswer = 0;
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    sumAnswer += numbers[i];
                }
                return sumAnswer;
            }
        }

        public int SumEvens(int[] numbers)
        {
            int sumEvensAnswer = 0;
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        sumEvensAnswer += numbers[i];
                    }
                }
                return sumEvensAnswer;
            }
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return false;
            }
            else
            {
                foreach (int num in numbers)
                {
                    sum += num;
                }
                return (sum % 2 != 0) ? true : false;
            }
            
            
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if(number >= 0)
            {
                return Math.Abs(number / 2);
            }
            else
            {
                return 0;
            }
            
        }
    }
}
