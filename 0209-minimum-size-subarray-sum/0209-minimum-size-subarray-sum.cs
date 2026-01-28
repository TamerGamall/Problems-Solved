public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
         
            int left =0  ,sum=0 , right =0 , minLength = int.MaxValue;
            for ( right =0; right < nums.Length; right++)
            {
                sum += nums[right];

                while (sum >= target)
                {
                   
                    minLength = Math.Min(minLength,right - left +1);
                    sum -= nums[left];
                    left++;
                }
                
            }
            if (minLength == int.MaxValue)
                minLength = 0;
        return(minLength);

    }
}