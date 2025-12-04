public class Solution {
    public int CountCollisions(string directions) {
        int n = directions.Length;
        int l = 0, r = n - 1;

        while (l < n && directions[l] == 'L') {
            l++;
        }

        while (r >= l && directions[r] == 'R') {
            r--;
        }

        int res = 0;
        for (int i = l; i <= r; i++) {
            if (directions[i] != 'S') {
                res++;
            }
        }
        return res;
    }
}