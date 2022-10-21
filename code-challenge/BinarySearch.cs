namespace code_challenge;
public class BinarySearch
{

    //iterative method
     public int BinnarySearch(int[] arrayList, int key)
        {
           int min = 0;
           int max = arrayList.Length -1;
           while(min <= max)
           {
               int mid = (min +max)/2;

               if(key == arrayList[mid])
               {
                   return mid ++;
               }
               else if (key < arrayList[mid])
               {
                   max = mid -1; 
               }
               else{
                   min = mid +1;
               }

           }
           return -1;

        }


        //recursive
        public int BinarySearchRecursion(int[]arrayList , int key, int min, int max)
        {
            if(min>max){
                return -1;
            }
            int mid = (min + max)/2;
            if(key == arrayList[mid]){
                return mid ++;
            }
            else if (key < arrayList[mid]){
                return BinarySearchRecursion(arrayList , key,min,mid-1);
            }
            else{
                return BinarySearchRecursion(arrayList , key,mid+1,max);
            }
        }

}
