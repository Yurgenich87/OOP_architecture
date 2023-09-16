namespace Home_work_3;


public class CarWithSweeping : Car, ICar
{
    private string fuelType;
    public CarWithSweeping(string brand, string model, string color, string bodyType, int numberOfWheels,
        string fuelType, string transmissionType, double engineVolume)
        : base(brand, model, color, bodyType, numberOfWheels, fuelType, transmissionType, engineVolume)
    {
        this.fuelType = fuelType;
    }
    
    public bool SweepStreet(bool isSweeping = true)
    {
        if (isSweeping)
        {
            Console.WriteLine("Автомобиль подметает улицу.");
            return true;
        }
        else
        {
            Console.WriteLine("Автомобиль не подметает улицу.");
            return false;
        }
    }
}
