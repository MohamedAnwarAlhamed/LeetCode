public class Solution {
    public int MyAtoi(string s) {
            // Step 1: Ignore leading whitespaces
            int i = 0, n = s.Length;
            while(i < n && s[i] == ' ')
            {
                i++;
            }

            // Step 2: Check for the sign
            int sign = 1;
            if(i < n && (s[i] == '-' || s[i] == '+'))
            {
                sign = s[i] == '-'? -1 : 1;
                i++;
            }
            // Step 3: Convert the digits to an integer
            int result = 0;
            while(i < n && Char.IsDigit(s[i]))
            {   
                //digit = s[i] - '0', where '0' is subtracted to convert the character to its integer form.
                int digit = s[i] - '0';
                // Step 4: Check for overflow/underflow before adding the digit
                if(result > (int.MaxValue - digit) / 10)
                {
                    return sign == 1 ? int.MaxValue : int.MinValue;
                }

                result = result * 10 + digit;
                i++;
            }

            return result * sign;
    }
}