public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (count == 3) return true;
            if (arr[i] % 2 == 1)
            {
                count++;
            }
            else
                count = 0;
        }
        return (count == 3);
    }
}