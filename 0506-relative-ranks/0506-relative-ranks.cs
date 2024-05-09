public class Solution {
    public string[] FindRelativeRanks(int[] score) {
    
        string[] result = new string[score.Length];
        Dictionary<int, int> rankMap = new Dictionary<int, int>();

        for (int i = 0; i < score.Length; i++) rankMap[score[i]] = i;

        
        Array.Sort(score, (a, b) => b.CompareTo(a));

        
        for (int i = 0; i < score.Length; i++) {
            int rank = i + 1;
            if (rank == 1) result[rankMap[score[i]]] = "Gold Medal";
            else if (rank == 2) result[rankMap[score[i]]] = "Silver Medal";
            else if (rank == 3) result[rankMap[score[i]]] = "Bronze Medal";
            else result[rankMap[score[i]]] = rank.ToString();
        }

        return result;
    }
}