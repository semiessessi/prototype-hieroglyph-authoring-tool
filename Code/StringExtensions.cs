using System;
using System.Collections.Generic;
using System.Text;

namespace PP1
{
    public static class StringExtensions
    {
        public static bool ContainsDigit(this string testValue)
        {
            return testValue.Contains('0')
                || testValue.Contains('1')
                || testValue.Contains('2')
                || testValue.Contains('3')
                || testValue.Contains('4')
                || testValue.Contains('5')
                || testValue.Contains('6')
                || testValue.Contains('7')
                || testValue.Contains('8')
                || testValue.Contains('9');
        }

        public static bool IsDigit(this char testValue)
        {
            return (testValue == '0')
                || ( testValue == '1')
                || ( testValue == '2')
                || ( testValue == '3')
                || ( testValue == '4')
                || ( testValue == '5')
                || ( testValue == '6')
                || ( testValue == '7')
                || ( testValue == '8')
                || ( testValue == '9');
        }
    }
}
