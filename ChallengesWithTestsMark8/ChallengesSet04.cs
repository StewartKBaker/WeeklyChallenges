using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strList = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };
            return strList.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numList = new List<int> { number1, number2, number3, number4 };
            return numList.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (
                    sideLength1 + sideLength2 > sideLength3 &&
                    sideLength1 + sideLength3 > sideLength2 &&
                    sideLength2 + sideLength3 > sideLength1
                    );
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var majority = (objs.Length / 2) + 1;
            var count = 0;

            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    count++;
                }
            }

            return (count >= majority);
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            
            var nums = numbers.Where(x => x % 2 == 0);
            
            if (nums.Count() == 0)
                return 0;
            
            return nums.Average();
        }

        public int Factorial(int number)
        {
            var fact = 1;

            for (int i = number; i > 0; i--)
            {
                fact *= i;
            }
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            return fact;

            
        }
    }
}
