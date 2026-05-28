using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace ClinicVet.Data.Models;

public class Visit : Document {
    public static readonly double BASE_PRICE = 100;

    [Required]
    public required string Reason { get; set; }

    public DateTime DateTime { get; set; } = DateTime.Now;

    [Required]
    public required string Diagnosis { get; set; }

    [Required]
    public required string VetWorkerId { get; set; }

    public List<PrescribedMedicine> PrescribedMedicines { get; set; } = new();

    public string PrescribedMedicinesJson => JsonSerializer.Serialize(PrescribedMedicines);
}
