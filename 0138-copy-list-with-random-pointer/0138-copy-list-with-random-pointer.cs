/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        if (head == null) return null;

        Dictionary<Node, Node> mapOldToNew = new Dictionary<Node, Node>();

        Node curr = head;
        while (curr != null)
        {
            mapOldToNew[curr] = new Node(curr.val);
            curr = curr.next;
        }

        curr = head;
        while (curr != null)
        {
            mapOldToNew[curr].next = curr.next != null ? mapOldToNew[curr.next] : null;
            mapOldToNew[curr].random = curr.random != null ? mapOldToNew[curr.random] : null;
            curr = curr.next;
        }

        return mapOldToNew[head];
    }
}