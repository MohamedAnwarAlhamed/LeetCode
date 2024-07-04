public class Solution {
    public bool IsPalindrome(string s) {
        if (string.IsNullOrEmpty(s))
            return true;

        // Convert to lowercase and remove non-alphanumeric characters
        s = s.ToLower();
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            // Increment left index if current character is not alphanumeric
            if (!char.IsLetterOrDigit(s[left]))
            {
                left++;
                continue;
            }

            // Decrement right index if current character is not alphanumeric
            if (!char.IsLetterOrDigit(s[right]))
            {
                right--;
                continue;
            }

            // Check if characters at left and right index are equal
            if (s[left] != s[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}