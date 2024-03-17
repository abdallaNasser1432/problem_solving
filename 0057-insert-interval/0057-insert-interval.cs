public class Solution {
    public  int[][] Insert(int[][] intervals, int[] newInterval){
        List<List<int>> list = new List<List<int>>();
        foreach (var item in intervals)
        {
            if (item[0] > newInterval[1])// ---- #####
            {
                list.Add([newInterval[0], newInterval[1]]);
                newInterval = item;
            }
            else if (item[1] < newInterval[0])// ######## ----
                list.Add([item[0], item[1]]);
            else
            {
                newInterval[0] = Math.Min(newInterval[0], item[0]);
                newInterval[1] = Math.Max(newInterval[1], item[1]);
            }
        }
        list.Add([newInterval[0], newInterval[1]]);
        return list.Select(i => i.ToArray()).ToArray();
    }
}