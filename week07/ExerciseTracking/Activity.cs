public abstract class Activity{
    protected string _activity;
    protected DateTime _date = DateTime.Now;
    protected int _timelength;
    public Activity(int legth){
        _timelength = legth;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary(){
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        string date = _date.ToString("dd MMM yyyy", new System.Globalization.CultureInfo("en-US"));
        return $"{date} {_activity} ({_timelength} min)- Distance {Math.Round(distance,3)} km, Speed {Math.Round(speed,2)} kph, Pace {Math.Round(pace,2)} per km";
    }
}