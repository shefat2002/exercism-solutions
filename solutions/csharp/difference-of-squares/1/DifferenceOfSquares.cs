public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = 0;
        while(max > 0){
            sum += max--;
        }
        return (int)Math.Pow(sum, 2);
    }

    public static int CalculateSumOfSquares(int max)
    {
        int sum = 0;
        while(max > 0){
            sum += (int)Math.Pow(max--,2);
        }
        return sum;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}