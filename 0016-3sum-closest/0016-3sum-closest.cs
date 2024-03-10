public class Solution {
    public int ThreeSumClosest(int[] nums, int target)
{
    int mindiff = int.MaxValue;
    int n = nums.Length;
    Array.Sort(nums);
    int ans = 0;

    for (int i = 0; i < n; i++)
    {
        int j = i + 1;
        int k = n - 1;

        while (j < k)
        {
            int sum = nums[i] + nums[j] + nums[k];

            if (sum == target) return target;

            else
            {
                int diff = Math.Abs(target - sum);

                if (diff < mindiff)
                {
                    mindiff = diff;
                    ans = sum;
                }
            }

            if (sum < target) j++;
            else if (sum > target) k--;
        }

    }
    return ans;
}
}