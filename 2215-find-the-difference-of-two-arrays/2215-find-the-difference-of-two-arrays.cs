public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        HashSet<int> difference1 = new HashSet<int>(nums1), difference2 = new HashSet<int>(nums2);

        return [ 
            difference1.Where(num => !difference2.Contains(num)).ToList(), 
            difference2.Where(num => !difference1.Contains(num)).ToList()
               ]; 
    }
}