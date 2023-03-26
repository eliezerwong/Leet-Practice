class Solution {
    public int[] intersection(int[] nums1, int[] nums2) {
        //HashSet stores unique values only, skips duplicates
        HashSet<Integer> set = new HashSet();
        HashSet<Integer> res = new HashSet();

        for(int var : nums1)
        {
            set.add(var);
        }

        for(int var : nums2)
        {
            if(set.contains(var)){
                res.add(var);
            }
        }

        int[] arr = new int[res.size()];
        int i = 0;
        for(int var : res)
        {
            arr[i++] = var;
        }

        return arr;
    }
}