public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var letters = new HashSet<char>();
        foreach(var c in word){
            if(Char.IsLetter(c)){
                bool ok= letters.Add(Char.ToLower(c));
                if(!ok)return false;
            }
        }
        return true;
        
    }
}
