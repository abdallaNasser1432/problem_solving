public class Solution {
    public int[] MinOperations(string boxes) {

        int[] result = new int[boxes.Length];
        List<int>onespostions = new List<int>();

        for (int i = 0; i < boxes.Length; i++)
        {
            if (boxes[i] - '0' == 1)
            {
                onespostions.Add(i);
                result[0] += i;
            }
        }

        int leftBalls = 0; int rightBalls = onespostions.Count;
        int j = 0;
        for (int i = 1; i < boxes.Length; i++)
        {
            if(j<onespostions.Count && i > onespostions[j])
            {
                j++;
                leftBalls++;
                rightBalls--;
            }
            result[i] = result[i - 1] + leftBalls - rightBalls;
        }

        return result;
    }
}
// 0 0 1 0 1 1
// 0 1 2 3 4 5
// 11 8 5 4 3 