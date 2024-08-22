public class Solution {
    public int FindComplement(int num)=> Convert.ToInt32(string.Join("", Convert.ToString(num, 2).Select(b => b == '0' ? '1' : '0')), 2);
        
    
}