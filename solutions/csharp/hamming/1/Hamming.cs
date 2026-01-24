public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        try{
            int count = 0;
            int mn = Math.Max(firstStrand.Length,secondStrand.Length);
            
            for(int i = 0; i <  mn ; i++){
                if(firstStrand[i] != secondStrand[i]) count++;
            }
            return count;
        }
        catch(Exception e){
            throw new ArgumentException();
        }
        
    }
}