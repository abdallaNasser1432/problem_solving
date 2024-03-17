public class Solution {
    public  int[][] Insert(int[][] intervals, int[] newInterval)
{
    List<List<int>> list = new List<List<int>>(); bool isInserted = false;
    foreach (var item in intervals)
    {
        if ((item[0] > newInterval[0] && item[0] > newInterval[1] && !isInserted))// ---- #####
        {
            list.Add([newInterval[0], newInterval[1]]);
            list.Add([item[0], item[1]]);
            isInserted = true;
        }
        else if ((item[0] > newInterval[0] && item[1] < newInterval[1])) continue; // ----#####-----
        else if ((item[0] <= newInterval[0] && item[1] >= newInterval[0]&& item[1] < newInterval[1])) // ##-----###-----
        {
            newInterval[0] = item[0];
        }
        else if ((item[0] >= newInterval[0] && item[1] >= newInterval[1] && item[0] <= newInterval[1]))// -----####----#####
        {
            list.Add([newInterval[0], item[1]]);
            isInserted = true;
        }

        else
{
    if ((item[0] <= newInterval[0] && item[1] >= newInterval[1])) isInserted=true;
    list.Add([item[0], item[1]]);
}
    }
    if (!isInserted) list.Add([newInterval[0], newInterval[1]]);

    return list.Select(i=> i.ToArray()).ToArray();
}
}