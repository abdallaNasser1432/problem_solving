public class RandomizedSet {

    private List<int> nums;
    private Dictionary<int,int> map;
    private Random rand;

    public RandomizedSet() 
    {
        map = new Dictionary<int,int>();
        nums = new List<int>();
        rand = new Random();
    }
    
    public bool Insert(int val) 
    {
        if (map.ContainsKey(val))
        {
            return false;
        }
        
        nums.Add(val);
        map.Add(val, nums.Count-1);
        
        return true;
    }
    
    public bool Remove(int val) 
    {
        if (!map.ContainsKey(val))
        {
            return false;
        }
        
        int i = map[val];
        nums[i] = nums[nums.Count-1];
        map[nums[i]] = i;
        
        nums.RemoveAt(nums.Count-1);
        map.Remove(val);
        
        return true;
    }
    
    public int GetRandom() 
    {
        return nums[rand.Next(0,nums.Count)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */