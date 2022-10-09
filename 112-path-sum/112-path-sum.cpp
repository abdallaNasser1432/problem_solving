class Solution {
public:
    bool hasPathSum(TreeNode* root, int targetSum) {
        if(!root){
            return false;
        }if(root and !root->left and !root->right and root->val== targetSum){
            return true;
        }
        bool left= hasPathSum(root->left,targetSum-(root->val));
        if(left){
            return left;
        }
        bool right= hasPathSum(root->right,targetSum-(root->val));
        if(right){
            return right;
        }
        return false;
    }
};