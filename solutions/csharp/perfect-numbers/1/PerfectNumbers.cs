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
        int original = number;
        var factor = new List<int>();
        for(int i = 1; i <number ; i++){
            if(number % i == 0){
                factor.Add(i);
            }
            
        }
        int sum = factor.Sum();
        if(sum == original) return Classification.Perfect;
        if(sum > original) return Classification.Abundant;
        return Classification.Deficient;
    }

    
}


