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
    public TreeNode ReverseOddLevels(TreeNode root) {
        if (root == null)
        {
            return null;
        }

        Queue<(TreeNode node, int level)> queue = new Queue<(TreeNode, int)>();
        queue.Enqueue((root, 0));

        Dictionary<int, List<TreeNode>> levelNodes = new Dictionary<int, List<TreeNode>>();

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            TreeNode node = current.node;
            int level = current.level;

            if (!levelNodes.ContainsKey(level))
            {
                levelNodes[level] = new List<TreeNode>();
            }
            levelNodes[level].Add(node);

            if (node.left != null)
            {
                queue.Enqueue((node.left, level + 1));
            }
            if (node.right != null)
            {
                queue.Enqueue((node.right, level + 1));
            }
        }

        foreach (var level in levelNodes)
        {
            if (level.Key % 2 != 0) // Odd level
            {
                List<TreeNode> nodes = level.Value;
                List<int> values = nodes.Select(n => n.val).ToList();
                values.Reverse();

                for (int i = 0; i < nodes.Count; i++)
                {
                    nodes[i].val = values[i];
                }
            }
        }

        return root;
    }
}