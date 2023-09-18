namespace  Home_work_4;

class Program
{
    static void Main(string[] args)
    {
        GeometryFigure figureBox = new GeometryFigure();

        Circle circle1 = new Circle(4);
        figureBox.Add(circle1);
        figureBox.GetInfo(0);

        Square square1 = new Square(3);
        figureBox.Add(square1);
        figureBox.GetInfo(1);

        Rectangle rectangle1 = new Rectangle(2, 6);
        figureBox.Add(rectangle1);
        figureBox.GetInfo(2);

        Triangle triangle1 = new Triangle(3, 4, 2);
        figureBox.Add(triangle1);
        figureBox.GetInfo(3);

        Polygon polygon1 = new Polygon(3, 5);
        figureBox.Add(polygon1);
        figureBox.GetInfo(4);
        Polygon polygon2 = new Polygon(2, 6);
        figureBox.Add(polygon2);
        Console.WriteLine("------------");
        figureBox.Find(polygon1);
        figureBox.Find(polygon2);
        figureBox.Modify(4, polygon2);
        figureBox.Find(polygon1);
        figureBox.Find(polygon2);
        Console.WriteLine("------------");
        figureBox.Find(triangle1);
        figureBox.Remove(1);
        figureBox.Find(triangle1);
        






    }
}

