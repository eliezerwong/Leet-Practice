public class Solution {
    public int Fib(int n) {
        if(n < 2)
        {
            return n;
        }
        
        
        int prev = 1;
        int prevPrev = 0;        
        int result = 0;
        
        for(int i = 2; i <= n; i++)
        {
            result = prev + prevPrev;
            prevPrev = prev;
            prev = result;
        }
        
        return result;
    }
}