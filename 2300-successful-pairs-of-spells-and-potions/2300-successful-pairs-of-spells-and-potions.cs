public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        
            Array.Sort(potions);
            int[] pairs = new int[spells.Length];

            for (int i = 0; i < spells.Length; i++)
            {
                long spell = spells[i];
                int left = 0, right = potions.Length - 1;

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (spell * potions[mid] >= success)
                        right = mid - 1;
                    else
                        left = mid + 1;
                }

                pairs[i] = potions.Length - left;
            }

            return pairs;

    }
}