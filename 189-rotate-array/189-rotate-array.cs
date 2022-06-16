public class Solution {
    public void Rotate(int[] nums, int k) {
        int[] arr = new int[nums.Length];
        for(int i = 0; i < nums.Length; i ++)
        {
            //eg, k = 3 & nums.Length = 20 for 1st pass, 3 % 20 = 3, hence arr[3] = nums[0];
            // when i = 19, (19 + 3) % 20 = 2, arr[2] = nums[19];
            arr[(i + k) % nums.Length] = nums[i];
        }
        
        //need to replace the original array int[] nums with our rotated array int[] arr;
        for(int i = 0; i < nums.Length; i ++)
        {
            nums[i] = arr[i];
        }
    }
}