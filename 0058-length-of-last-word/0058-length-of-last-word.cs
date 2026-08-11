public class Solution {
    public int LengthOfLastWord(string s) {
       string[] list = s.Trim().Split(' ');
string l = list[list.Length - 1];
return l.Length;
    }
}