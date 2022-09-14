using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    internal class FindMaximum
    {
        public int FindMaxIntNumber(int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
                return firstNum;
            if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0)
                return secondNum;
            else
                return thirdNum;
        }
        public float FindMaxFloatNumber(float firstNum, float secondNum, float thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
                return firstNum;
            if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0)
                return secondNum;
            else
                return thirdNum;
        }
        public string FindMaxString(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0)
                return firstString;
            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0)
                return secondString;
            else
                return thirdString;
        }
    }
}
    

