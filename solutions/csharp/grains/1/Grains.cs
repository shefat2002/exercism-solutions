public static class Grains
{
    public static ulong Square(int n)
    {
        if(n < 1 || n > 64) throw new ArgumentOutOfRangeException();
        return (ulong)Math.Pow((double)2, (double)n-1);
    }

    public static ulong Total() => (ulong)Math.Pow((double)2, (double)64);
}