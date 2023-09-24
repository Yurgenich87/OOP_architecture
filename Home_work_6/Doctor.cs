namespace Home_work_6;

public class Doctor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Speciality { get; set; }

    public Doctor(int id, string name, string speciality)
    {
        Id = id;
        Name = name;
        Speciality = speciality;
    }

    public void GetDoctor()
    {
        Console.WriteLine($"Id: {Id}, ФИО: {Name}, специальность: {Speciality}");
    }
}