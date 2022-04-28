using System.Linq;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Class that contains math methods
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Method that return max number from an list
        /// </summary>
        public static int Max(List<int> nums)
        {
            if (nums.Count > 0)
            {
                nums.Sort();
                int num = nums[nums.Count() - 1];
                return num;
            }
            else
                return 0;
        }
    }
}
