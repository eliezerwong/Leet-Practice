class Solution {
    public int uniquePaths(int m, int n) {
        //multidimensional arr to store the different ways of getting to each coordinate
        int[][] dp = new int[m][n];
        
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                //1st row & 1st column only has 1 way of getting there
                if(i == 0 || j == 0)
                {
                    dp[i][j] = 1;
                }
                else
                {
                    //# of ways to get to a point = the sum of the number of ways to get to the points leading up to such
                    dp[i][j] = dp[i - 1][j] + dp[i][j - 1];
                }
            }
        }
        
        return dp[m - 1][n - 1];
    }
}