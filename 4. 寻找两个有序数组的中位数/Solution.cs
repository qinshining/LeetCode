using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.寻找两个有序数组的中位数
{
    public class Solution
    {
        /// <summary>
        /// 给定两个大小为 m 和 n 的有序数组 nums1 和 nums2。
        /// 请你找出这两个有序数组的中位数，并且要求算法的时间复杂度为 O(log(m + n))。
        /// 你可以假设 nums1和 nums2不会同时为空。
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> list = new List<int>();
            list.AddRange(nums1);
            list.AddRange(nums2);
            list.Sort();
            int length = list.Count;
            double result = 0.0;
            if (length % 2 != 0)
            {
                result = list[length / 2];
            }
            else
            {
                result = (double)(list[(length / 2) - 1] + list[(length / 2)]) / 2;
            }
            return result;
        }
    }
}
