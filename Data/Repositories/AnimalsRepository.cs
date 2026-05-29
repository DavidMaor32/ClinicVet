using ClinicVet.Data.Models;
using Microsoft.Data.Sqlite;
using System.Text;

namespace ClinicVet.Data.Repositories;

public class AnimalsRepository
{
    public List<Animal> GetAll()
    {
        return GetAll(null);
    }

    public List<Animal> GetAll(string? ownerId)
    {
        var animals = new List<Animal>();
        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT _Id, Name, AnimalType, Weight, Birthdate, LastVaccine, ChipSerial, OwnerId FROM Animals";

        if (!string.IsNullOrEmpty(ownerId))
        {
            command.CommandText += " WHERE OwnerId = $ownerId";
            command.Parameters.AddWithValue("$ownerId", ownerId);
        }

        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            animals.Add(ReadAnimal(reader));
        }

        return animals;
    }

    public Animal GetByChipSerial(string chipSerial)
    {
        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT _Id, Name, AnimalType, Weight, Birthdate, LastVaccine, ChipSerial, OwnerId FROM Animals WHERE ChipSerial = $serial";
        command.Parameters.AddWithValue("$serial", chipSerial);

        using var reader = command.ExecuteReader();

        if (!reader.Read())
        {
            throw new Exception($"couldn't find animal with chip serial '{chipSerial}'");
        }

        return ReadAnimal(reader);
    }

    public List<Animal> GetByOwnerId(string ownerId)
    {
        return GetAll().Where(a => a.OwnerId.Equals(ownerId)).ToList();
    }

    public Animal GetById(int id)
    {
        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT _Id, Name, AnimalType, Weight, Birthdate, LastVaccine, ChipSerial, OwnerId FROM Animals WHERE _Id = $id";
        command.Parameters.AddWithValue("$id", id);

        using var reader = command.ExecuteReader();

        if (!reader.Read())
        {
            throw new Exception($"couldn't find animal with id '{id}'");
        }

        return ReadAnimal(reader);
    }

    public List<Animal> GetByName(string name)
    {
        var animals = new List<Animal>();

        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = @"
            SELECT _Id, Name, AnimalType, Weight, Birthdate, LastVaccine, ChipSerial, OwnerId
            FROM Animals
            WHERE Name LIKE $name";
        command.Parameters.AddWithValue("$name", $"%{name}%");

        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            animals.Add(ReadAnimal(reader));
        }

        return animals;
    }

    public void Add(Animal animal)
    {
        ClientsRepository clients = new ClientsRepository();

        bool isOwnerIdExists = clients.GetAll().Any(c => c._Id == animal.OwnerId);

        if (!isOwnerIdExists)
        {
            throw new Exception($"Could not find client with id '{animal.OwnerId}'");
        }

        animal.ChipSerial = GenerateUniqueChipSerial();

        if (ChipSerialExists(animal.ChipSerial))
        {
            throw new Exception($"Already exists animal with chip serial '{animal.ChipSerial}'");
        }

        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = @"INSERT INTO Animals (Name, AnimalType, Weight, Birthdate, LastVaccine, ChipSerial, OwnerId) 
                                VALUES ($name, $animalType, $weight, $birthdate, $lastVaccine, $chipSerial, $ownerId)";
        command.Parameters.AddWithValue("$name", animal.Name);
        command.Parameters.AddWithValue("$animalType", animal.AnimalType);
        command.Parameters.AddWithValue("$weight", animal.Weight);
        command.Parameters.AddWithValue("$birthdate", animal.Birthdate.ToDateTime(TimeOnly.MinValue));
        command.Parameters.AddWithValue(
            "$lastVaccine",
            animal.LastVaccine.HasValue
                ? animal.LastVaccine.Value.ToDateTime(TimeOnly.MinValue)
                : DBNull.Value
        );
        command.Parameters.AddWithValue("$chipSerial", animal.ChipSerial);
        command.Parameters.AddWithValue("$ownerId", animal.OwnerId);
        command.ExecuteNonQuery();
    }

    public void Delete(int _id)
    {
        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "DELETE FROM Animals WHERE _id = $_id";
        command.Parameters.AddWithValue("$_id", _id);
        command.ExecuteNonQuery();
    }

    private static Animal ReadAnimal(SqliteDataReader reader)
    {
        return new Animal
        {
            _Id = reader.GetInt32(0),
            Name = reader.GetString(1),
            AnimalType = reader.GetString(2),
            Weight = reader.GetDouble(3),
            Birthdate = DateOnly.FromDateTime(reader.GetDateTime(4)),
            LastVaccine = reader.IsDBNull(5) ? null : DateOnly.FromDateTime(reader.GetDateTime(5)),
            ChipSerial = reader.GetString(6),
            OwnerId = reader.GetInt32(7)
        };
    }

    private bool ChipSerialExists(string chipSerial)
    {
        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = @"
            SELECT COUNT(*)
            FROM Animals
            WHERE ChipSerial = $chipSerial";
        command.Parameters.AddWithValue("$chipSerial", chipSerial);

        long count = (long)command.ExecuteScalar();

        return count > 0;
    }

    private string GenerateChipSerial()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < 9; i++)
        {
            sb.Append(Random.Shared.Next(0, 10));
        }

        return sb.ToString();
    }

    private string GenerateUniqueChipSerial()
    {
        int attempts = 0;

        while (attempts < 10)
        {
            string chip = GenerateChipSerial();

            if (!ChipSerialExists(chip))
            {
                return chip;
            }

            attempts++;
        }

        throw new Exception("Could not generate unique chip serial.");
    }
}
