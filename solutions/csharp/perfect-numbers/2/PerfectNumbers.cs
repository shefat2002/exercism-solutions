public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}


public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if(number <= 0) throw new ArgumentOutOfRangeException();
        int sum = 0;
        for(int i = 1; i < number ; i++){
            if(number % i == 0){
                sum += i;
            }
            
        }
        if(sum == number) return Classification.Perfect;
        if(sum > number) return Classification.Abundant;
        return Classification.Deficient;
    }

    
}


