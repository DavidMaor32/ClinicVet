namespace ClinicVet.Data.Models;

public class PrescribedMedicine {
    public required string MedicineName { get; set; }
    public int Quantity { get; set; }
    public double UnitPrice { get; set; }
    public double TotalPrice => UnitPrice * Quantity;
}
