public class Rectangle : Shape
{
    private double _height;
    private double _width;
    public Rectangle(double height, double width)
    {
        _height = height;
        _width = width;
    }
    public override double calculateArea()
    {
        return _height*_width;
    }
}