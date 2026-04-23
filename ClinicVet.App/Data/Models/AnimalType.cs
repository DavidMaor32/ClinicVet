using System.ComponentModel.DataAnnotations;

namespace ClinicVet.App.Data.Models;

public class AnimalType
{
    [Key]
    [StringLength(20)]
    public required string Name { get; set; }
}