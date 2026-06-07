using Microsoft.Data.Sqlite;

namespace ClinicVet.Data;

public static class DatabaseConfig
{
    private static string? _connectionString = null;

    private static readonly string DbPath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "clinicvet.db"
        );

    public static string ConnectionString =>_connectionString ?? $"Data Source={DbPath}";

    public static void UseConnectionString(string connection) {
        _connectionString = connection;
    }

    public static void ResetConnectionString() {
        _connectionString = null;
    }

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
            @"INSERT OR IGNORE INTO Workers (Email, Id, Username, Password, WorkerId, Role) 
                VALUES ('admin@clinicvet.com', '987654321', 'adminSec', 'sec1234!', '0001', 'SECRETARY');",
            @"CREATE TABLE IF NOT EXISTS Clients (
                _Id         INTEGER PRIMARY KEY AUTOINCREMENT,
                Id          TEXT NOT NULL UNIQUE,
                FullName    TEXT NOT NULL,
                Phone       TEXT,
                Email       TEXT
            );",
            @"INSERT OR IGNORE INTO Clients (Id, FullName, Phone, Email)
                VALUES ('111222333', 'David Cohen', '0501234567', 'david@email.com');",
            @"CREATE TABLE IF NOT EXISTS Animals (
                _Id         INTEGER PRIMARY KEY AUTOINCREMENT,
                Name        TEXT NOT NULL,
                AnimalType  TEXT NOT NULL,
                ChipSerial  TEXT NOT NULL UNIQUE,
                Weight      REAL NOT NULL,
                OwnerId     INTEGER NOT NULL,
                Birthdate TEXT NOT NULL,
                LastVaccine TEXT DEFAULT NULL,
                FOREIGN KEY (OwnerId) REFERENCES Clients(_Id) ON DELETE CASCADE
            );",
            @"INSERT OR IGNORE INTO Animals (Name, AnimalType, ChipSerial, Weight, OwnerId, Birthdate, LastVaccine)
                VALUES ('Lucky', 'Dog', 'CHIP1001', 12.5, (SELECT _Id FROM Clients WHERE Id = '111222333'), '2021-05-10', '2023-01-01');",
            @"INSERT OR IGNORE INTO Animals (Name, AnimalType, ChipSerial, Weight, OwnerId, Birthdate, LastVaccine)
                VALUES ('Mika', 'Cat', 'CHIP1002', 4.2, (SELECT _Id FROM Clients WHERE Id = '111222333'), '2022-03-15', '2026-02-01');",
            @"CREATE TABLE IF NOT EXISTS AnimalTypes (
                _Id         INTEGER PRIMARY KEY AUTOINCREMENT,
                Name        TEXT NOT NULL UNIQUE COLLATE NOCASE
            );",
            @"CREATE TABLE IF NOT EXISTS Medicine (
                _Id         INTEGER PRIMARY KEY AUTOINCREMENT,
                Name        TEXT NOT NULL UNIQUE,
                Quantity    INTEGER DEFAULT 0 CHECK(Quantity >= 0),
                Price       REAL NOT NULL
            );",
            @"INSERT OR IGNORE INTO Medicine (Name, Quantity, Price)
                VALUES ('Moxypen', 10, 50);",
            @"INSERT OR IGNORE INTO Medicine (Name, Quantity, Price)
                VALUES ('Augmentin', 5, 80);",
            @"CREATE TABLE IF NOT EXISTS Visits (
                _Id         INTEGER PRIMARY KEY AUTOINCREMENT,
                AnimalId INTEGER NOT NULL,
                Reason      TEXT NOT NULL,
                DateTime    TEXT NOT NULL,
                Diagnosis   TEXT NOT NULL,
                VetWorkerId TEXT NOT NULL,
                Prescriptions TEXT NOT NULL CHECK(json_valid(Prescriptions)),
                FOREIGN KEY (VetWorkerId) REFERENCES Workers(WorkerId) ON DELETE CASCADE
            );",
        };

        foreach (var query in tableQueries)
        {
            using var tableCommand = connection.CreateCommand();
            tableCommand.CommandText = query;
            tableCommand.ExecuteNonQuery();
        }

        using var countCommand = connection.CreateCommand();
        countCommand.CommandText = "SELECT COUNT(*) FROM AnimalTypes";

        long animalTypesCount = (long)countCommand.ExecuteScalar();

        if (animalTypesCount == 0)
        {
            string[] defaultTypes = { "Dog", "Cat", "Bird", "Reptile" };

            foreach (string typeName in defaultTypes)
            {
                using var insertCommand = connection.CreateCommand();
                insertCommand.CommandText = "INSERT INTO AnimalTypes (Name) VALUES ($name)";
                insertCommand.Parameters.AddWithValue("$name", typeName);
                insertCommand.ExecuteNonQuery();
            }
        }
    }
}
