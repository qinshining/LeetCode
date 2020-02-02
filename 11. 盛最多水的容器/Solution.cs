using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.盛最多水的容器
{
    public class Solution
    {
        /// <summary>
        /// 给定 n 个非负整数 a1，a2，...，an，每个数代表坐标中的一个点 (i, ai) 。在坐标内画 n 条垂直线，垂直线 i 的两个端点分别为 (i, ai) 和 (i, 0)。找出其中的两条线，使得它们与 x 轴共同构成的容器可以容纳最多的水。
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int MaxArea(int[] height)
        {

            int maxArea = 0;
            int headNum = 0;
            int tailNum = height.Length - 1;
            while (headNum < tailNum)
            {
                maxArea = Math.Max(maxArea, (tailNum - headNum) * Math.Min(height[headNum], height[tailNum]));
                if (height[headNum] < height[tailNum])
                {
                    headNum++;
                }
                else
                {
                    tailNum--;
                }
            }
            return maxArea;
        }

        public int MaxArea2(int[] height)
        {
            int maxArea = 0;
            for (int i = 0; i < height.Length - 1; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    maxArea = Math.Max(maxArea, (j - i) * Math.Min(height[i], height[j]));
                }
            }
            return maxArea;
        }
    }
}
