namespace Home_work_4;

public class Triangle : IShape
{
    private double length1;
    private double length2;
    private double length3;

    public Triangle(double length1, double length2, double length3)
    {
        this.length1 = length1;
        this.length2 = length2;
        this.length3 = length3;
    }

    public double GetArea()
    
    {
        double s = GetPerimeter() / 2;
        return Math.Sqrt(s * (s - length1) * (s - length2) * (s - length3));
    }
    

    public double GetPerimeter()
    {
        return length1 + length2 + length3;
    }
    
    public (double, double, double) GetLength()
    {
        return (length1, length2, length3);
    }
    

    public void SetLength(double length1, double length2, double length3)
    {
        this.length1 = length1;
        this.length2 = length2;
        this.length3 = length3;
    } 
    
}