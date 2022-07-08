public class Solution {
    public int PivotIndex(int[] nums) {
        int leftsum = 0;
        int total = 0;
        foreach(var num in nums)
        {
            total += num;
        }
        for(int i = 0; i < nums.Length; i++)
        {
            if(leftsum == total - leftsum - nums[i])
            {
                return i;
            }
            leftsum += nums[i];
        }
        return -1;
    }
}