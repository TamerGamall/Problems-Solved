public class Solution {
    public int TitleToNumber(string columnTitle) {
        columnTitle = columnTitle.ToUpperInvariant();
int result=0;
foreach(char c in columnTitle)
{

result = result * 26 + (c - 'A' + 1);
}
return result;
    }
}