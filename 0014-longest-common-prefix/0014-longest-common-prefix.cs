public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string prefix = "";

string first = strs[0];

for (int i = 0; i < first.Length; i++)
{
    for (int j = 1; j < strs.Length; j++)
    {
        if (i >= strs[j].Length || first[i] != strs[j][i])
        {
            return prefix;
        }
    }
    prefix += first[i];
}

return prefix;

    }
}