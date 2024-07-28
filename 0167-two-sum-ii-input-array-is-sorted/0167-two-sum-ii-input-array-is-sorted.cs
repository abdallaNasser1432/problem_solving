public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0, h = numbers.Length - 1;
        while(l < h)
        {
            if (numbers[l] + numbers[h] > target) h--;
            else if (numbers[l] + numbers[h] < target) l++;
            else
                return [++l, ++h];
        }
        return [];
    }
}