using System;
using ModelElements;

namespace ModelElements

{
    public class Flash
    {
        public Point3D Location { get; set; }
        public Angle3D Angle { get; set; }
        public Color Color { get; set; }
        public float Power { get; set; }

        public Flash(Point3D location, Angle3D angle, Color color, float power)
        {
            Location = location;
            Angle = angle;
            Color = color;
            Power = power;
        }

        public void Rotate(Angle3D angle)
        {
            // Реализация метода Rotate
            Console.WriteLine($"Поворот вспышки на угол: {angle}");
        }

        public void Move(Point3D point)
        {
            // Реализация метода Move
            Console.WriteLine($"Перемещение вспышки на место: {point}");
        }
    }

   public class Color
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
    }
}