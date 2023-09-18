namespace Home_work_4;

public class Rectangle : IShape
{
    private double length;
    private double width;
    
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double GetArea()
    {
        return length * width;
    }

    public double GetPerimeter()
    {
        return length * 2 + width * 2;
    }
    
    public (double, double) GetLengthWidth()
    {
        return (length, width);
    }
    

    public void SetLength(double length, double width)
    {
        this.length = length;
        this.width = width;
    } 
    
}