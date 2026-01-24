class RemoteControlCar
{
    public int distanceDrived = 0;
    public int batteryLevel = 100;
    
    public static RemoteControlCar Buy()
    {
        var car = new RemoteControlCar();
        return car;
    }

    public string DistanceDisplay()
    {
        return $"Driven {distanceDrived} meters";
    }

    public string BatteryDisplay()
    {
        if(batteryLevel ==0) return "Battery empty";
        return $"Battery at {batteryLevel}%";
    }

    public void Drive()
    {
        if(batteryLevel ==0) return;
        distanceDrived += 20;
        batteryLevel -= 1;
    }
}
