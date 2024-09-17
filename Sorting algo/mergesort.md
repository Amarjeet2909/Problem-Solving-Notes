:) Logic 
it is based on the divide and merge algorithm so first divide the given array into smallersubproblems with sorted order and finally merge it .\\

-> recursion take care for mergesort the two halfs .\\

-> my work is only write merge function and call it after recurion done its work.


code:-

```cpp

class Solution
{
    public:
    void merge(int arr[], int l, int m, int r)
    {
            
         int i = l;
         int j = m+1;
         
         vector<int> temp;
         
         while(i<=m && j <=r)
         {
             
             if(arr[i]<arr[j])
             {
                 temp.push_back(arr[i]);
                 i++;
                 
                 
             }
             else
             {
                 temp.push_back(arr[j]);
                 j++;
             }
             
             
         }
         
         while(i<=m)
         {
             temp.push_back(arr[i]);
                 i++;
         }
         
         while(j<=r)
         {
          temp.push_back(arr[j]);
                 j++;
             
         }
         
         // now copy all elements from temp to arr
          int k =0;
         for(int i = l ; i<=r;i++)
         {
             arr[i]= temp[k++];
         }
         
         
    }
    public:
    void mergeSort(int arr[], int l, int r)
    {
        
        if(l>=r)   // Basecase
         return ; 
         int m = l + (r-l)/2;
         mergeSort(arr,l,m);  //Bharosa
         mergeSort(arr,m+1,r); //Bharosa
         merge(arr,l,m,r);    //Apna kaam 
        
        
        
    }
};


```

Tc - O(nlogn).\\

Sc - O(n) ->  required extra space for merge function  