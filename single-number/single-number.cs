public class Solution {
    public int SingleNumber(int[] nums) {
        var set = new List<int>();
        foreach (var num in nums)
        {
            if(set.Contains(num))
            {
                set.Remove(num);
            }
            else
            {
                set.Add(num);
            }
        }
        return set[0];
    }
}