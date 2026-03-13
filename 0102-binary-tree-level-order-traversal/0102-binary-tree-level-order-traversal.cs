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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> result = [];
        Queue<TreeNode> q = new();
        if (root is null)
            return result;
        q.Enqueue(root);

        while (q.Count > 0)
        {
            int size = q.Count;
            List<int> level = new();

            for (int i = 0; i < size; i++)
            {
                var node = q.Dequeue();
                level.Add(node.val);

                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }
            result.Add(level);
        }
        return result;
    }
}