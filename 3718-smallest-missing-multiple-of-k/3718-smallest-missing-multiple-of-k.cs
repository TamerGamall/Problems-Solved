public class Solution {
    public int MissingMultiple(int[] nums, int k) {
        int n = k;
    Array.Sort(nums);
    for(int i=0; i< nums.Length; i++)
    {
        if (nums[i] % k == 0)
        {
            if (!nums.Contains(k))
                return n = k;
            if(!nums.Contains(nums[i] + k))
            {
                n = nums[i] + k;
                return n;
            }
        }    
    }
    return n;
}
}