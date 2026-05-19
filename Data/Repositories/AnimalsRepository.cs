using ClinicVet.Data.Models;
using Microsoft.Data.Sqlite;

namespace ClinicVet.Data.Repositories;
public class AnimalsRepository
{
    public List<Animal> GetAll()
    {
        var animals = new List<Animal>();
        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT _Id, Name, AnimalType, Weight, Birthdate, LastVaccine, ChipSerial, OwnerId FROM Animals";

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
                LastVaccine = DateOnly.FromDateTime(reader.GetDateTime(5)),
                ChipSerial = reader.GetString(6),
                OwnerId = reader.GetInt32(7)
            });
        }
        return animals;
    }

    
}
