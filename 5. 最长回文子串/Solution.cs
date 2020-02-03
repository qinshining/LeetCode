using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.最长回文子串
{
    public class Solution
    {
        /// <summary>
        /// 给定一个字符串 s，找到 s 中最长的回文子串。你可以假设 s 的最大长度为 1000。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string LongestPalindrome1(string s)
        {
            //超时。。。
            int maxLength = 0;
            string result = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                int lastLength = s.Length - i;
                if (lastLength <= maxLength)
                {
                    break;
                }
                int targetLength = maxLength + 1;
                while (targetLength <= lastLength)
                {
                    string tempStr = s.Substring(i, targetLength);
                    if (IsPalindrome(tempStr))
                    {
                        maxLength = targetLength;
                        result = tempStr;
                    }
                    targetLength++;
                }
            }
            return result;
        }

        private bool IsPalindrome(string s)
        {
            int length = s.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (s[i] != s[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public string LongestPalindrome(string s)
        {
            int start = 0;
            int end = 0;
            int maxLength = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = ExpandAroundCenter(s, i, i);
                int len2 = ExpandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > maxLength)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                    maxLength = (end - start) + 1;
                }
            }
            return s.Substring(start, maxLength);
        }

        private int ExpandAroundCenter(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }
    }
}
