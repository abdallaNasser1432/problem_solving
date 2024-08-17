public class Solution {
    public int LargestAltitude(int[] gain) {
                
        int heighest_altitude = Math.Max(0,gain[0]);
        
        for(int i = 1 ; i < gain.Length ; i++){
            gain[i]+=gain[i-1];
            heighest_altitude = Math.Max(gain[i],heighest_altitude);
        }
        return heighest_altitude;
    }
}