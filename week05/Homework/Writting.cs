public class WrittingAssignment : Assignment{
    private string _title;
    public WrittingAssignment(string student,string topic, string title) :  base(student,topic){
        _title = title;
    }
    public string GetWrittingInformation(){
        return $"{_title} by {_studentName}";
    }
}