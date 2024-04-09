public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int circularSandwiches = 0, squareSandwiches = 0;
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i] == 0) circularSandwiches++;
            else squareSandwiches++;
        }
        for (int i = 0; i < sandwiches.Length; i++)
        {
            if (sandwiches[i] == 0 && circularSandwiches == 0)
                return squareSandwiches;
            if (sandwiches[i]==1 && squareSandwiches==0)
                return circularSandwiches;
            if (sandwiches[i] == 0)
                circularSandwiches--;
            else
                squareSandwiches--;
        }
        return 0;
    }
}