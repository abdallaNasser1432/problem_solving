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
    public int MaxAncestorDiff(TreeNode root) {
        if (root == null)
            return -1;
        
        return Math.Max(DFS(root, root), Math.Max(MaxAncestorDiff(root.left), MaxAncestorDiff(root.right)));
    }
    
    private int DFS(TreeNode root, TreeNode node)
    {
        if (node == null)
            return 0;
        
        return Math.Max(Math.Abs(root.val - node.val), Math.Max(DFS(root, node.left), DFS(root, node.right)));
    }
}