namespace ClinicVet.App.Data.Models;

public class Worker : Person
{
    public required string WorkerId { get; set; }
    public required string Username { get; set; }
    public required string Password { get; set; }
    public required Role Role { get; set; }

}
