public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
            if(nums.Length == 0)
    {
        return new List<string> {};
    }
    int start = nums[0];
    int end = 0;
    List<string> l = new List<string>();
for (int i = 1; i < nums.Length; i++)
{
    if (nums[i] != nums[i - 1] + 1)
    {
        end = nums[i - 1];
        if (start == end)
            l.Add(end.ToString());
        else
            l.Add($"{start}->{end}");
        start = nums[i];
    }
}


int last = nums[nums.Length - 1];
if (start == last)
    l.Add(last.ToString());
else
    l.Add($"{start}->{last}");

    return l;
}
    }
