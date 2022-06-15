public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        List<int> check = new List<int>();
        
        foreach (var item in nums)
        {
            if(check.Contains(item))
            {
                return true;
            }
            else
            {
                check.Add(item);
            }
        }
        return false;
    }
}