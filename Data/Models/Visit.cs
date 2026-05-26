using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace team3.Data.Models;

public class Visit : Document {
    public static readonly double BASE_PRICE = 100;

    [Required]
    public required string Reason { get; set; }

    public DateTime DateTime { get; set; } = DateTime.Now;

    [Required]
    public required string Diagnosis { get; set; }

    [Required]
    public required string VetWorkerId { get; set; }
    [Required]
    public required int AnimalId { get; set; }

    public List<PrescribedMedicine> PrescribedMedicines { get; set; } = new();
    public double MedicinesPrice
    {
        get
        {
            return PrescribedMedicines.Sum(m => m.TotalPrice);
        }
    }
    public double TotalPrice
    {
        get
        {
            return BASE_PRICE + MedicinesPrice;
        }
    }

    public string PrescribedMedicinesJson => JsonSerializer.Serialize(PrescribedMedicines);
}
