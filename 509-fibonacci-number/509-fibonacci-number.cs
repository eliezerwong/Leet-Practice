public class Solution {
    public int Fib(int n) {
        //reverse recursion from n call stack
        return n < 2 ? n : Fib(n-1) + Fib(n-2);
    }
}