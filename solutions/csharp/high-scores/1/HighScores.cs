public class HighScores
{
    public List<int> _list {get; set;} = new();
    public HighScores(List<int> list)
    {
        _list = list;
    }

    public List<int> Scores() => _list;

    public int Latest() => _list.Last();

    public int PersonalBest() => _list.Max();
    
    public List<int> PersonalTopThree(){
        List<int> topThree = new();
        topThree = _list.OrderByDescending(x => x).Take(3).ToList();
        return topThree;
    }
}