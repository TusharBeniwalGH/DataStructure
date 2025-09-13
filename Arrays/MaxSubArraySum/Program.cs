int[] arrays=[1,2,3,-9,-6,4,7];

int result=arrays[0];
for(int i=1;i<arrays.Length;i++)
{
result=System.Math.Max(result+arrays[i],arrays[i]);
}

Console.WriteLine("Maximum Subarray Sum is: "+ result);