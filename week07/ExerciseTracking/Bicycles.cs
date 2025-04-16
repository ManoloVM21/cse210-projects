public class Cycling : Activity{
    private double _distance;
    public Cycling(int legth, double distance): base(legth){
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        double speed = (_distance / _timelength) * 60;
        return speed;
    }
    public override double GetPace()
    {
        double pace = _timelength / _distance;
        return pace;
    }
    public override string GetSummary()
    {
        _activity = "Cycling";
        return base.GetSummary();
    }
}