using System.ComponentModel.DataAnnotations;

namespace ClinicVet.Data.Models;
public class Worker : Person
{
    [Required(ErrorMessage = "Username is required")]
    [StringLength(8, MinimumLength = 6, ErrorMessage = "Username must be 6-8 characters")]
    [CustomValidation(typeof(Worker), nameof(validateUsername))]
    public required string Username { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [StringLength(10, MinimumLength = 8, ErrorMessage = "Password must be 8-10 characters")]
    [CustomValidation(typeof(Worker), nameof(validatePassword), ErrorMessage = "Password must contain at least one letter, one number, and one special character (!,#,$)")]
    public required string Password { get; set; }

    [Required(ErrorMessage = "Worker Id is required")]
    [RegularExpression(@"^\d{4}$", ErrorMessage = "Code must be exactly 4 digits.")]
    public required string WorkerId { get; set; }

    [Required]
    [AllowedValues("VET", "SECRETARY", ErrorMessage = $"Invalid role, allowed role (VET, SECRETARY)")]
    public required string Role { get; set; }

    public static ValidationResult validateUsername(string username) {
        List<Func<string, bool>> constraints = [
                u => u.Count(char.IsDigit) <= 2,
                u => u.All(char.IsLetterOrDigit),
            ];

        return constraints.All(f => f(username))
            ? ValidationResult.Success!
            : new ValidationResult("Username must be only letters and include at most 2 digits")!;
    }

    public static ValidationResult validatePassword(string password) {
        List<Func<string, bool>> constraints = [
                u => u.Any(char.IsLetter),
                u => u.Any(char.IsDigit),
                u => u.Any("$#!".Contains),
            ];

        return constraints.All(f => f(password)) 
            ? ValidationResult.Success!
            : new ValidationResult("Username must be English characters with at most 2 digits.")!;
    }
}
