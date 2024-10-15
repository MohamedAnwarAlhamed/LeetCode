public class Solution {
    public string LongestPalindrome(string s) {
        if(string.IsNullOrEmpty(s))
        {
            return "";
        }

        int start = 0, end = 0;

        for(int i = 0; i < s.Length; i++)
        {
            int len1 = ExpandAroundCenter(s, i, i); // s, 0,0 // 1
            int len2 = ExpandAroundCenter(s, i, i + 1); // s,0,1 // 0
            int len = Math.Max(len1, len2); // 1

            if(len > end - start)
            {
                start = i - (len - 1) / 2;
                end = i + len / 2;

            }
        }
        return s.Substring(start, end - start + 1);
    }
     private int ExpandAroundCenter(string s, int left, int right) //s, 0, 1
     {
        while(left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--; // -1
            right++; // 1
        }
        return right - left - 1;
     }
}