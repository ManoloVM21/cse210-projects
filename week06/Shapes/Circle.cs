public class Circle : Shape{
    private double _radius;
    public Circle(double radius){
        _radius = radius;
    }
    public override double GetArea()
    {
        double pi = Math.PI;

        return _radius *_radius* pi;
    }
}