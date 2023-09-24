
namespace Home_work_6;

public class Clinic
{
    public List<Doctor> DoctorsList { get; set; }
    public List<Patient> PatientsList { get; set; }
    public List<Record> RecordsList { get; set; }

    private Dictionary<string, Record> appointments = new Dictionary<string, Record>();
    
    public Clinic()
        {
            DoctorsList = new List<Doctor>();
            PatientsList = new List<Patient>();
            InitializeTimeSlots();
        }
    
    // Метод для инициализизации словаря с пустыми записями для каждого времени
    private void InitializeTimeSlots()
    {
        List<string> recordingTime = new List<string>
        {
            "09:00", "09:30", "10:00", "10:30", "11:00", "11:30",
            "12:00", "12:30", "13:00", "13:30", "14:00", "14:30",
            "15:00", "15:30", "16:00", "16:30", "17:00"
        };

        foreach (string time in recordingTime)
        {
            
            appointments[time] = null;
        }
    }
    
    // Метод для добавления докторов в список клиники
    public void AddDoctorToListInClinic(int id, string name, string specialty)
    {
        Doctor doctor = new Doctor(id, name, specialty);
        DoctorsList.Add(doctor);
    }
    
    // Метод для вывода списка докторов
    public void GetDortorsClinic()
    {
        Console.WriteLine($"Список докторов:");
        foreach (var doctorVariable in DoctorsList)
        {
            doctorVariable.GetDoctor();
        }
        
    }
    
    // Метод для добавления пациентов в список клиники
    public void AddPatientToListInClinic(int id, string name)
    {
        Patient patient = new Patient(id, name);
        PatientsList.Add(patient);
        
    }
    
    // Метод для вывода списка пациентов
    public void GetPatientClinic()
    {
        Console.WriteLine($"Список пациентов:");
        foreach (var patientVariable in PatientsList)
        {
            patientVariable.GetPatient();
        }
        
    }
    
    // Метод для записи пациента
    public bool AddRecord(string time, string doctorSpecialization, int patientId)
    {
        // Проверяем, занято ли выбранное время
        if (appointments.ContainsKey(time) && appointments[time] == null)
        {
            // Находим доктора с указанной специальностью
            Doctor doctor = DoctorsList.FirstOrDefault(d => d.Speciality == doctorSpecialization);
        
            // Находим пациента с указанным идентификатором
            Patient patient = PatientsList.FirstOrDefault(p => p.Id == patientId);
        
            // Проверяем, что доктор и пациент найдены
            if (doctor != null && patient != null)
            {
                // Создаем запись
                Record record = new Record
                {
                    Date = DateTime.Today.Add(TimeSpan.Parse(time)),
                    Doctor = doctor,
                    Patient = patient
                };

                // Добавляем запись в словарь
                appointments[time] = record;
                Console.WriteLine($"{patient.Name} записан(а) на {time} к доктору: {doctor.Name}");
                return true;
            }
            else
            {
                Console.WriteLine("Доктор с указанной специальностью или пациент с указанным идентификатором не найдены.");
                return false;
            }
        }
        else
        {
            Console.WriteLine($"Выбранное время {time} уже занято или не существует.");
            return false;
        }
    }
    
    // Метод для вывода записанных пациентов
    public void DisplayRecord()
    {
        Console.WriteLine("Журнал записей:");
        foreach (var kvp in appointments)
        {
            string time = kvp.Key;
            Record record = kvp.Value;

            if (record != null)
            {
                Console.WriteLine($"{time}: {record.Patient.Name} записана к доктору: {record.Doctor.Name}");
            }
        }
    }
    
    // Метод прихода пациента(Открыл запись)
    public Record PatientArrival(int patientId)
    {
        if (patientId != null)
        {
            foreach (var findIDPatient in appointments)
            {
                Record record = findIDPatient.Value;

                if (record != null && (record.Patient.Id == patientId))
                {
                    Console.WriteLine($"Пациент {record.Patient.Name} пришел(а) в поликлинику к врачу: {record.Doctor.Name}.");
                    return record;
                }
            }

        }

        Console.WriteLine($"Пациент с идентификатором {patientId} не найден.");
        return null; // Если пациент не найден в записях}
    }

    // Метод ухода пациента(Закрыл запись)
    public Record PatientDeparture(int patientId)
    {
        foreach (var patientName in appointments)
        { 
            Record record = patientName.Value;
            
            if (record != null && (record.Patient.Id == patientId))
            {
                Console.WriteLine($"Пациент {record.Patient.Name} ушел(a) из поликлиники.");
                RecordRemove(patientId);
                return record;
            }
            
        }
        Console.WriteLine($"Пациент с идентификатором {patientId} не найден.");
        return null;
    }
    
    // Метод для отмены записи пациента
    public void RecordRemove(int patientId)
    {
        foreach (var findPatient in appointments)
        {
            string time = findPatient.Key;
            Record record = findPatient.Value;

            if (record != null && record.Patient.Id == patientId)
            {
                // Найдена запись с нужным patientId, устанавливаем ее в null
                appointments[time] = null;
                Console.WriteLine($"Доктор {record.Doctor.Name} уведомлен об удалении записи");
            }
        } 
        
        
    }
    
    
    // Метод для переноса записи пациента
    public void RecordTransfer(string time, string doctorSpecialization, int patientId)
    {
        // Находим доктора с указанной специальностью
        Doctor doctor = DoctorsList.FirstOrDefault(d => d.Speciality == doctorSpecialization);

        if (doctor != null)
        {
            string doctorName = doctor.Name;
            RecordRemove(patientId);
            AddRecord(time, doctorSpecialization, patientId);
            Console.WriteLine($"Доктор {doctorName} уведомлен о новой записи");
        }
        else
        {
            Console.WriteLine("Доктор с указанной специальностью не найден.");
        }
    }

}