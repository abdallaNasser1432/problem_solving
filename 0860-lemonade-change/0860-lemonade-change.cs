public class Solution {
    public bool LemonadeChange(int[] bills) {
        int five_dollar = 0, ten_dollar = 0;
        for (int i = 0; i < bills.Length; i++)
        {
            if (bills[i] == 5) five_dollar++;
            else if (bills[i]==10)
            {
                if (five_dollar > 0) five_dollar--;
                else return false;
                ten_dollar++;
            }
            else
            {
                if (five_dollar > 0 && ten_dollar > 0)
                {
                    five_dollar--;
                    ten_dollar--;
                }
                else if (five_dollar > 2)
                    five_dollar -= 3;
                else return false;
            }

        }
        return true;
    }
}