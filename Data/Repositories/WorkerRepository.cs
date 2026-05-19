using Microsoft.Data.Sqlite;
using ClinicVet.Data.Models;

using System.CodeDom;

namespace ClinicVet.Data.Repositories;

public class WorkerRepository {
    public List<Worker> GetAll() {
        var workers = new List<Worker>();
        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = @"SELECT _Id, Email, Id, Username, Password, WorkerId, Role 
                                FROM Workers";

        using var reader = command.ExecuteReader();

        while (reader.Read()) {
            workers.Add(new Worker {
                _Id = reader.GetInt32(0),
                Email = reader.GetString(1),
                Id = reader.GetString(2),
                Username = reader.GetString(3),
                Password = reader.GetString(4),
                WorkerId = reader.GetString(5),
                Role = reader.GetString(6),
            });
        }

        return workers;
    }

    public void Add(Worker worker)
    {
        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = @"INSERT INTO Workers (Email, Id, Username, Password, WorkerId, Role) 
                                VALUES ($email, $id, $username, $password, $workerId, $role)";
        command.Parameters.AddWithValue("$email", worker.Email);
        command.Parameters.AddWithValue("$id", worker.Id);
        command.Parameters.AddWithValue("$username", worker.Username);
        command.Parameters.AddWithValue("$password", worker.Password);
        command.Parameters.AddWithValue("$workerId", worker.WorkerId);
        command.Parameters.AddWithValue("$role", worker.Role);

        command.ExecuteNonQuery();
    }

    public Worker Login(string username, string password)
    {
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)){
            throw new Exception("username and password cannot be not empty.");
        }

        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = @"
        SELECT _Id, Email, Id, Username, Password, WorkerId, Role 
        FROM Workers 
        WHERE Username = $username
        LIMIT 1;";

        command.Parameters.AddWithValue("$username", username);

        using var reader = command.ExecuteReader();

        if (!reader.Read() || reader.GetString(4) != password) {
            throw new Exception($"username or password are incorrect");
        }

        return new Worker {
            _Id = reader.GetInt32(0),
            Email = reader.GetString(1),
            Id = reader.GetString(2),
            Username = reader.GetString(3),
            Password = reader.GetString(4),
            WorkerId = reader.GetString(5),
            Role = reader.GetString(6),
        };
    }
}
