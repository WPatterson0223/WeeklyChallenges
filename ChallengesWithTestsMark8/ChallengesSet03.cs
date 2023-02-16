using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool item in vals)
            {
                if (item == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int oddsSumAnswer = 0;
            if (numbers == null)
            {
                return false;
            }
            foreach (int item in numbers)
            {
                if (item % 2 != 0)
                {
                    oddsSumAnswer += item;
                }
            }
            if (oddsSumAnswer % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password,i))
                {
                    hasUpper = true;
                    break;
                }
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password, i))
                {
                    hasLower = true;
                    break;
                }
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password, i))
                {
                    hasNumber = true;
                    break;
                }
            }
            if(hasUpper && hasLower && hasNumber){
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return char.Parse(val.Substring(0,1));
        }

        public char GetLastLetterOfString(string val)
        {
            return char.Parse(val.Substring(val.Length - 1, 1));
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] answer = new int[50];
            int counter = 1;
            for (int i = 0; i < 50; i ++)
            {
                answer[i] = counter;
                counter += 2;
            }
            return answer;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
