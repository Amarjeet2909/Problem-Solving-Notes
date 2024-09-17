Logic:)
The brute force appproach is to push the nodes in a hash table and if there is a entry comes for same node that means 
there is cycle

The logic is simple to keep a fast pointer and a slow pointer and move fast by 2 and slow by 1 as soon as both pointer 
meet at same position that means there is a cycle.

If we have to find the Length of cycle in the linkedlist then when slow & fast meet break loop and now keep moving slow again to meet the fast and sath me count++ then finally when they meet again return the count 

 




:) Code
```cpp
class Solution {
public:
    bool hasCycle(ListNode *head) {
        if((head == NULL)||(head->next == NULL)) return false;
        ListNode *slow = head;
        ListNode *fast  = head; 
        while((fast != NULL)&&(fast->next != NULL))
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


:)Code for find Length of loop

```cpp
//Function to find the length of a loop in the linked list.
int countNodesinLoop(struct Node *head)
{
    int count =1;
    
    Node *fast = head;
    Node *slow = head;
    
    
    while(fast !=nullptr && fast->next !=nullptr)
    {
        slow= slow->next;
        fast = fast->next->next;
        
        if(slow==fast)    //slow fast mil jaye to ruk jao 
           break;
        
    }
    slow=slow->next;   // slow ko ek agge badha do

    while(slow!=fast)  //ab wapis jab tak slow fast na mile count karte jao..
    { 
        count++;
        slow=slow->next;
    }
    if(fast==nullptr || fast->next ==nullptr) return 0;  // agar fast null pointer reach kar ja rha then no cycle
    return count; //return count
    
    
}

```