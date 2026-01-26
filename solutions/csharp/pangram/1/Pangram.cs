public static class Pangram
{
    public static bool IsPangram(string input)
    {
        var letters = new HashSet<char>();
        foreach(char letter in input.ToLowerInvariant())
        {
            if(Char.IsLetter(letter))
                letters.Add(letter);
        }
        
        return letters.Count == 26;
    }
}
