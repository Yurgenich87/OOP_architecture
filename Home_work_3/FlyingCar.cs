namespace Home_work_3;

public class FlyingCar : Car
{
    public FlyingCar(string brand, string model, string color, string bodyType, int numberOfWheels, string fuelType, string transmissionType, double engineVolume)
        : base(brand, model, color, bodyType, numberOfWheels, fuelType, transmissionType, engineVolume)
    {
    }

    // Метод для полета
    public void Fly()
    {
        Console.WriteLine("Автомобиль летит.");
    }

    
} 
