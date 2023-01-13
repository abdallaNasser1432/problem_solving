class Solution {
public:
    struct Node {
        vector<Node*> children;
        char c;
    };
    
    int longestPath(vector<int>& parent, string s) {
        // just create the nodes
        nodes_.resize(parent.size());
        for(int i = 0; i < nodes_.size(); ++i) {
            nodes_[i] = new Node;
            nodes_[i]->c = s[i];
        }
        
        // add child pointers
        for(int i = 1; i < nodes_.size(); ++i) {
            nodes_[parent[i]]->children.push_back(nodes_[i]);
        }
        
        ans_ = 0;
        Calc(nodes_[0]);
        return ans_;
    }
    
    int Calc(Node* root) {        
        int longest_child = 0;
        int second_longest_child = 0;
        
        for(Node* child : root->children) {
            int child_len = Calc(child);
            if(child->c != root->c) {
                if(child_len > longest_child) {
                    second_longest_child = longest_child;
                    longest_child = child_len;
                } else if(child_len > second_longest_child) {
                    second_longest_child = child_len;
                }
            }
        }
                
        ans_ = std::max(ans_, 1 + longest_child + second_longest_child);
        return longest_child + 1;
    }
    
    int ans_;
    vector<Node*> nodes_;
};