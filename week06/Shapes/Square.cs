using System.Diagnostics.CodeAnalysis;

public class Square : Shape{
    private double _side;
    public void SetSide(double side){
        _side = side;
    }
    public override double GetArea(){
        return _side*_side;
    }
}