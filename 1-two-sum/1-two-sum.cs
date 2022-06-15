public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i ++)
        {
            int complement = target - nums[i];
            if (dict.ContainsKey(complement))
            {
                return new int[] {dict[complement], i};
            }
            else if (dict.ContainsKey(nums[i]))
            {
                continue;
            }
            dict.Add(nums[i],i);
        }
        return null;
    }
}