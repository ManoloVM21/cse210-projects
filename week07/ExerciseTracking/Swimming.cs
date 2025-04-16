public class Swimming : Activity{
    private int _laps;
    public Swimming(int legth, int laps): base(legth){
        _laps = laps;
    }
    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000.0;
        return distance;
    }
    public override double GetSpeed()
    {
        double pace = GetPace();
        double speed = 60/pace;
        return speed;
    }
    public override double GetPace()
    {
        double distance = GetDistance();
        double pace = _timelength / distance;
        return pace;
    }
    public override string GetSummary()
    {
        _activity = "Swimming";
        return base.GetSummary();
    }
}