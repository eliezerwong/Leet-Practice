public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s.Length == 0)
        {
            return true;
        }
        
        //double pointer method to bool j against s.Length
        int j = 0;
        for (int i = 0; i < t.Length; i++)
        {
            //j < s.Length in case duplicate of s[j], will push pointer out of bounds
            if(j < s.Length && t[i] == s[j])
            {
                j++;
            }
        }
        return j == s.Length;
    }
}