public class Solution {
    public int ClimbStairs(int n) {
        if (n < 3)
        {
            return n;
        }
        
        int prevPrev = 1, prev = 1, result = 0;
        
        for(int i = 2; i <= n; i++)
        {
            result = prevPrev + prev;
            prevPrev = prev;
            prev = result;
        }
        
        return result;
    }
}