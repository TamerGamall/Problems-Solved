public class Solution {
    public int MajorityElement(int[] nums) {
        int n = nums.Length;
int newNum = 0 ;
int count=0;
for (int i = 0; i < nums.Length; i++)
{

    for(int j = 0; j< n; j++)
    {
        if(nums[i] == nums[j])
        {
            count++;
        }
    }
     if (count >= ((double)n / 2))
 {
     newNum = nums[i];
     count = 0;
     break;
    
 }
 else
{
    count = 0;
}
}
return(newNum);
    }
}