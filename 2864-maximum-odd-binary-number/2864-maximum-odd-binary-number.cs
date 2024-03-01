public class Solution {
    public string MaximumOddBinaryNumber(string s) =>
        new string('1', s.Count(c => c == '1') - 1) +
        new string('0', s.Count(c => c == '0')) + '1';
}