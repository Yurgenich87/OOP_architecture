public abstract class ExtendedCar : Car
{
    public ExtendedCar(string brand, string model, string color, string bodyType, int numberOfWheels, string fuelType, string transmissionType, double engineVolume)
        : base(brand, model, color, bodyType, numberOfWheels, fuelType, transmissionType, engineVolume)
    {
    }

    // Метод для включения противотуманных фар
    public void TurnOnFogLights()
    {
        Console.WriteLine("Противотуманные фары включены.");
    }

    // Абстрактный метод для перевозки груза
    public abstract void TransportCargo();
}