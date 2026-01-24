class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] birds = {0, 2, 5, 3, 7, 8, 4};
        return birds;
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        return birdsPerDay.Contains(0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int cnt =0;
        for(int i = 0; i < numberOfDays ; i++){
            cnt += birdsPerDay[i];
        }
        return cnt;
    }

    public int BusyDays()
    {
        int cnt =0;
        for(int i = 0; i < birdsPerDay.Length ; i++){
            cnt += (birdsPerDay[i]) >=5 ? 1:0;
        }
        return cnt;
    }
}
