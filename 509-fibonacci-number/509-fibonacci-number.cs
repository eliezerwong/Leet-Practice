public class Solution {
    public int Fib(int n) {
        return n < 2 ? n : Fib(n-1) + Fib(n-2);
    }
}