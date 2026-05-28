using ClinicVet.Data.Models;
using Microsoft.Data.Sqlite;

namespace ClinicVet.Data.Repositories;

public class AnimalTypesRepository
{
    public List<AnimalType> GetAll()
    {
        var animalTypes = new List<AnimalType>();

        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText =
            "SELECT _Id, Name FROM AnimalTypes ORDER BY Name";

        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            animalTypes.Add(new AnimalType
            {
                _Id = reader.GetInt32(0),
                Name = reader.GetString(1)
            });
        }

        return animalTypes;
    }


    private bool Exists(string name)
    {
        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = @"
        SELECT COUNT(*)
        FROM AnimalTypes
        WHERE LOWER(Name) = LOWER($name)";

        command.Parameters.AddWithValue("$name", name);

        long count = (long)command.ExecuteScalar();

        return count > 0;
    }



    public void Add(string name)
    {

        name = name.Trim();
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Animal type name cannot be empty.");
        }

        if (Exists(name))
        {
            throw new Exception("Animal type with the same name already exists.");
        }

        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = @"
        INSERT INTO AnimalTypes (Name)
        VALUES ($name)";

        command.Parameters.AddWithValue("$name", name);

        command.ExecuteNonQuery();
    }

    public void Delete(string name)
    {
        name = name.Trim();
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Animal type name cannot be empty.");
        }

        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = @"
        DELETE FROM AnimalTypes
        WHERE LOWER(Name) = LOWER($name)";

        command.Parameters.AddWithValue("$name", name);

        int rowsAffected = command.ExecuteNonQuery();

        if (rowsAffected == 0)
        {
            throw new Exception("Animal type not found.");
        }
    }

}