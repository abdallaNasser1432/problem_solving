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
    Dictionary<int, TreeNode> parentMap = new();
    HashSet<int> infected = new();
    
    public int AmountOfTime(TreeNode root, int start) {
        var startNode = FindStart(root, null, start);
        
        return Infect(startNode, 0);
    }
    
    private int Infect(TreeNode node, int day){
        if(node == null)
            return day -1;
        if(infected.Contains(node.val))
            return day -1;
        
        infected.Add(node.val);
        
        int left = Infect(node.left, day +1);
        int right = Infect(node.right, day +1);
        
        int parent =0;
        if(parentMap.ContainsKey(node.val) && parentMap[node.val] != null)
            parent = Infect(parentMap[node.val],  day +1);
        
        return Math.Max(left, Math.Max(right, parent));
    }
    
    private TreeNode FindStart(TreeNode node, TreeNode par, int start){
        if(node == null)
            return null;
        
        parentMap[node.val] = par;
        if(node.val == start)
            return node;
        
        var result = FindStart(node.left, node, start);
        if(result != null)
            return result;
        
        return FindStart(node.right, node, start);
    }
}