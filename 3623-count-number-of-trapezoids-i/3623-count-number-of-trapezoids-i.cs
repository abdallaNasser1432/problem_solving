public class Solution {
    public int CountTrapezoids(int[][] points) {
        
        const long MOD = 1000000007;

        var map = new Dictionary<int, long>();
        foreach (var p in points) {
            int y = p[1];
            if (!map.ContainsKey(y)) map[y] = 0;
            map[y]++;
        }

        var seg = new List<long>();
        foreach (var kv in map) {
            long k = kv.Value;
            if (k >= 2) seg.Add(k * (k - 1) / 2 % MOD);
        }

        long sum = 0, ans = 0;
        foreach (var v in seg) {
            ans = (ans + v * sum) % MOD;
            sum = (sum + v) % MOD;
        }

        return (int)ans;
    }
}