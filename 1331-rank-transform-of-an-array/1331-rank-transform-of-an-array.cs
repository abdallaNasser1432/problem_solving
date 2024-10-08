public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        
        var dict = arr
		.Distinct()
		.OrderBy(x => x)
		.Select((x, i) => (x, i))
		.ToDictionary(x => x.x, x => x.i + 1);

        for (var i = 0; i < arr.Length; i++)
            arr[i] = dict[arr[i]];

        return arr;
    }
}