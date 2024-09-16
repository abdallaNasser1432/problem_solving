public class Solution {
    public int FindMinDifference(IList<string> timePoints) {
        
        int[] timeInMinutes = new int[timePoints.Count()];
        for(int i=0;i<timePoints.Count();i++){
            var values = timePoints[i].Split(':');
            timeInMinutes[i] =Convert.ToInt32(values[0])*60+Convert.ToInt32(values[1]);
        }
        Array.Sort(timeInMinutes);
        int min=Int32.MaxValue;

        for(int i=0;i<timeInMinutes.Length-1;i++){
            min = Math.Min(min, timeInMinutes[i+1]-timeInMinutes[i]);
        }

        min = Math.Min(min,(24*60+timeInMinutes[0])-timeInMinutes[timeInMinutes.Length-1]);
        return min;
    }
}