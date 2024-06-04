public class Solution {
    public  string IntToRoman(int num){
        string[]  array = ["V","IX","IV","I","L","XC","XL","X","D","CM","CD","C"];
        StringBuilder roman = new StringBuilder();
        string digts = num.ToString(); int Count = digts.Length,index;
        for (int i = 0; i < digts.Length; i++)
        {
            if(Count == 4)
            {
                roman.Append('M', digts[i]-'0');
            }
            else
            {
                index = 4 * Count;
                if (digts[i] - '0' < 4) roman.Append(char.Parse(array[index-1]), digts[i] - '0');
                else if (digts[i] - '0' == 4) roman.Append(array[index - 2]);
                else if (digts[i] - '0' == 9) roman.Append(array[index - 3]);
                else
                {
                    roman.Append(array[index - 4]);
                    roman.Append(char.Parse(array[index - 1]), (digts[i] - '0') - 5);
                }
            }
            Count--;
        }
        return roman.ToString();
    }

}