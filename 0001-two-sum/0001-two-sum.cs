public class Solution {
    public int[] TwoSum(int[] nums, int target)
{
    int[] array = new int[2];
    Console.WriteLine(array);
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                if(i == j){
                    continue;
                }
                array[0]=i;
                array[1]=j;
                return array;
                

            }
        }
    }
    
    return null;
}
}