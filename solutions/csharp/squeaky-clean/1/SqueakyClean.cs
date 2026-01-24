public static class Identifier
{
    public static string Clean(string identifier)
    {
        string ans ="";
        for(int i = 0; i < identifier.Length ; i++){
            
            if(identifier[i] == ' ') ans += "_";
            
            else if(Char.IsControl(identifier[i])) {
                ans += "CTRL";
                Console.WriteLine(ans);
            }
            else if(identifier[i] == '-'){
                i++;
                ans+= Char.ToUpper(identifier[i]);
            }
            else if(!Char.IsLetter(identifier[i]))
                continue;
            else if(identifier[i] >= 'α' && identifier[i] <= 'ω')
                continue;
            else ans +=identifier[i];
        }
        return ans;
    }
}
