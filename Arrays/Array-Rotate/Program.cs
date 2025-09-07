int[] arr3={1,2,5,7,9};

int k=2;

int n1=arr3.Length;

int[] arr4=new int[n1];

for(int i=0;i<n1-k-1;i++)
{
    arr4[i]=arr3[n1-k +i];
}
int m=0;
for(int i=n1-k-1;i<n1;i++)
{
    arr4[i]=arr3[m];
    m++;
}

for(int i=0;i<n1;i++)
{
    Console.Write(arr4[i]+" ");
}

Console.Read();
