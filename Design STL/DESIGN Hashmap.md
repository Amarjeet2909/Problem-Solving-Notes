BruteForce(Naive Approach) :-
  1) Make an array[given range +1] of indexes as key and mark them all initially with -1 

  2) Addition of value / updation of value in  key => just put arr[key]=value

  3) Removal of keyt => just put arr[key]=-1
    contains => agar key me -1 hai to false nahi to true

Disadvantage-> this aproach will not work if the range of number is very big 

```cpp
 class MyHashMap {
public:
   vector<int> arr;
    int size;
    MyHashMap() {
        size = 1e6+1;   //getting size for vector
        arr.resize(size); //resize function for resizing the exixsting vector
        fill(arr.begin(),arr.end(),-1); //fill function fill values with iterator
        
    }
    
    void put(int key, int value) {
        arr[key]=value;
        
    }
    
    int get(int key) {
        return arr[key];
    }
    
    void remove(int key) {
        arr[key]= -1;
    }
};
```

Approach 2 using LinkedList:-
  Better approach using creation of hash function and store then in array of list of pair<int,int>
  1) Create array of list<pair<int,int>>(as wish)  => less size more collisions more the size less collisons (take optimal)
  2) Create a getindex function => which return key%size;
  3) Create a search function which search key in the list use STL iterator to search key in the list of array and return that iterator 
  4) New key value put krne se pehle remove old one using remove function


```cpp
 class MyHashMap {
public:
    
    list<pair<int,int>> arr[1001];  //creatig a vector of list of pair of int
    MyHashMap() {
        
    }
    
    int getindex(int key)          // creating getindex function
    {
        return key%1001;
        
    }
    
    list<pair<int,int>> :: iterator    search(int key)    //creating search function
    {
        int i = getindex(key);
        
        auto it = arr[i].begin();
        
        while(it!=arr[i].end())
        {
            if(it->first == key)
                return it;
              it++;  
        }
        
        return it;  
        
    }
    
    
    void put(int key, int value) {
        // pehle purana value ko remove kar do
        int i = getindex(key);
        remove(key);
        arr[i].push_back({key,value});     // inserting {key,value}
         
    }
    
    int get(int key) {
        int i = getindex(key);
        auto it = search(key);
        
        if(it !=arr[i].end()) return it->second;
        
        return -1;
        
        
    }
    
    void remove(int key) {
        
        int i = getindex(key);
        
        auto it = search(key);
        
        if(it !=arr[i].end())
            arr[i].erase(it);   
        
        return;
        
    }
};
```