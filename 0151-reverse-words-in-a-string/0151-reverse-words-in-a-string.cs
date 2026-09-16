public class Solution {
    public string ReverseWords(string s) {
          s.Trim();
  string newString =  s.Split(' ')
      .Where(word => !string.IsNullOrWhiteSpace(word))
      .Reverse()
      .Aggregate((current, next) => current + " " + next);
  return newString;
    }
}