public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int i = 0;
        foreach (var num in nums)
        {
            if(nums[i] != num)
            {
                nums[++i] = num;
            }
        }
        return i + 1;
    }
}