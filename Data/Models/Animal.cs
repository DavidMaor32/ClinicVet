using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClinicVet.Data.Models;

public class Animal : Document
{
    [Required]
    public required string Name {  get; set; }

    [Required]
    public required string AnimalType { get; set; }

    [Required]
    [Range(0.1, 100)]
    public required double Weight { get; set; }

    [Required]
    public required DateOnly Birthdate { get; set; }

    [DefaultValue(null)]
    public DateOnly LastVaccine { get; set; }

    [Required]
    public required string ChipSerial { get; set; }
    
    [Required]
    public required int OwnerId { get; set; }
}
