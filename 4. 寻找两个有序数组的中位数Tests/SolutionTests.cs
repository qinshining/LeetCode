using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4.寻找两个有序数组的中位数;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.寻找两个有序数组的中位数.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void FindMedianSortedArraysTest()
        {
            int[] nums1 = new int[] { 1, 2 };
            int[] nums2 = new int[] { 3, 4 };

            Solution solution = new Solution();
            double result = solution.FindMedianSortedArrays(nums1, nums2);


            Assert.AreEqual(result, 2.5);
        }
    }
}