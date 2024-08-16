public class Solution {
    public int MaxDistance(IList<IList<int>> arrays) {
        int maxDiff = 0 , smallest = arrays[0][0] , biggest = arrays[0][arrays[0].Count-1];
        for(int i = 1 ; i < arrays.Count ; i++){
            
            maxDiff = Math.Max(maxDiff,Math.Abs(arrays[i][arrays[i].Count -1] - smallest));
            maxDiff = Math.Max(maxDiff,Math.Abs(biggest - arrays[i][0]));
            
            smallest = Math.Min(smallest , arrays[i][0]);
            biggest = Math.Max(biggest , arrays[i][arrays[i].Count -1]);
        }
        return maxDiff;
    }
}