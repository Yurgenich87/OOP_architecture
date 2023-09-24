namespace Home_work_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Clinic clinic = new Clinic();
            
            // Добавление докторов
            clinic.AddDoctorToListInClinic(1, "Иванов Петр Евгеньевич", "педиатор");
            clinic.AddDoctorToListInClinic(2, "Смирнова Анна Ивановна", "гинеколог");
            clinic.AddDoctorToListInClinic(3, "Павлов Дмитрий Сергеевич", "офтальмолог");
            clinic.AddDoctorToListInClinic(4, "Козлов Александр Михайлович", "стоматолог");
            clinic.AddDoctorToListInClinic(5, "Сидорова Мария Александровна", "терапевт");
            clinic.AddDoctorToListInClinic(6, "Егоров Иван Дмитриевич", "хирург");
            
            // Дабавление пациентов
            clinic.AddPatientToListInClinic(1, "Пронько Василий Петрович");
            clinic.AddPatientToListInClinic(2, "Иванова Екатерина Сергеевна");
            clinic.AddPatientToListInClinic(3, "Петров Павел Дмитриевич");
            clinic.AddPatientToListInClinic(4, "Смирнова Анна Ивановна");
            clinic.AddPatientToListInClinic(5, "Козлов Михаил Александрович");
            clinic.AddPatientToListInClinic(6, "Дмитриева Ольга Владимировна");
            clinic.AddPatientToListInClinic(7, "Сидоров Алексей Николаевич");
            clinic.AddPatientToListInClinic(8, "Павлова Мария Дмитриевна");
            clinic.AddPatientToListInClinic(9, "Григорьев Иван Сергеевич");
            clinic.AddPatientToListInClinic(10, "Семенова Елена Петровна");
            
            
            Console.WriteLine("<<<Запись пациентов>>>");
            clinic.AddRecord("10:00", "терапевт", 2);
            // clinic.AddRecord("10:30", "терапевт", 3);
            // clinic.AddRecord("11:00", "терапевт", 1);
            // clinic.AddRecord("12:00", "хирург", 1);
            
            Console.WriteLine("<<<Вывод журнала записи>>>");
            clinic.DisplayRecord();
            
            Console.WriteLine("<<<Перенос записи:>>>");
            clinic.RecordTransfer("12:30", "хирург", 2);
            
            Console.WriteLine("<<<Вывод журнала записи>>>");
            clinic.DisplayRecord();
            
            Console.WriteLine("<<<Отмена записи по Id пациента>>>");
            clinic.RecordRemove(2);
            
            Console.WriteLine("<<<Приход пациента>>>");
            clinic.PatientArrival(2);

            Console.WriteLine("<<<Уход пациента>>>");
            clinic.PatientDeparture(2);

            Console.WriteLine("<<<Вывод журнала записи>>>");
            clinic.DisplayRecord();
        }
    }
}

