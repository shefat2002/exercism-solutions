public static class Darts
{
    public static int Score(double x, double y){
        double dist = x*x + y*y;
        if(dist <= 1) return 10;
        if(dist <= 25) return 5;
        if(dist <= 100) return 1;
        return 0;
    }
}
