namespace ClinicVet.Data.Enums;

public class Role {
    public static readonly Role Vet = new Role("VET", "vet");
    public static readonly Role Secretary = new Role("SECRETARY", "secretary");
    public static readonly IReadOnlyList<Role> All = [Vet, Secretary];

    public string Value { get; }
    public string DisplayName { get; }

    private Role(string value, string displayName) {
        Value = value;
        DisplayName = displayName;
    }

    public override string ToString() => Value;
}
