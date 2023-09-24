using System.Threading.Channels;

namespace Home_work_6;

public class Record
{
    public Doctor Doctor { get; set; }
    public DateTime Date { get; set; }
    public Patient Patient { get; set; }
}
