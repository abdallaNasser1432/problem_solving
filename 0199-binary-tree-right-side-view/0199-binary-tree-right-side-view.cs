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
    public IList<int> RightSideView(TreeNode root) {
        if (root == null)
            return [];

        Queue<TreeNode> q = new();
        List<int> result = new();

        q.Enqueue(root);

        while (q.Count > 0)
        {
            int size = q.Count;
            for (int i = 0; i < size; i++) {

                TreeNode current = q.Dequeue();

                if (i == size - 1 )
                    result.Add(current.val);

                if (current.left != null)
                    q.Enqueue(current.left);
                if (current.right != null)
                    q.Enqueue(current.right);
            }
        }
        return result;
    }
}