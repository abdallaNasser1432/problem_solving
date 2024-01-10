public class Solution {
     public int MajorityElement(int[] nums)
        {
            Hashtable hash = new Hashtable();
            
            foreach (var item in nums)
                if (hash.ContainsKey(item))
                    hash[item] = (int)hash[item] + 1;
                else
                    hash.Add(item, 1);

            foreach (var key in hash.Keys)
                if ((int)hash[key] > nums.Length / 2)
                    return (int)key;

            return -1;
        }
}