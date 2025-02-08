int sum = 0, count=0;
public static void NodeSum(BinNode<int> N, ref int count, ref int sum )
{ 
    if (N == null)
        return 0;
    count++;
return N.GetValue() + NodeSum(N.GetLeft(),ref count, ref sum) + NodeSum(N.GetRight(), ref count, ref sum);

}

public static void NodeAvg(BinNode <int> N, int count ref. int sum ref)
{
   int avg= sum/count;
    if (N.GetValue() < avg)
    {
        Console.WriteLine(N.GetValue());
    }
    NodeAvg(N.GetLeft());
    NodeAvg(N.GetRight());
}