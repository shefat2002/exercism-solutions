public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        var exp = new Dictionary<string, int>();
        foreach(var pair in old)
        {
            int point = pair.Key;
            string[] letters = pair.Value;
            foreach(var val in letters){
                exp[val.ToLower()] = point;
            }
        }
        return exp;
    }
}