using ClinicVet.Data.Models;
using Microsoft.Data.Sqlite;

namespace ClinicVet.Data.Repositories;

public class ClientsRepository {
    public List<Client> GetAll() { 
        return GetAll(null);
    }

    public List<Client> GetAll(string? searchTerm)
    {
        var clients = new List<Client>();
        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();
        var command = connection.CreateCommand();
        command.CommandText = "SELECT _Id, Id, FullName, Phone, Email FROM Clients";

        if (!string.IsNullOrEmpty(searchTerm)) { 
            command.CommandText += " WHERE Id LIKE $searchTerm OR Phone LIKE $searchTerm";
        }
        
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            clients.Add(new Client
            {
                _Id = reader.GetInt32(0),
                Id = reader.GetString(1),
                FullName = reader.GetString(2),
                Phone = reader.GetString(3),
                Email = reader.GetString(4)
            });
        }
        return clients;
    }

    public Client GetById(string id) {
        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();
        var command = connection.CreateCommand();
        command.CommandText = "SELECT _Id, Id, FullName, Phone, Email FROM Clients WHERE Id = $id";
        command.Parameters.AddWithValue("$id", id);

        using var reader = command.ExecuteReader();

        if (!reader.Read()) {
            throw new Exception($"couldn't find User with id '{id}'");
        }

        return new Client
        {
            _Id = reader.GetInt32(0),
            Id = reader.GetString(1),
            FullName = reader.GetString(2),
            Phone = reader.GetString(3),
            Email = reader.GetString(4)
        };
    }

    public void Add(Client client)
    {
        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();
        var command = connection.CreateCommand();
        command.CommandText = @"INSERT INTO Clients (Id, FullName, Phone, Email) 
                                VALUES ($id, $fullName, $phone, $email)";
        command.Parameters.AddWithValue("$id", client.Id);
        command.Parameters.AddWithValue("$fullName", client.FullName);
        command.Parameters.AddWithValue("$phone", client.Phone);
        command.Parameters.AddWithValue("$email", client.Email);
        command.ExecuteNonQuery();
    }

    public void Delete(string id)
    {
        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();
        var command = connection.CreateCommand();
        command.CommandText = "DELETE FROM Clients WHERE Id = $id";
        command.Parameters.AddWithValue("$id", id);
        command.ExecuteNonQuery();
    }
}
