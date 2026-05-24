using ClinicVet.Data.Models;
using Microsoft.Data.Sqlite;

namespace ClinicVet.Data.Repositories;
public class AnimalsRepository
{
    public List<Animal> GetAll() {
        return GetAll(null);
    }
    public List<Animal> GetAll(string? ownerId)
    {
        var animals = new List<Animal>();
        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT _Id, Name, AnimalType, Weight, Birthdate, LastVaccine, ChipSerial, OwnerId FROM Animals";

        if (!string.IsNullOrEmpty(ownerId)) { 
            command.CommandText += " WHERE OwnerId = $ownerId";
            command.Parameters.AddWithValue("$ownerId", ownerId);
        }

        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            animals.Add(new Animal
            {
                _Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                AnimalType = reader.GetString(2),
                Weight = reader.GetDouble(3),
                Birthdate = DateOnly.FromDateTime(reader.GetDateTime(4)),
                LastVaccine = reader.IsDBNull(5) ? default : DateOnly.FromDateTime(reader.GetDateTime(5)),
                ChipSerial = reader.GetString(6),
                OwnerId = reader.GetInt32(7)
            });
        }
        return animals;
    }

    public Animal GetByChipSerial(int serial)
    {
        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT _Id, Name, AnimalType, Weight, Birthdate, LastVaccine, ChipSerial, OwnerId FROM Animals WHERE ChipSerial = $serial";
        command.Parameters.AddWithValue("$serial", serial);

        using var reader = command.ExecuteReader();

        if (!reader.Read())
        {
            throw new Exception($"couldn't find animal with chip serial '{serial}'");
        }

        return new Animal
        {
            _Id = reader.GetInt32(0),
            Name = reader.GetString(1),
            AnimalType = reader.GetString(2),
            Weight = reader.GetDouble(3),
            Birthdate = DateOnly.FromDateTime(reader.GetDateTime(4)),
            LastVaccine = reader.IsDBNull(5) ? default : DateOnly.FromDateTime(reader.GetDateTime(5)),
            ChipSerial = reader.GetString(6),
            OwnerId = reader.GetInt32(7)
        };
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
        return new Animal
        {
            _Id = reader.GetInt32(0),
            Name = reader.GetString(1),
            AnimalType = reader.GetString(2),
            Weight = reader.GetDouble(3),
            Birthdate = DateOnly.FromDateTime(reader.GetDateTime(4)),
            LastVaccine = reader.IsDBNull(5) ? default : DateOnly.FromDateTime(reader.GetDateTime(5)),
            ChipSerial = reader.GetString(6),
            OwnerId = reader.GetInt32(7)
        };
    }

    public void Add(Animal animal)
    {
        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();
        var command = connection.CreateCommand();
        command.CommandText = @"INSERT INTO Animals (Name, AnimalType, Weight, Birthdate, LastVaccine, ChipSerial, OwnerId) 
                                VALUES ($name, $animalType, $weight, $birthdate, $lastVaccine, $chipSerial, $ownerId)";
        command.Parameters.AddWithValue("$name", animal.Name);
        command.Parameters.AddWithValue("$animalType", animal.AnimalType);
        command.Parameters.AddWithValue("$weight", animal.Weight);
        command.Parameters.AddWithValue("$birthdate", animal.Birthdate.ToDateTime(TimeOnly.MinValue));
        command.Parameters.AddWithValue("$lastVaccine", animal.LastVaccine.ToDateTime(TimeOnly.MinValue));
        command.Parameters.AddWithValue("$chipSerial", animal.ChipSerial);
        command.Parameters.AddWithValue("$ownerId", animal.OwnerId);
        command.ExecuteNonQuery();
    }

    public void Delete(int serial)
    {
        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "DELETE FROM Animals WHERE ChipSerial = $serial";
        command.Parameters.AddWithValue("$serial", serial);
        command.ExecuteNonQuery();
    }
}
