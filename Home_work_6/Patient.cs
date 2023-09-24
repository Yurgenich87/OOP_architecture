namespace Home_work_6;

public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Patient(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void GetPatient()
    {
        Console.WriteLine($"Id: {Id}, ФИО: {Name}");
    }
    
}