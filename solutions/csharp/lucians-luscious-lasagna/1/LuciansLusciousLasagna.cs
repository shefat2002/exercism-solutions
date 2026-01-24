class Lasagna
{
    int time = 40;
    public int ExpectedMinutesInOven(){
        return time;
    }

    public int RemainingMinutesInOven(int count){
        return time - count;
    }

    public int PreparationTimeInMinutes(int layer){
        return layer*2;
    }

    public int ElapsedTimeInMinutes(int letters, int minutes){
        return PreparationTimeInMinutes(letters) + minutes;
    }
}
