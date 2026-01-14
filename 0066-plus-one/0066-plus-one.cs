public class Solution {
    public int[] PlusOne(int[] digits) {
         
 string dig = "";
 BigInteger plus;
 for (int i = 0; i < digits.Length; i++)
 {
     dig += digits[i];
 }
 plus = BigInteger.Parse(dig) + 1;
 dig = Convert.ToString(plus);
 int[] arr = new int[dig.Length];
 for (int i = 0; i < dig.Length; i++)
 {
     int number = dig[i] - '0';
     
     arr[i] = number;
     
 }
 return arr;
    }
}