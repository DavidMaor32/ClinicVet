using ClinicVet.Data.Models;
using Microsoft.Data.Sqlite;

namespace ClinicVet.Data.Repositories;

public class MedicineRepository {
    public List<Medicine> GetAll() {
        var medicines = new List<Medicine>();

        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = @"
            SELECT _Id, Name, Quantity, Price
            FROM Medicine
            ORDER BY _Id DESC;";

        using var reader = command.ExecuteReader();
        while (reader.Read()) {
            medicines.Add(new Medicine {
                _Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Quantity = reader.GetInt32(2),
                Price = reader.GetDouble(3)
            });
        }

        return medicines;
    }

    public Medicine GetByName(string name) {
        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = @"
            SELECT _Id, Name, Quantity, Price
            FROM Medicine
            WHERE Name = $name
            LIMIT 1;";
        command.Parameters.AddWithValue("$name", name);

        using var reader = command.ExecuteReader();
        if (!reader.Read()) {
            throw new Exception($"couldn't find medicine with name '{name}'");
        }

        return new Medicine {
            _Id = reader.GetInt32(0),
            Name = reader.GetString(1),
            Quantity = reader.GetInt32(2),
            Price = reader.GetDouble(3)
        };
    }

    public void Add(Medicine medicine) {
        if (IsNameExists(medicine.Name)) { 
            throw new Exception($"medicine with name '{medicine.Name}' already exists.");
        }

        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = @"
            INSERT INTO Medicine (Name, Quantity, Price)
            VALUES ($name, $quantity, $price);";

        command.Parameters.AddWithValue("$name", medicine.Name);
        command.Parameters.AddWithValue("$quantity", medicine.Quantity);
        command.Parameters.AddWithValue("$price", medicine.Price);

        command.ExecuteNonQuery();
    }

    public void AddStock(string medicineName, int quantity) {
        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();
        using var command = connection.CreateCommand();
        command.CommandText = @"
            UPDATE Medicine
            SET Quantity = Quantity + $quantity
            WHERE Name = $name;";
        command.Parameters.AddWithValue("$quantity", quantity);
        command.Parameters.AddWithValue("$name", medicineName);
        int rowsAffected = command.ExecuteNonQuery();
        if (rowsAffected == 0) {
            throw new Exception($"couldn't find medicine with name '{medicineName}'");
        }
    }

    public PrescribedMedicine Prescribe(Medicine medicine, int quantity) {
        if (medicine is null) {
            throw new ArgumentNullException(nameof(medicine));
        }

        return Prescribe(medicine.Name, quantity);
    }

    public PrescribedMedicine Prescribe(string medicineName, int quantity) {
        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        using var transaction = connection.BeginTransaction();

        try {
            var prescribedMedicine = Prescribe(medicineName, quantity, connection, transaction);
            transaction.Commit();
            return prescribedMedicine;
        }
        catch {
            transaction.Rollback();
            throw;
        }
    }

    public PrescribedMedicine Prescribe(string medicineName, int quantity, SqliteConnection connection, SqliteTransaction transaction) {
        if (quantity <= 0) {
            throw new Exception("quantity must be greater than zero.");
        }

        using var selectCommand = connection.CreateCommand();
        selectCommand.Transaction = transaction;
        selectCommand.CommandText = @"
            SELECT Quantity
            FROM Medicine
            WHERE Name = $name
            LIMIT 1;";
        selectCommand.Parameters.AddWithValue("$name", medicineName);

        int currentQuantity;
        using (var reader = selectCommand.ExecuteReader()) {
            if (!reader.Read()) {
                throw new Exception($"couldn't find medicine with name '{medicineName}'");
            }

            currentQuantity = reader.GetInt32(0);
        }

        if (currentQuantity < quantity) {
            throw new Exception($"medicine '{medicineName}' does not have enough stock");
        }

        using var updateCommand = connection.CreateCommand();
        updateCommand.Transaction = transaction;
        updateCommand.CommandText = @"
            UPDATE Medicine
            SET Quantity = Quantity - $quantity
            WHERE Name = $name;";
        updateCommand.Parameters.AddWithValue("$quantity", quantity);
        updateCommand.Parameters.AddWithValue("$name", medicineName);
        updateCommand.ExecuteNonQuery();

        return new PrescribedMedicine {
            MedicineName = medicineName,
            Quantity = quantity
        };
    }

    private bool IsNameExists(string name) {
        return GetAll().Any(m => m.Name.Equals(name));
    }
}
