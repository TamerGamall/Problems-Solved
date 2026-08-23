public class Solution {
    public int FindPeakElement(int[] nums) {
         int l = 0;
 int r = nums.Length - 1;
 for (int i = 0; i <= nums.Length; i++)
 {
     if (r == l)
         return r;
     
     if (nums[l] <nums [r])
     {
         l++;
     }
     else
     {
         r--;
     }
 }
     return -1;
    }
}