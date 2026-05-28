using System.ComponentModel.DataAnnotations;

namespace ClinicVet.Data.Models;

public abstract class Person : Document
{
    [Required]
    [EmailAddress]
    public required string Email { get; set; }

    [Required]
    [RegularExpression(@"^\d{9}$", ErrorMessage = "Id must be 9 digits.")]
    public required string Id { get; set; }
}
