namespace Home_work_4;

public class Polygon : IShape
{
    private double sideLength;
    private double numberСorners;

    public Polygon(double sideLength, double numberСorners)
    {
        this.numberСorners = numberСorners;
        this.sideLength = sideLength;
    }


    public double GetArea()
    {
        return (numberСorners * sideLength * sideLength) / (4 * Math.Tan(Math.PI / numberСorners));

    }

    public double GetPerimeter()
    {
        return numberСorners * sideLength;
    }
    
    public (double, double) GetLength()
    {
        return (sideLength, numberСorners);
    }
    

    public void SetLengthNumber(double sideLength, double numberСorners)
    {
        this.numberСorners = numberСorners;
        this.sideLength = sideLength;
    } 
    
}