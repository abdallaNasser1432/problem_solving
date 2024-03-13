public class Solution {
    public int PivotInteger(int n) {
        int sumAll = (n * (n + 1)) / 2;
        for (int i = 1 ; i <= n; i++)
        {
            int sumI= ((i * (i + 1)) / 2);
            if (sumI== sumAll-sumI+i) return i;
        }
        return -1;
    }
}