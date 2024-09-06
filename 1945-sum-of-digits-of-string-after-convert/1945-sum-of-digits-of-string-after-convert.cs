public class Solution {
    public int GetLucky(string s, int k) {
        int currentNumber = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int position = s[i] - 'a' + 1;
            while (position > 0)
            {
                currentNumber += position % 10;
                position /= 10;
            }
        }


        for (int i = 1; i < k; ++i)
        {
            int digitSum = 0;
            while (currentNumber > 0)
            {
                digitSum += currentNumber % 10;
                currentNumber /= 10;
            }
            currentNumber = digitSum;
        }

        return currentNumber;
    }
}