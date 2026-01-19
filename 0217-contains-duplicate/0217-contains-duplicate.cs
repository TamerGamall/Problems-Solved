public class Solution {
    public bool ContainsDuplicate(int[] nums) {
     HashSet<int> seen = new HashSet<int>(); // مجموعة لتخزين العناصر اللي شفناها
bool flag = false;

foreach (int num in nums)
{
    if (seen.Contains(num)) // لو العنصر موجود
    {
        flag = true;
        break; // نوقف البحث فورًا
    }
    seen.Add(num); // لو مش موجود → نضيفه
}
return flag;
    }
}