public class Solution {
    public bool IsPalindrome(int x) {
        // Negative numbers are not palindromes
        if (x < 0)
            return false;

        // Calculate the reverse of the number
        int original = x;
        int reverse = 0;

        while (x != 0)
        {
            int pop = x % 10;
            x /= 10;
            reverse = reverse * 10 + pop;
        }

        // Check if the original number is equal to its reverse
        return original == reverse;
    }
}