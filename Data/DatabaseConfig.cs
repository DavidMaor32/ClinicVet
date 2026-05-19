using Microsoft.Data.Sqlite;

namespace ClinicVet.Data;

public static class DatabaseConfig
{
    private static readonly string DbPath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "clinicvet.db"
        );
    public static string ConnectionString => $"Data Source={DbPath}";

    public static void Initialize()
    {
        using var connection = new SqliteConnection(ConnectionString);
        connection.Open();

        var tableQueries = new List<string>
        {
            @"CREATE TABLE IF NOT EXISTS Workers (
                _Id         INTEGER PRIMARY KEY AUTOINCREMENT,
                Email       TEXT NOT NULL,
                Id          TEXT NOT NULL UNIQUE,
                Username    TEXT NOT NULL UNIQUE,
                Password    TEXT NOT NULL,
                WorkerId    TEXT NOT NULL UNIQUE,
                Role        TEXT NOT NULL
            );",
            @"INSERT OR IGNORE INTO Workers (Email, Id, Username, Password, WorkerId, Role) 
                VALUES ('admin@clinicvet.com', '123456789', 'admin12', 'admin123!', '0000', 'VET');",
            @"CREATE TABLE IF NOT EXISTS Clients (
                _Id         INTEGER PRIMARY KEY AUTOINCREMENT,
                Id          TEXT NOT NULL,
                FullName    TEXT NOT NULL,
                Phone       TEXT,
                Email       TEXT
            );",
            @"CREATE TABLE IF NOT EXISTS Animals (
                _Id         INTEGER PRIMARY KEY AUTOINCREMENT,
                Name        TEXT NOT NULL,
                AnimalType  TEXT NOT NULL,
                Weight      TEXT,
                OwnerId     INTEGER,
                FOREIGN KEY (OwnerId) REFERENCES Clients(_Id) ON DELETE CASCADE
            );",

        };

        foreach (var query in tableQueries)
        {
            using var tableCommand = connection.CreateCommand();
            tableCommand.CommandText = query;
            tableCommand.ExecuteNonQuery();
        }
    }
}
