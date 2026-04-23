using System.ComponentModel.DataAnnotations;

namespace ClinicVet.App.Data.Models;

public class Role
{
    [Key]
    [StringLength(20)]
    public required string Name { get; set; }
}