public class Solution {
    public bool CanArrange(int[] arr, int k) {
        
        int[] frequency = new int[k];
        for (int i = 0; i < arr.Length; i++)
        {
            int num = arr[i];
            num %= k;
            if (num < 0) num += k;
            frequency[num]++;
        }

        if (frequency[0] % 2 != 0) return false;

        for (int i = 1; i <= k / 2; i++)
        {
            if (frequency[i] != frequency[k - i]) return false;
        }

        return true;

 
    }
}