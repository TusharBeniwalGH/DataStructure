
int[] array=[1,4,2,10,23,3,1,0,20];
int k=4;
int sum=0;
if (k>=array.Length)
{
    Console.WriteLine("Invalid input");
    return;
}
for (int i=0; i<k; i++)
{
    sum+=array[i];
}
int max_sum=sum;
for (int i=k; i<array.Length; i++)
{
sum+=array[i]-array[i-k];
if (sum>max_sum){max_sum=sum;}
}
Console.WriteLine("Max sum of subarray of size "+k+" from the array "+ string.Join(" ", array) +" is: ");
Console.WriteLine(max_sum);
Console.Read();