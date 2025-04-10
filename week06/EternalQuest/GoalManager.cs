using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Runtime.ExceptionServices;

public class GoalManager{
    protected List<Goal> _goals;
    protected int _score;
    private string _level;
    public GoalManager(){
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start(){
        Console.Clear();
        string answer = "0";
        
        do{
            if (_score >= 1000) {
            _level = "Level 8: Lion King";
            }
            else if (_score >= 900) {
                _level = "Level 7: Rabious Monkey";
            }
            else if (_score >= 750) {
                _level = "Level 6: Venomous Snake";
            }
            else if (_score >= 600) {
                _level = "Level 5: Furious Wolf";
            }
            else if (_score >= 400) {
                _level = "Level 4: Agresive Kitty";
            }
            else if (_score >= 250) {
                _level = "Level 3: Chill Capibara";
            }
            else if (_score >= 100) {
                _level = "Level 2: Chicken Little";
            }
            else {
                _level = "Level 1: Stuart Little";
            }

            DisplayPlayerInfo();
            Console.WriteLine($"\nMenu Options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6.Quit");
            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();

            if (answer =="1"){     
                CreateGoal(); 
            }
            if (answer == "2"){
                ListGoalDetails();
            }
            if (answer == "3"){
                SaveGoal();
            }
            if (answer == "4"){
                LoadGoals();
            }
            if (answer == "5"){
                RecordEvent();
            }

        } while (answer != "6");
    }
    public void DisplayPlayerInfo(){
Console.WriteLine($"\n{_level}");
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalName(){
        int index = 1;
        Console.WriteLine("The goals are:");
        foreach(Goal goal in _goals){
            Console.WriteLine($"{index}. {goal.Getname()}");
            index++;
        }
    }
    public void ListGoalDetails(){
        int index = 1;
        Console.WriteLine("The goals are:");
        foreach(Goal goal in _goals){
            string desc = goal.GetDetailsString();
            string mark = "";
            if (goal.IsComplete()){
                mark = "X";
            } else mark = " ";
            Console.WriteLine($"{index}. [{mark}] {desc}");
            index++;
        }
    }
    public void CreateGoal(){
                Console.WriteLine("The types of Goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");
                string answer2 = "";
                Console.Write("Which type of goal would you like to create? ");
                answer2 = Console.ReadLine();
                
                Console.Write("What is the name of your goal? ");
                string goalName = Console.ReadLine();
                
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                string points = Console.ReadLine();
                if (answer2 == "1"){
                    SimpleGoal simple = new SimpleGoal(goalName,description,points);
                    _goals.Add(simple);
                }
                if (answer2 == "2"){
                    EternalGoal eternal = new EternalGoal(goalName,description,points);
                    _goals.Add(eternal);
                }
                if (answer2=="3"){
                    Console.Write("How many times does this goal need to be accomplished? ");
                    string time = Console.ReadLine();
                    int times = int.Parse(time);

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    string bonu = Console.ReadLine();
                    int bonus = int.Parse(bonu);
                    ChecklistGoal checklist = new ChecklistGoal(goalName,description,points,times,bonus);
                    _goals.Add(checklist);
                }
    }
    public void RecordEvent(){
        ListGoalName();
        Console.Write("Which goal did you accomplish? ");
        string accomplished = Console.ReadLine();
        int accIndex = int.Parse(accomplished)-1;
        _goals[accIndex].RecordEvent();
        int points =_goals[accIndex].GetPoints();
        _score += points;
        Console.WriteLine($"You now have {_score} points.");
    }
    public void SaveGoal(){
        string filename = "myGoals.txt";
        using (StreamWriter outputFile = new StreamWriter(filename)){
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals){
                string str = goal.GetStringRepresentation();
                outputFile.WriteLine(str);
            }
        }
        Console.WriteLine($"Your goals have been saved in {filename}");
    }
    public void LoadGoals(){
        Console.Write("What is the filename of the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        foreach (string line in lines.Skip(1))
        {
            string[] classAndDetails = line.Split(":");
            string type = classAndDetails[0];
            string[] details = classAndDetails[1].Split(",");
            Goal goal = null;
            if (type == "SimpleGoal"){
                goal = new SimpleGoal(details[0],details[1],details[2],bool.Parse(details[3]));
            }
            else if (type == "EternalGoal"){
                goal = new EternalGoal(details[0],details[1],details[2]);
            }
            else{
                goal = new ChecklistGoal(details[0],details[1],details[2],int.Parse(details[3]),int.Parse(details[4]));
            }
            _goals.Add(goal);
        }
        Console.WriteLine("Your file has been loaded");
    }
}