using System.Text.RegularExpressions;

public partial class Solution
{
    public bool IsPalindrome(string s)
    {
        if (s == null) return true;
        s = Regex.Replace(s, @"\W", string.Empty, RegexOptions.IgnoreCase).ToLower();
        if (s.Length == 0) return true;

        var count = 0;
        while (count < s.Length / 2 + 1)
        {
            if (s[count] != s[s.Length - count - 1]) return false;

            count++;
        }

        return true;
    }
}