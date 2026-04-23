using System.ComponentModel.DataAnnotations;

namespace ClinicVet.App.Data.Models;

public abstract class Person
{
    [Key]
    [StringLength(9)]
    public required string Id { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Email is not valid")]
    public required string Email { get; set; }
}