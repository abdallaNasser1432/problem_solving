```
var res = new List<int>(); int n;
for (int i = 0; i < nums.Length; i++)
{
n = Math.Abs(nums[i]) - 1;
if (nums[n] < 0) res.Add(n + 1);
nums[n] = -nums[n];
}
```