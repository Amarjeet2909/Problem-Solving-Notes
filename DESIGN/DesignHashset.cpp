//BruteForce(Naive Approach)
/*
  Make an array[given range +1] of indexes as key and mark them all initially with 0 
  addition of key => just put arr[key]=1
 removal of keyt => just put arr[key]=0
 contains => agar key me 0 hai to false nahi to true

Disadvantage-> this aproach will not work if the range of number is very big or it conatins  negative keys
*/


//BruteForce solution

class MyHashSet {
public:
    
    int hash[1000001] = {0};
    MyHashSet() {
        
    }
    
    void add(int key) {
        hash[key] = 1;
    }
    
    void remove(int key) {
        hash[key]=0;
    }
    
    bool contains(int key) {
        if(hash[key]) return true;
        else
            return false;
    }
};

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet* obj = new MyHashSet();
 * obj->add(key);
 * obj->remove(key);
 * bool param_3 = obj->contains(key);
 */

/*
  Better approach using creation of hash function and store then in array of list
  1) Create array of lists size(as wish)  => less size more collisions more the size less collisons (take optimal)
  2) Create a getindex function => which return key%size;
  3) Create a search function which search key in the list use STL function Find for seaching a key 

*/
#include<bits/stdc++.h>
using namespace std;

class MyHashSet {
public:
    
    list<int> hash[10001];
    MyHashSet() {
        
    }
    
    // getindex function return the modified index 
    int getindex (int key)
    {
        return key%10001;
        
    }
    // search function which search keys in list
    
    list<int> :: iterator search(int key)
    {
        int i = getindex(key);
        
        return find(hash[i].begin(),hash[i].end(),key);    //use find functin to search
    }
    
    void add(int key) {
        
        if(contains(key)) return;
        
        int i = getindex(key);
        
        hash[i].push_back(key);
        
        
    }
    
    void remove(int key) {
        
        if(!contains(key)) return;
        int i = getindex(key);
        
       auto it = search(key); 
        hash[i].erase(it);
    
    }
    
    bool contains(int key) {
        
        int i = getindex(key);
        
        auto it = search(key);
        
        if(it==hash[i].end()) return false;
        return true; 
        
        
    }
};
