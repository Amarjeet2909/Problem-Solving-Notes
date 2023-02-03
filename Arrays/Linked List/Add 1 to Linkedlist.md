Add 1 to linked list :-
Basic Intution :- Go to the last node of LinkedList and add 1 But if one addition it is > 9 then we have to add carry 1 to its previous node and so on so we have to traverse many times 
OPTIMIZED Approach :-
1) First revese the whole linked list that reduces down to only single traversal.
2) Take two pointer Prev and current on revsrse list and and carry variable initilized with 0.
3) Loop till curr reaches null => if prev = null i.e we are at first node then no need to worry about carry simply sum = sum + 1 else sum = sum + carry;
4) calculate the carry and curr->data for next iteration using  carry= sum/10 and curr->data = sum%10.
5) Move the prev and  curr pointer for next iterations
6) if after complete loop carry == 1 i.e we have to add one more node(with data 1) and attached to prev pointer.
7) finally reverse it again and return head.



```cpp
class Solution
{  
    // use of reverseList function
     Node* reverseList(Node* head) {
        
        
    if(head == nullptr)  //edge case 
            return head;
        
        Node * p = nullptr;
        Node * c = head;
        Node * n = head->next;
        
        while(n != nullptr)
        {
            
            c->next = p;
            p=c;
            c=n;
            n=n->next;   
            
        }
        c->next = p;
        head = c;
        return head;     
        
    }
    
      
    public:
    Node* addOne(Node *head) 
    {
        
        // first reverse the linkedlist
        Node *newhead = reverseList(head);
        
        // take two pointer current and prev
        
        Node *prev = nullptr,*curr = newhead;
        
        // take a carry variable initilize with 0
        int carry = 0;
        
        while(curr!=nullptr)
        {
            int sum =0;
            
            if(prev==nullptr)
            {
                sum = curr->data +1;
                
                
            }
            else
            {
                sum = curr->data + carry;
                
            }
            
            // calculaing the value and current data for curr node
            carry = sum/10;
            curr->data = sum %10;
            prev=curr;
            curr=curr->next;
            
            
            
            
            
        }
        // Most important
        // agar last me carry 1 reh rha to new node add karo
        if(carry==1)
        {
           
           Node * add = new Node(1);
           prev->next = add;
            
        }
        
        // wapis reverse kar do
        head = reverseList(newhead);
        
        
        return head;
        
        
        
        
        
        
    }
};

```

TC - 0(N)
Sc - 0(1)