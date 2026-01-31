public static class ResistorColorTrio
{
    public static long value(string color) =>
        color switch
        {
            "black" => 0,
            "brown" => 1,
            "red" => 2,
            "orange" => 3,
            "yellow" => 4,
            "green" => 5,
            "blue" => 6,
            "violet" => 7,
            "grey" => 8,
            "white" => 9
        };
    
        
    public static string Label(string[] colors)
    {
        long num = (value(colors[0])*10 + value(colors[1])) * (long)Math.Pow(10,value(colors[2]));
        if(num % 1000000000 == 0 && num !=0) return $"{num / 1000000000} gigaohms";
        if(num % 1000000 == 0  && num !=0) return $"{num / 1000000} megaohms";
        if(num % 1000 == 0 && num !=0) return $"{num / 1000} kiloohms";
        return $"{num} ohms";
        
        
    }
}
