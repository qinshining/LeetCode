using Microsoft.VisualStudio.TestTools.UnitTesting;
using _9.回文数;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.回文数.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            int x = 1001;
            Solution solution = new Solution();
            bool result = solution.IsPalindrome(x);

            Assert.IsTrue(result);
        }
    }
}