using Home_work_3;

public class CarWithCargoTransport : ExtendedCar, ICar
{
    private string fuelType;
    public CarWithCargoTransport(string brand, string model, string color, string bodyType, int numberOfWheels,
        string fuelType, string transmissionType, int volume, double engineVolume)
        : base(brand, model, color, bodyType, numberOfWheels, fuelType, transmissionType, engineVolume)
    {
        this.fuelType = fuelType;
    }

    // Реализация метода для перевозки груза
    public override void TransportCargo()
    {
        Console.WriteLine($"Автомобиль {Brand} {Model} перевозит груз.");
    }

    
    public bool SweepStreet(bool isSweeping = true)
    {
        if (isSweeping)
        {
            Console.WriteLine($"Автомобиль {Brand} {Model} не может подметать, он перевозит груз.");
            return false;
        }
        else
        {
            Console.WriteLine($"Автомобиль {Brand} {Model} не подметает улицу.");
            return false;
        }
    }
}