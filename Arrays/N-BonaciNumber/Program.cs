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

Dictionary<int, int> dict = new Dictionary<int, int>();
dict.Add(1, 1);
dict.Add(2, 1);
int? vale=dict.Where(x => x.Key > 2)?.Select(x => x.Key)?.FirstOrDefault();
Console.Write(vale==0 ? -1 : vale.ToString());

Console.Read();