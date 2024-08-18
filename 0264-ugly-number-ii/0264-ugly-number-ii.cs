public class Solution {
    public int NthUglyNumber(int n) {
        SortedSet<long> uglyNumbersSet = new SortedSet<long>(); 
        uglyNumbersSet.Add(1L); 

        long currentUgly = 1L;
        for (int i = 0; i < n; i++)
        {
            currentUgly = uglyNumbersSet.First();
            uglyNumbersSet.Remove(currentUgly); 


            uglyNumbersSet.Add(currentUgly * 2);
            uglyNumbersSet.Add(currentUgly * 3);
            uglyNumbersSet.Add(currentUgly * 5);
        }

        return (int)currentUgly; 
    }
}