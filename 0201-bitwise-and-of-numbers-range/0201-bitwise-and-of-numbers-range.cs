public class Solution {
    public int RangeBitwiseAnd(int left, int right) {
        var cnt = 0;
        while (left != right) {
            left >>= 1;
            right >>= 1;
            cnt++;
        }
        return left << cnt;
    }
}