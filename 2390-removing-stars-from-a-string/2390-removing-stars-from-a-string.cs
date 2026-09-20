public class Solution {
    public string RemoveStars(string s) {
        return s.Aggregate(new StringBuilder(s.Length), (sb, c) 
            => c == '*' 
                ? sb.Remove(sb.Length - 1, 1) 
                : sb.Append(c))
            .ToString();
    }
}