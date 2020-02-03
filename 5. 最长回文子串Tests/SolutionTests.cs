using Microsoft.VisualStudio.TestTools.UnitTesting;
using _5.最长回文子串;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.最长回文子串.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void LongestPalindromeTest()
        {
            string s = "cbbd";

            Solution solution = new Solution();
            var result = solution.LongestPalindrome(s);

            //Assert.IsTrue(true);
            Assert.AreEqual("bab", result);
        }
    }
}