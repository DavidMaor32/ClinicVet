using ClinicVet.App.Data.Models;

namespace ClinicVet.Models;

public class Visit
{
    public int Id { get; set;}
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public string Diagnose { get; set; }
    public string VetName { get; set; }

    public string AnimalChipSerial { get; set; }
    public Animal Animal { get; set; }
}
