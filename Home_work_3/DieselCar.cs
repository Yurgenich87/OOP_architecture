namespace Home_work_3;

public class DieselCar : Car
{
    private string fuelType;
    public DieselCar(string brand, string model, string color, string bodyType, int numberOfWheels, string fuelType, string transmissionType, double engineVolume)
        : base(brand, model, color, bodyType, numberOfWheels, fuelType, transmissionType, engineVolume)
    {
        this.fuelType = fuelType;
    }
    
    public void DieselRefueling()
    {
        FuelingFueling();
    }
}