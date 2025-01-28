int[] arr={1,2,3,4,5,6};
int d=2;
int n=arr.Length;
int[] arr2=new int[d];

for(int i=0; i<n-d; i++)
{
    if (i>arr2.Length)
    {
     arr2[i]=arr[i];
    }
arr[i]=arr[i+d];
}
for(int i=0; i<d; i++)
{
arr[n-d +i]=arr2[i];
}

for(int i=0; i<n; i++)
{
    Console.Write(arr[i]+" ");
}

Console.ReadLine();

// Time and space complexity is O(n)

