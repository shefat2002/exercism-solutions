public class SpaceAge
{
    public double seconds{get;set;}
    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth() => (seconds / 31557600);

    public double OnMercury() => ((seconds / 31557600) / 0.2408467);

    public double OnVenus() =>  ((seconds / 31557600) / 0.61519726);

    public double OnMars() => ((seconds / 31557600) / 1.8808158);

    public double OnJupiter() => ((seconds / 31557600) / 11.862615);

    public double OnSaturn() =>  ((seconds / 31557600) / 29.447498);

    public double OnUranus() => ((seconds / 31557600) / 84.016846);

    public double OnNeptune() => ((seconds / 31557600) / 164.79132);
}