using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.三数之和
{
    public class Solution
    {
        /// <summary>
        /// 给定一个包含 n 个整数的数组 nums，判断 nums 中是否存在三个元素 a，b，c ，使得 a + b + c = 0 ？找出所有满足条件且不重复的三元组。
        /// 注意：答案中不可以包含重复的三元组。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> ThreeSum1(int[] nums)
        {
            //超时
            List<IList<int>> result = new List<IList<int>>();
            List<int> targets = new List<int>();
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    int target = 0 - (nums[i] + nums[j]);
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[k] == target
                            && !result.Any(r => r[0] == nums[i] && r[1] == nums[j] && r[2] == nums[k]))
                        {
                            result.Add(new List<int>()
                            {
                                nums[i], nums[j], nums[k]
                            });
                            targets.Add(target);
                            break;
                        }
                    }
                }
            }
            return result;
        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);

            List<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    break;
                }
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    int res = nums[i] + nums[left] + nums[right];
                    if (res > 0)
                    {
                        right--;
                    }
                    else if (res < 0)
                    {
                        left++;
                    }
                    else
                    {
                        result.Add(new List<int>
                        {
                            nums[i], nums[left], nums[right]
                        });
                        while (left < right && nums[left] == nums[left + 1])
                        {
                            left++;
                        }
                        while (left < right && nums[right] == nums[right - 1])
                        {
                            right--;
                        }
                        left++;
                        right--;
                    }
                }
            }

            return result;
        }
    }
}
