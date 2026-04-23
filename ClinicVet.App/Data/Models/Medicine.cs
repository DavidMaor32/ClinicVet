using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicVet.Models;

public class Medicine
{
    [Key]    
    public required string Name { get; set; }
    public uint Quantity { get; set; } = 0;

    [Column(TypeName = "decimal(6,2)")]
    public decimal Price { get; set; }

}