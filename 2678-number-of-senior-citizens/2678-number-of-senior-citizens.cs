public class Solution {
    public int CountSeniors(string[] details) {
        int count = 0;
        for (int i = 0; i < details.Length; i++)
        {
            if ( details[i][11] > 54 || (details[i][12] > 48 && details[i][11] == 54 ) ) count++;
        }
        return count;
    }
}