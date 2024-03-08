public class Solution {
    public  int TotalFruit(int[] fruits){
    int maxFruit = 0; int basket1 = -1; int basket2 =-1; int count1 = 0; int prevCount = 0;
    for (int i = 0; i < fruits.Length; i++)
    {
        if (fruits[i] == basket2 || fruits[i] == basket1) count1++;
        else
        {
            maxFruit = Math.Max(maxFruit, count1);
            count1 = prevCount + 1;
        }
        if (basket1 == fruits[i]) prevCount++;
        else
        {
            prevCount = 1;
            basket2 = basket1;
            basket1 = fruits[i];
        }
    }
    maxFruit = Math.Max(maxFruit, count1);
    return maxFruit;
  }
}