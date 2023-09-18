namespace Home_work_4;

public class Square : IShape
{
    private double sideLength;
    
    public Square(double sideLength)
    {
        this.sideLength = sideLength;
    }

    public double GetArea()
    {
        return sideLength * sideLength ;
    }

    public double GetPerimeter()
    {
        return sideLength * 4;
    }

    public double GetSideLength()
    {
        return sideLength;
    }

    public void SetSideLength(double sideLength)
    {
        this.sideLength = sideLength;
    } 
    
    
}