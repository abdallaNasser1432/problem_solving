public class Solution {
    public int NumRescueBoats(int[] people, int limit){

        Array.Sort(people);
        int l = 0,count = 0, h = people.Length - 1;
        while (l < h)
        {
            if (people[l] > limit) return count;
            if (people[l] + people[h] <= limit)
            {
                count++;
                l++; h--;
            }
            else if (people[h] <= limit)
            {
                count++;
                h--;
            }
            else if (people[l] <= limit) 
            {
                l++; h--;
            }
        }
        if (l == h && people[l] <= limit) count++;
        return count;
    }
}