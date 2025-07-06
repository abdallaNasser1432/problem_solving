public class FindSumPairs {

    private int[] _nums1 = Array.Empty<int>();
    private int[] _nums2 = Array.Empty<int>();
    private Dictionary<int, int> freq = new Dictionary<int, int>();

    public FindSumPairs(int[] nums1, int[] nums2)
    {
        _nums1 = nums1;
        _nums2 = nums2;
        foreach (int i in _nums1)
        {
            if (freq.ContainsKey(i)) freq[i]++;
            else freq[i] = 1;
        }
    }

    public void Add(int index, int val) =>  _nums2[index] += val;


    public int Count(int tot) => _nums2.Sum(p=> freq.ContainsKey(tot - p) ? freq[tot-p] : 0);
    
    }

/**
 * Your FindSumPairs object will be instantiated and called as such:
 * FindSumPairs obj = new FindSumPairs(nums1, nums2);
 * obj.Add(index,val);
 * int param_2 = obj.Count(tot);
 */