public class Solution {
    public int NumIslands(char[][] grid) {
        //like flood fill but with counter. 
        //basically go through each item on the grid and find all the other "1"s that are 4 directionally connected through recursion.
        //to tell if the island has been passed over and counted, change the value to demarcate it
        
        int counter = 0;
        //double pointer for loop to go through each item in the 2d array
        //i for rows
        for(int i = 0; i < grid.Length; i++)
        {
            //j for columns, going from left to right, top to bottom
            for(int j = 0; j < grid[i].Length; j++)
            {
                //when encounter land ("1"), run method to find other 4-direc connected "1"s, method changes all "1"s passed over to "2"s
                //any "1"s not 4-direc connected are islands and will increase the counter
                if(grid[i][j] == '1')
                {
                    depthFirstSearch(grid, i, j);
                    counter++;  
                }
            }
        }
        return counter;
    }
    
    public void depthFirstSearch(char[][] grid, int i, int j)
    {
        //baseline: ensure not out of bounds && land has not been passed over before && not water ('0')
        if(i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == '2' || grid[i][j] == '0')
        {
            return;
        }
        
        //change to 2 to mark as passed over
        grid[i][j] = '2';
        
        //recursion to move around 2d array
        depthFirstSearch(grid ,i + 1, j);
        depthFirstSearch(grid ,i - 1, j);
        depthFirstSearch(grid ,i , j + 1);
        depthFirstSearch(grid ,i , j - 1);
    }
}