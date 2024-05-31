public class Solution {
    public int HIndex(int[] citations)=>citations.OrderDescending()
                                                 .TakeWhile((c, i) => c > i)
                                                 .Count();
}