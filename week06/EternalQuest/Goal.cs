public abstract class Goal{
    protected string _shortName;
    protected string _description;
    protected string _points;
    public Goal(string name, string description, string points){
        _shortName = name;
        _description = description;
        _points = points;
    }
    public virtual int GetPoints(){
        int points = int.Parse(_points);
        return points;
    }
    public string Getname(){
        return _shortName;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString(){
        return $"{_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();

}