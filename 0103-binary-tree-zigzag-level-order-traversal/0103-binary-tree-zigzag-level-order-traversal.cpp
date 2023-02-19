/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
class Solution {
public:
    vector<vector<int>> zigzagLevelOrder(TreeNode* root) {
        if (!root) return {};
        vector<vector<int>> lines;
        deque<TreeNode*> q;
        q.push_front(root);

        for (int l = 0; !q.empty(); l++) {
            lines.push_back({});
            for (int n = q.size(); n > 0; n--) {
                TreeNode* node = l % 2 == 0 ? q.front() : q.back();
                l % 2 == 0 ? q.pop_front() : q.pop_back();
                lines[l].push_back(node->val);
                if (l % 2 == 0) {
                    if (node->left) q.push_back(node->left);
                    if (node->right) q.push_back(node->right);
                }
                else {
                    if (node->right) q.push_front(node->right);
                    if (node->left) q.push_front(node->left);
                }
            }
        }

        return lines;
    }
};