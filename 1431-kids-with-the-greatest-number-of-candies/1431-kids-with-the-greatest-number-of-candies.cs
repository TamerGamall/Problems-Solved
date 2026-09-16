public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
         int x = candies.Max();
 var result = new List<bool>();
for(int i =0; i<candies.Length; i++)
 {
     if (candies[i] + extraCandies < x)
     {
         result.Add(false);
     }
     else
     {
         result.Add(true);
     }
 }

 return result;
    }
}