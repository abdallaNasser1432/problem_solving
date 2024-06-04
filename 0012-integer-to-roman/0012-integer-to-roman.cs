public class Solution {
    public  string IntToRoman(int num)
{
    
    
    StringBuilder roman = new StringBuilder();
    string digts = num.ToString(); int Count = digts.Length;
    for (int i = 0; i < digts.Length; i++)
    {
        if(Count == 4)
        {
            roman.Append('M', digts[i]-'0');
        }
        else if (Count == 3)
        {
            if(digts[i] - '0' < 4) roman.Append('C', digts[i] - '0');
            else if(digts[i] - '0' == 4) roman.Append("CD");
            else if(digts[i] - '0' == 9) roman.Append("CM");
            else
            {
                roman.Append('D');
                roman.Append('C', (digts[i] - '0') -5);
            }
        }
        else if (Count == 2)
        {
            if (digts[i] - '0' < 4) roman.Append('X', digts[i] - '0');
            else if (digts[i] - '0' == 4) roman.Append("XL");
            else if (digts[i] - '0' == 9) roman.Append("XC");
            else
            {
                roman.Append('L');
                roman.Append('X', digts[i] - '0' - 5);
            }
        }
        else if (Count == 1)
        {
            if (digts[i] - '0' < 4) roman.Append('I', digts[i] - '0');
            else if (digts[i] - '0' == 4) roman.Append("IV");
            else if (digts[i] - '0' == 9) roman.Append("IX");
            else
            {
                roman.Append('V');
                roman.Append('I', (digts[i] - '0') - 5);
            }
        }
        Count--;
    }

    return roman.ToString();
}
}