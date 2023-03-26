public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int, int> dict = new Dictionary<int,int>();
        List<int> lst = new List<int>();

        foreach (var num in nums1)
        {
            dict.TryAdd(num, 0);
            if (dict.ContainsKey(num))
            {
                dict[num] += 1;
            }
        }   

        for (int i = 0; i < nums2.Length; i++)
        {
            if (dict.ContainsKey(nums2[i]) && dict[nums2[i]] > 0)
            {
                lst.Add(nums2[i]);
                dict[nums2[i]] = dict[nums2[i]]-1;
            }
        }
        
        int[] arr = new int[lst.Count];
        for (int i = 0; i < lst.Count; i++)
        {
            arr[i] = lst[i];
        }
        return arr;
    }
}