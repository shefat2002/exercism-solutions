public static class Raindrops
{
    public static string Convert(int number)
    {
        string ans = "";
        if(number % 3 == 0) ans += "Pling";
        if(number % 5 == 0) ans += "Plang";
        if(number % 7 == 0) ans += "Plong";
        if(ans == "") ans = number.ToString();
        return ans;
    }
}