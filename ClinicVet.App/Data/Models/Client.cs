using System.ComponentModel.DataAnnotations;
using ClinicVet.App.Data.Models;

namespace ClinicVet.Models;

public class Client : Person
{
    public string FullName { get; set; }

    [Phone]
    public string Phone { get; set; }


    public ICollection<Animal> Animals { get; set; }
}
