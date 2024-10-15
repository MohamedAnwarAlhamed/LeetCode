public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        if(string.IsNullOrEmpty(s))
        {
            return 0;
        }
        Dictionary<char, int> CharIndexMap = new Dictionary<char, int>();
        int maxLength = 0;
        int left = 0;

        for(int right = 0; right < s.Length; right++)
        {
            char currentChar = s[right]; // 3

            if(CharIndexMap.ContainsKey(currentChar))
            {
                left = Math.Max(CharIndexMap[currentChar] + 1, left); // 3
            }

            maxLength = Math.Max(maxLength, right - left + 1); // 1

            CharIndexMap[currentChar] = right;
        }
        return maxLength;
    }
}