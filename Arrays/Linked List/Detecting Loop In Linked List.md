Logic:)
The brute force appproach is to push the nodes in a hash table and if there is a entry comes for same node that means 
there is cycle

The logic is simple to keep a fast pointer and a slow pointer and move fast by 2 and slow by 1 as soon as both pointer 
meet at same position that means there is a cycle.


:) Code
```cpp
class Solution {
public:
    bool hasCycle(ListNode *head) {
        if((head == NULL)||(head->next == NULL)) return false;
        ListNode *slow = head;
        ListNode *fast  = head; 
        while((fast->next != NULL)&&(fast->next->next != NULL))
        {
            fast = fast->next->next;
            slow = slow->next;
            if(fast == slow) return true;
        }
        return false;
    }
};
```
:) Complexity
T.C: O(N)
S.C: O(1)