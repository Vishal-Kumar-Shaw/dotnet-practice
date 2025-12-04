public class Circle: Shape
{
    private double _radius;
    public Circle(double radius)
    {
        if (radius <= 0) throw new ArgumentException("Radius must be positive");
        _radius = radius;
    }
    public override double calculateArea()
    {
        return Math.PI*_radius*_radius;
    }
}