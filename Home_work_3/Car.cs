public abstract class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public string BodyType { get; set; }
    public int NumberOfWheels { get; set; }
    public string FuelType { get; private set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }

    
    public Car(string brand, string model, string color, string bodyType, int numberOfWheels, string fuelType, 
        string transmissionType, double engineVolume)
    {
        Brand = brand;
        Model = model;
        Color = color;
        BodyType = bodyType;
        NumberOfWheels = numberOfWheels;
        FuelType = fuelType;
        TransmissionType = transmissionType;
        EngineVolume = engineVolume;
    }
    
    public string GetCarInfo()
    {
        return $"Марка: {Brand}, Модель: {Model}, Цвет: {Color},Тип кузова: {BodyType},Число колес: {NumberOfWheels}, Тип топлива: {FuelType}, Тип коробки передач: {TransmissionType}, Объем двигателя: {EngineVolume}";
    }

    public void Move()
    {
        Console.WriteLine("Автомобиль движется.");
    }

    public void Service()
    {
        Console.WriteLine("Автомобиль находится на техническом обслуживании.");
    }

    public void ShiftGear()
    {
        Console.WriteLine("Переключение передач.");
    }

    public void TurnOnHeadlights()
    {
        Console.WriteLine("Фары включены.");
    }

    public void TurnOffWipers()
    {
        Console.WriteLine("Дождь кончился, Дворники выключены.");
    }
    
    public void TurnOnWipers()
    {
        Console.WriteLine("Пошел дождь, Дворники включены.");
    }

    // Абстрактный метод для подметания улицы
    
    
    public void FuelingFueling()
    {
        Console.WriteLine($"Заправка автомобиля {Brand}{Model} топливом: {FuelType}");
    }

    void WindshieldWipe()
    {
        Console.WriteLine("Протираем лобовое стекло");
    }

    void HeadlightWipe()
    {
        Console.WriteLine("Протираем фары");
    }

    void WipingMirrors()
    {
        Console.WriteLine("Протираем зеркала");
    }
}