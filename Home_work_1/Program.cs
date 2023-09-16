using System;
using ModelElements;
using InMemoryModel;


class Program
{
    static void Main()
    {
        // Создаем объекты Point3D, Angle3D, Color для использования в Flash и Camera
        Point3D flashLocation = new Point3D { X = 10, Y = 20, Z = 5 };
        Console.WriteLine($"Flash Location: X={flashLocation.X}, Y={flashLocation.Y}, Z={flashLocation.Z}");
        Angle3D flashAngle = new Angle3D { Pitch = 30, Yaw = 45, Roll = 10 };
        Console.WriteLine($"Flash Angle: Pitch={flashAngle.Pitch}, Yaw={flashAngle.Yaw}, Roll={flashAngle.Roll}");
        Color flashColor = new Color { Red = 255, Green = 200, Blue = 0 };
        Console.WriteLine($"Flash Color: Red={flashColor.Red}, Green={flashColor.Green}, Blue={flashColor.Blue}");

        Point3D cameraLocation = new Point3D { X = 5, Y = 10, Z = 2 };
        Console.WriteLine($"Camera Location: X={cameraLocation.X}, Y={cameraLocation.Y}, Z={cameraLocation.Z}");
        Angle3D cameraAngle = new Angle3D { Pitch = 15, Yaw = 30, Roll = 5 };
        Console.WriteLine($"Camera Angle: Pitch={cameraAngle.Pitch}, Yaw={cameraAngle.Yaw}, Roll={cameraAngle.Roll}");

        // Создаем объекты Flash и Camera
        Flash flash = new Flash(flashLocation, flashAngle, flashColor, 100.0f);
        Camera camera = new Camera { Location = cameraLocation, Angle = cameraAngle };

        // Создаем объекты Poligon и Texture для использования в PoligonalModel
        Point3D point1 = new Point3D { X = 0, Y = 0, Z = 0 };
        Point3D point2 = new Point3D { X = 1, Y = 1, Z = 1 };
        Point3D point3 = new Point3D { X = 2, Y = 2, Z = 2 };

        List<Point3D> points = new List<Point3D> { point1, point2, point3 };
        Poligon poligon = new Poligon { Points = points };
        Texture texture = new Texture();

        // Создаем объект PoligonalModel
        PoligonalModel model = new PoligonalModel(poligon, texture);

        // Создаем объект MyModelChangeObserver
        MyModelChangeObserver observer = new MyModelChangeObserver();

        // Создаем объект Scene и ModelStore
        Scene scene = new Scene(1, model, flash);
        ModelStore modelStore = new ModelStore(observer);

        // Используем методы Rotate и Move на Flash и Camera
        Angle3D newFlashAngle = new Angle3D { Pitch = 5, Yaw = 10, Roll = 2 };
        flash.Rotate(newFlashAngle);

        Point3D newCameraLocation = new Point3D { X = 3, Y = 4, Z = 5 };
        camera.Move(newCameraLocation);
        
        
        // Вызываем методы Method1 и Method2 на Scene
        Type argumentType = typeof(string);
        scene.Method1(argumentType);
        scene.Method2(typeof(int), typeof(double));
        
        IModelChanger myChanger = new MyModelChanger(); // Создайте объект, реализующий IModelChanger
        modelStore.NotifyChange(myChanger); // Вызов метода NotifyChange с объектом, реализующим интерфейс IModelChanger

        // Вызываем метод NotifyChange на ModelStore
        modelStore.NotifyChange(myChanger);

        Console.WriteLine("Пример использования всех классов успешно выполнен.");
    }
}
