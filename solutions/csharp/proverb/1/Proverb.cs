public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        int n = subjects.Length;

        if(n == 0) return [];
        
        List<string> ans = new();
        

        for(int i = 1 ; i < n ; i ++){
            string s = $"For want of a {subjects[i-1]} the {subjects[i]} was lost.";
            ans.Add(s);
        }
        ans.Add($"And all for the want of a {subjects[0]}.");
        return ans.ToArray();
        
    }
}