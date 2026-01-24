public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> dna = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };
        
        foreach(char i in sequence){
            if(i != 'A' && i != 'C' && i != 'G' && i != 'T'){
                throw new ArgumentException();
            }
            dna[i]++;
        }
        // if(dna['A'] == 0 || dna['C'] == 0 || dna['G'] == 0 || dna['T'] == 0)
        //     throw new ArgumentException();
        return dna;
        
        
        
    }
}