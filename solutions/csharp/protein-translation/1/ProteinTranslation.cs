public static class ProteinTranslation
{

    public static string[] Proteins(string strand)
    {
        List<string> ans = new List<string>();
        int i = 0;
        int n = strand.Length;
        while(i < n){
            string current = strand.Substring(i,3);
            string got = "";
            if(current == "AUG") got = "Methionine";
            else if(current == "UUU" || current == "UUC") got = "Phenylalanine";
            else if(current == "UUA" || current == "UUG") got = "Leucine";
            else if(current == "UCU" || current == "UCC"|| current == "UCA" || current == "UCG") got = "Serine";
            else if(current == "UAU" || current == "UAC") got = "Tyrosine";
            else if(current == "UGU" || current == "UGC") got = "Cysteine";
            else if(current == "UGG") got = "Tryptophan";
            else if(current == "UAA" || current == "UAG" || current == "UGA") break;
            ans.Add(got);
            i+=3;
        }
        return ans.ToArray();
    }
    
}