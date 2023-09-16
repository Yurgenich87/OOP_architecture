namespace Home_work_3;

public class CarWithThreeWheels : Car
    {
        public CarWithThreeWheels(string brand, string model, string color, string bodyType, string fuelType,
            string transmissionType, int volume, double engineVolume)
            : base(brand, model, color, bodyType, 3, fuelType, transmissionType, engineVolume)
        {
        }
        
        public bool SweepStreet(bool isSweeping = true)
        {
            if (isSweeping)
            {
                Console.WriteLine($"Автомобиль {Brand} {Model} не может подметать улицу, у него 3 колеса.");
                return false;
            }
            else
            {
                Console.WriteLine($"Автомобиль {Brand} {Model} не подметает улицу.");
                return false;
            }
        }
            
        
    }
