using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Contains(false))
            {
                return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            return numbers != null && numbers.Sum() % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var upper = false;
            var lower = false;
            var num = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    upper = true;
                }
                if (char.IsLower(password[i]))
                {
                    lower = true;
                }
                if (char.IsNumber(password[i]))
                {
                    num = true;
                }
            }
            if (upper == true && lower == true && num == true)
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            //Wow this one is really cool!
            return val[^1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return (divisor == 0) ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> oddsTo100 = new List<int>();
            for (var i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddsTo100.Add(i);
                }
            }
            return oddsTo100.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
