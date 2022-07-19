public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        //if the start cell color is already the same as the color to change, nothing to be done
        if(image[sr][sc] == color)
        {
            return image;
        }
        //method to change image to newColor
        fill(image, sr, sc, image[sr][sc], color);
        
        return image;
    }
    
    public void fill(int[][] image, int sr, int sc, int oldColor, int newColor)
    {
        //baseline: check current cell to ensure not out of bounds && same color as the previous (oldColor)
        //for 2d array image.Length returns # rows, image[sr].Length returns # columns in selected row
        if(sr < 0 || sr >= image.Length || sc < 0 || sc >= image[sr].Length || image[sr][sc] != oldColor)
        {
            return;
        }
        
        //change the color of the cell that passes above to the newColor
        image[sr][sc] = newColor;
        
        //recursive call to move around the the 2d array until baseline, row + 1, row - 1, column + 1, column -1
        fill(image, sr + 1, sc, oldColor, newColor);
        fill(image, sr - 1, sc, oldColor, newColor);
        fill(image, sr, sc + 1, oldColor, newColor);
        fill(image, sr, sc - 1, oldColor, newColor);
    }

}