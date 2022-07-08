public class Solution {
    public int SingleNumber(int[] nums) {
        //HashSet does not allow you to access values. Use list instead
        var set = new List<int>();
        foreach (var num in nums)
        {
            //if it exists, remove it from list since all appears twice except 1
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