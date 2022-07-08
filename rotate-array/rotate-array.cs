public class Solution {
    public void Rotate(int[] nums, int k) {
        var arr = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            arr[(i + k)  % nums.Length] = nums[i];
        }
        for(int i = 0; i < nums.Length; i++)
        {
            nums[i] = arr[i];
        }
    }
}