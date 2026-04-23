using ClinicVet.Models;

namespace ClinicVet.App.Data.Models;

public class Animal
{
    public required string Name { get; set; }

    public AnimalType AnimalType { get; set; }
    public decimal Weight { get; set; }
    public DateOnly BirthDate { get; set; }
    public DateOnly LastVaccine { get; set; }
    public string ChipSerial { get; set; }
    public string OwnerId { get; set; }

    public Client Owner { get; set; }
    public ICollection<Visit> Visits { get; set; }
}