using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.回文数
{
    public class Solution
    {
        /// <summary>
        /// 判断一个整数是否是回文数。回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>

        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            int length = x.ToString().Length;
            int headNum = 0;
            int tailNum = 0;
            for (int i = 0; i < length / 2; i++)
            {
                headNum = (x / (int)(Math.Pow(10, length - 1 - i))) % 10;
                tailNum = (x / (int)(Math.Pow(10, i))) % 10;
                if (headNum != tailNum)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
