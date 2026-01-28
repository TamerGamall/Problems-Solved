public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
         int x = 0;
 foreach (string operation in operations)
 {
     if (operation[0] == '-' || operation[2] == '-')
     {
         --x;
     }
     else if(operation[0] == '+' || operation[2] == '+')
     {
         ++x;
     }
     
 }
 return x;
    }
}