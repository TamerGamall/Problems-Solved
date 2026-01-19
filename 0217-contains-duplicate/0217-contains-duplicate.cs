public class Solution {
    public bool ContainsDuplicate(int[] nums) {
     HashSet<int> seen = new HashSet<int>(); 
     bool flag = false;

foreach (int num in nums)
{
    if (seen.Contains(num)) 
    {
        flag = true;
        break; 
    }
    seen.Add(num); 
    }
return flag;
    }
}