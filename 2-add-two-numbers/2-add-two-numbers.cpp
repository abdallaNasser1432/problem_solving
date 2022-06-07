class Solution {
public:
    ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) {
        ListNode *l3=new ListNode(),*curr=l3;
        int carry=0;
        while((l1!=NULL || l2!=NULL) || carry){
            int sum=0;
            if(l1!=NULL){
                sum+=l1->val;
                l1=l1->next;
            }
            if(l2!=NULL){
                sum+=l2->val;
                l2=l2->next;
            }
            sum+=carry;
            carry=sum/10;
            ListNode *temp=new ListNode(sum%10);
            curr->next=temp;
            curr=curr->next;
            
        }
        
        return l3->next;
    }
};