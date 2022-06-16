public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int i = 0;
        foreach (var num in nums)
        {
            //if to skip over duplicates
            if(nums[i] != num)
            {
                //when the value of nums[index] is not the same as the current num in arr, 
                    //we change the value of the next index to the current num
                    //eg, int[] nums = {0, 1, 1, 1, 2, 4, 4, 5}
                    //when i = 0 on the first loop, int[] nums = {0, 1, 1, 1, 2, 4, 4, 5}
                    //i = 0 on the 2nd loop, 0 != 1, hence, int[1] = 1
                    //i = 1 on the 3rd loop, nothing happens.
                    //i = 1 on the 4th loop, nothing happens.
                    //i = 1 on the 5th loop, 1 != 2, hence, int[2] = 2
                    //end result int[] nums = {0, 1, 2, 4, 5} and i = 4
                nums[++i] = num;
            }
        }
        //add 1 to count index 0
        return i + 1;
    }
}
