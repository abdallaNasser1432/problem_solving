public class Solution {
    public int MatchPlayersAndTrainers(int[] players, int[] trainers) {
        int count = 0; int i = 0;
        Array.Sort(players, (a, b) => b.CompareTo(a));
        Array.Sort(trainers, (a, b) => b.CompareTo(a));

        for (int j = 0; j < trainers.Length; j++)
        {
            while(i < players.Length)
            {
                if (trainers[j] >= players[i++])
                {
                    count++;
                    break;
                }
            }
            if (i >= players.Length)
                break;
        }
        return count;
    }
}