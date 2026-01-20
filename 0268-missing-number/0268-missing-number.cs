public class Solution {
    public int MissingNumber(int[] nums) {
        int num = 0;
for (int i = 1; i <= nums.Length; i++)
{
    if (!nums.Contains(i))
    {
        num = i;
    }
}
return num;
    }
}