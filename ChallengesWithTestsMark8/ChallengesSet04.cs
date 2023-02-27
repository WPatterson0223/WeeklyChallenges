using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return (numbers.Where(x => x % 2 == 0).Sum()) - (numbers.Where(x => x % 2 != 0).Sum());
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var length = new List<string>(){ str1, str2, str3, str4 };
            return length.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var min = new List<int>() {number1, number2, number3, number4};
            return min.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 > 0 && sideLength2 > 0 && sideLength3 > 0 && sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength3 + sideLength2 > sideLength1;
            //-------------------------------------------
        }

        public bool IsStringANumber(string input)
        {
            var nope = 0.0;
            return double.TryParse(input, out nope);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Where(x => x != null).ToList().Count < objs.Where(x => x == null).ToList().Count();
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0 || numbers.Where(x => x % 2 == 0).Count() == 0) { return 0; }
            return numbers.Where(x => x % 2 == 0).Average();
        }

        public int Factorial(int number)
        {
            int answer = 1;
            for (int i = 1; i <= number; i++)
            {
                answer *= i;
            }
            return number >= 0 ? answer : throw new ArgumentOutOfRangeException();
        }
    }
}
