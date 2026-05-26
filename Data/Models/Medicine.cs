using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace team3.Data.Models;

public class Medicine : Document {
    [Required]
    public required string Name { get; set; }

    [DefaultValue(0)]
    [Range(0, int.MaxValue)]
    public int Quantity { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public required double Price { get; set; }
}
