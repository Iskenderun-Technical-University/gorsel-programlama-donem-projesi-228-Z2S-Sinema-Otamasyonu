#include <stdio.h>
 #pragma warning(disable:4996) 
 #define MAX 50
 void selectionSort (int arr[],int size)
 {
     int i,j,temp,minimumindex;
     for (i=0;i<size;i++)
     {
         minimumindex = i;
         for(j=i;j<size;j++)
         {
             if(arr[j]<arr[minimumindex])
             {
                 minimumindex=j;
             }
         }
         temp=arr[i];
         arr[i] = arr[minimumindex];
         arr[minimumindex]=temp;
     }
 }
 int main() 
 { 
     int i,elemanSayisi;
     int array[MAX];
     printf("eleman sayisini girin: ");
     scanf("%d",&elemanSayisi);
    for(i=0;i<elemanSayisi;i++)
    {     
          printf("%d. elemani girin. ",i+1);
          scanf("%d",&array[i]); 
     } 
     selectionSort(array,elemanSayisi); 
     printf("Siralanmis liste: "); 
     for(i=0;i<elemanSayisi;i++) 
     {     
          printf("%d ",array[i]);
    }  
     system("pause");
     return 0;
 }
 

