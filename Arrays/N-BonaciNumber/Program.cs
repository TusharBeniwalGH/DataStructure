//N-bonnaci number , Print first n-bonnaci numbers
int n=5, m=10;

int[] array=new int[m];

for(int i=0;i<n-1;i++)
{
    array[i]=0;
}
array[n-1]=1;
int k=0;
int l=n;
for(int i=n;i<m;i++)
{
    for(int j=k;j<l && j<array.Length;j++)
    {
       array[i]+=array[j];
    }
    k++;
    l++;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

Console.Read();