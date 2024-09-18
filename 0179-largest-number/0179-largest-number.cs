public class Solution {
    public string LargestNumber(int[] nums) {
        
            var stringArray = nums.Select(x => x.ToString()).ToArray();

            Array.Sort(stringArray, (string s1, string s2) =>
            {
                var str1 = s1 + s2;
                var str2 = s2 + s1;
                return str2.CompareTo(str1);
            });
        
             if(stringArray[0].Equals("0"))
            {
                return "0";
            }

            return string.Join("", stringArray);
    }
}