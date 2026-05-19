using System.ComponentModel.DataAnnotations;

namespace ClinicVet.Data.Models;

public class Client : Person
{
    [Required]
    [RegularExpression(@"^([A-Za-z][a-z]{1,19})(\\ (?1)){1,3}$", ErrorMessage = "FullName must be only letters")]
    public required string FullName {  get; set; }

    [Required]
    [Phone(ErrorMessage = "Invalid phone number format")]
    public required string Phone { get; set; }
}
