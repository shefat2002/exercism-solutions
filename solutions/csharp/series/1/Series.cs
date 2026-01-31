public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if(sliceLength <= 0 || sliceLength > numbers.Length || numbers.Length == 0) throw new ArgumentException();
        List<string> ans = new();
        for(int i = 0 ; i <= numbers.Length - sliceLength ; i++)
        {
            ans.Add(numbers.Substring(i, sliceLength));
        }
        return ans.ToArray();
    }
}