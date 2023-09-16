namespace Home_work_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CarWithSweeping car1 = new CarWithSweeping("Камаз", "58125", "Оранжевый", "Спецмашина", 10, "Дизель", "Механика", 4.5);
            car1.FuelingFueling();
            car1.GetCarInfo();
            car1.TurnOnHeadlights();
            car1.Move();
            car1.SweepStreet();
            car1.ShiftGear();
            car1.TurnOnWipers();

            Console.WriteLine("-----------------------------");
            CarWithCargoTransport car2 = new CarWithCargoTransport("Ford", "Transit", "Белый", "Фургон", 4, "Дизель", "Механика", 2,8);
            car2.FuelingFueling();
            car2.TransportCargo();
            car2.GetCarInfo();
            car2.TurnOnHeadlights();
            car2.Move();
            car2.ShiftGear();
            car2.TurnOnWipers();
            car2.SweepStreet();
            
            Console.WriteLine("-----------------------------");
            CarWithThreeWheels car3 = new CarWithThreeWheels("Simson", "DUO", "Красный", "мотокик", "Бензин", "Механика", 2, 7);
            car3.FuelingFueling();
            car3.GetCarInfo();
            car3.TurnOnHeadlights();
            car3.Move();
            car3.ShiftGear();
            car3.TurnOffWipers();
            car3.SweepStreet();
            
            
            Console.ReadKey();
        }
    } 
}
