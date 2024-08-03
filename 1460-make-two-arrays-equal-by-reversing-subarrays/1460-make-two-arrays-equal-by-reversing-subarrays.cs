public class Solution {
    public bool CanBeEqual(int[] target, int[] arr) {
        Dictionary<int, int> freq = new Dictionary<int, int>();

        for (int i = 0; i < target.Length; i++)
        {
            if (!freq.ContainsKey(target[i])) freq.Add(target[i], 1);
            else freq[target[i]]++;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (!freq.ContainsKey(arr[i]) || freq[arr[i]] <= 0) return false;
            else freq[arr[i]]--;
        }
        return true;
    }
}