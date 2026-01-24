public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        if(color == "black") return 0;
        if(color == "brown") return 1;
        if(color == "red") return 2;
        if(color == "orange") return 3;
        if(color == "yellow") return 4;
        if(color == "green") return 5;
        if(color == "blue") return 6;
        if(color == "violet") return 7;
        if(color == "grey") return 8;
        return 9;
        
    }

    public static string[] Colors() => ["black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"];
}