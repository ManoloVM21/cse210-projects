using System.Globalization;

public class ChecklistGoal : Goal{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, string points, int target, int bonus): base(name,description,points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
    }
    public override int GetPoints()
    {
        if (_amountCompleted >= _target){
            return base.GetPoints()+_bonus;
        } else return base.GetPoints();
        
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        if (_amountCompleted >= _target){
            IsComplete();
            Console.WriteLine($"Congratulations! You have reached your goal! You have earned {_bonus} extra points!");
        }
    }
    public override bool IsComplete()
    {
        if(_amountCompleted >= _target){
            return true;
        }else return false;
    }
    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) -- Completion {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}