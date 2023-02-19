:) Logic
The logic of quick sort is also in similar lines of the merge sort but it is better in terms of space complexity 
becasue it doesnot require any extra space.
In Quick sort we took pivot element usually  the last element in the array and along the pivot we move all smaller and the larger element .
After that finally put the pivot element in correct position .
then call recursion to Quicksort from start to pivot-1 and Quicksort from pivot+1 to end.



:) code 

```cpp

void quickSort(int arr[], int low, int high)
    {
        
        if(low<high)
        {
        int piv = partition(arr,low,high);
        quickSort(arr,low,piv-1);
        quickSort(arr,piv+1,high);
        }
    }
    
    public:
    int partition (int arr[], int low, int high)
    {
       int pivot = arr[high];
       int left = low;
       
       for(int i = low ; i<=high ;i++)
       {
           
           if(arr[i]<pivot)
           {
               
               swap(arr[i],arr[left]);
               left++;
               
           }
           
           
       }
       
       // finally pivot place at correct position
       
       swap(arr[left],arr[high]);
       
       return left;
       
    }
};



```

Time complexity analysis:-
Usually it also takes O(nlogn) in the average cases untill and unless the array is aready not sorted.
If the Array is already sorted and we are doing quick sort then there are n times parataion heppend and fianlly
we got The Wrost Case TC- O(n^2).

Space complexity :- O(1).