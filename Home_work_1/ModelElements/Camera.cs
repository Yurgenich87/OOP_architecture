using System;

namespace ModelElements
{
    public class Camera
    {
        public Point3D Location { get; set; } = new Point3D(); 
        public Angle3D Angle { get; set; } = new Angle3D();    

        public void Rotate(Angle3D angle)
        {
            // Изменение угла камеры
            Angle.Pitch += angle.Pitch;
            Angle.Yaw += angle.Yaw;
            Angle.Roll += angle.Roll;
        }

        public void Move(Point3D point)
        {
            // Перемещение камеры
            Location.X += point.X;
            Location.Y += point.Y;
            Location.Z += point.Z;
        }
    }

    public class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class Angle3D
    {
        public double Pitch { get; set; }
        public double Yaw { get; set; }
        public double Roll { get; set; }
    }
}