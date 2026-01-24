public class Robot
{
    private string? _name;
    private static readonly Random rnd = new();
    private static readonly HashSet<string> UsedNames = new();
    public string Name
    {
        get
        {
            if(_name == null){
                _name = GenerateUniqueName();
            }
            
            return _name;
        }
    }

    public void Reset()
    {
        if(_name != null){
            UsedNames.Remove(_name);
            _name = null;
        }
    }
    private static string GenerateUniqueName()
    {
        string name;
        do{
            name = GenerateName();
        }while(UsedNames.Contains(name));
        UsedNames.Add(name);
        return name;
    }

    private static string GenerateName()
    {
        char l1 = (char)('A' + rnd.Next(26));
        char l2 = (char)('A' + rnd.Next(26));
        int d = rnd.Next(1000);
        return $"{l1}{l2}{d:D3}";
    }
    
}