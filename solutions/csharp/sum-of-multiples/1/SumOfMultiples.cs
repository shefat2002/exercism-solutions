public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var points = new HashSet<int>();
        foreach(var num in multiples){
            if(num ==0) continue;
            for(int i = 1 ;  i < max ; i++){
                if(i % num == 0) points.Add(i);
            }
        }
        return points.Sum();
    }
}