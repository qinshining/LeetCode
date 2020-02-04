using Microsoft.VisualStudio.TestTools.UnitTesting;
using _15.三数之和;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.三数之和.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void ThreeSumTest()
        {
            Solution solution = new Solution();
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            var result = solution.ThreeSum(nums);


            Assert.Fail();
        }
    }
}