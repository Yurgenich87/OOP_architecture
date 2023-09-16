using System.Collections.Generic; 
using ModelElements;

public class Poligon
{
    public List<Point3D> Points { get; set; } // Используем  для хранения нескольких точек

    public Poligon()
    {
        Points = new List<Point3D>(); // Инициализируем Points пустой коллекцией List<Point3D>
    }
}