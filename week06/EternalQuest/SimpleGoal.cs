using System.Diagnostics.Contracts;

public class SimpleGoal : Goal{
    private bool _isComplete;
    public SimpleGoal(string name, string description, string points):base( name,description,points){
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }
    public SimpleGoal(string name, string description, string points,bool IsComplete):base( name,description,points){
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = IsComplete;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}