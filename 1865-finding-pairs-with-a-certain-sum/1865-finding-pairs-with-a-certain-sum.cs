public class FindSumPairs {

    private int[] _nums1 = Array.Empty<int>();
    private int[] _nums2 = Array.Empty<int>();
    private Dictionary<int, int> freq2 = new Dictionary<int, int>();

    public FindSumPairs(int[] nums1, int[] nums2)
    {
        _nums1 = nums1;
        _nums2 = nums2;
        foreach (int i in _nums2)
        {
            if (freq2.ContainsKey(i)) freq2[i]++;
            else freq2[i] = 1;
        }
    }

    public void Add(int index, int val)
    {
        int oldVal = _nums2[index];
        int newVal = oldVal + val;

        
        _nums2[index] = newVal;

        freq2[oldVal]--;
        if (freq2[oldVal] == 0)
            freq2.Remove(oldVal);

        if (!freq2.ContainsKey(newVal))
            freq2[newVal] = 0;
        freq2[newVal]++;
    }


    public int Count(int tot) => _nums1.Sum(p => freq2.ContainsKey(tot - p) ? freq2[tot - p] : 0);

    }

/**
 * Your FindSumPairs object will be instantiated and called as such:
 * FindSumPairs obj = new FindSumPairs(nums1, nums2);
 * obj.Add(index,val);
 * int param_2 = obj.Count(tot);
 */