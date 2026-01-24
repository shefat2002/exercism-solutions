class Lasagna
{
    int time = 40;
    public int ExpectedMinutesInOven() => time;
         
    public int RemainingMinutesInOven(int count) => (time - count);
    

    public int PreparationTimeInMinutes(int layer) => (layer*2);
    

    public int ElapsedTimeInMinutes(int letters, int minutes) => PreparationTimeInMinutes(letters) + minutes;
}
