/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode DeleteNode(TreeNode root, int key) {
        List<int> result = new List<int>();
        InOrder(root, result);

        int keyFoundIndex = -1;
        for(int i = 0; i < result.Count; i++){
            Console.WriteLine(result[i]);
            if(result[i] == key) keyFoundIndex = i;
        }

        if(keyFoundIndex == -1) return root;

        result.RemoveAt(keyFoundIndex);

        return BinarySearch(result, 0, result.Count - 1);

    }

    public void InOrder(TreeNode node, List<int> result){
        if(node == null) return;
        InOrder(node.left, result);
        result.Add(node.val);
        InOrder(node.right, result);
    }

    public TreeNode BinarySearch(List<int> result, int left, int right){
        if(left > right) return null;
        int mid = left + (right - left) / 2;
        TreeNode root = new TreeNode(result[mid]);
        root.left = BinarySearch(result, left, mid - 1);
        root.right = BinarySearch(result, mid + 1, right);
        return root;
    }
}