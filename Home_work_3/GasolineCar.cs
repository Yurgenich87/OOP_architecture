namespace Home_work_3;

public class GasolineCar : Car
{
    private string fuelType;
    public GasolineCar(string brand, string model, string color, string bodyType, int numberOfWheels, string fuelType, string transmissionType, double engineVolume)
        : base(brand, model, color, bodyType, numberOfWheels, fuelType, transmissionType, engineVolume)
    {
        this.fuelType = fuelType;
    }

    public void GasolineRefueling()
    {
        FuelingFueling();
    }
}