using System.Text.Json;

using team3.Data.Models;

using Microsoft.Data.Sqlite;

namespace team3.Data.Repositories;

public class VisitsRepository {
    public void Add(Visit visit) {
        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        using var transaction = connection.BeginTransaction();

        try {
            var medicineRepository = new MedicineRepository();
            var prescribedMedicines = new List<PrescribedMedicine>();

            foreach (var medicine in visit.PrescribedMedicines)
            {
                prescribedMedicines.Add(
                    medicineRepository.Prescribe(
                        medicine.MedicineName,
                        medicine.Quantity,
                        connection,
                        transaction
                    )
                );
            }

            visit.PrescribedMedicines = prescribedMedicines;

            using var visitCmd = connection.CreateCommand();
            visitCmd.Transaction = transaction;
            visitCmd.CommandText = @"
                INSERT INTO Visits (AnimalID, Reason, DateTime, Diagnosis, VetWorkerId, Prescriptions)
                VALUES ($animalId, $reason, $dateTime, $diagnosis, $vetWorkerId, $prescriptions);

                SELECT last_insert_rowid();";


            visitCmd.Parameters.AddWithValue("$animalId", visit.AnimalId);
            visitCmd.Parameters.AddWithValue("$reason", visit.Reason);
            visitCmd.Parameters.AddWithValue("$dateTime", visit.DateTime.ToString("yyyy-MM-dd HH:mm:ss"));
            visitCmd.Parameters.AddWithValue("$diagnosis", visit.Diagnosis);
            visitCmd.Parameters.AddWithValue("$vetWorkerId", visit.VetWorkerId);
            visitCmd.Parameters.AddWithValue("$prescriptions", visit.PrescribedMedicinesJson);

            long newVisitId = (long)visitCmd.ExecuteScalar()!;
            visit._Id = Convert.ToInt32(newVisitId);

            transaction.Commit();
        }
        catch (Exception) {
            transaction.Rollback();
            throw;
        }
    }

    public List<Visit> GetAll() {
        var visits = new List<Visit>();

        using var connection = new SqliteConnection(DatabaseConfig.ConnectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = @"
            SELECT _Id, AnimalId, Reason, DateTime, Diagnosis, VetWorkerId, Prescriptions
            FROM Visits
            ORDER BY _Id DESC;";

        using var reader = command.ExecuteReader();
        while (reader.Read()) {
            var prescriptionsJson = reader.IsDBNull(5) ? "[]" : reader.GetString(5);

            visits.Add(new Visit {
                _Id = reader.GetInt32(0),
                AnimalId = reader.GetInt32(1),
                Reason = reader.GetString(1),
                DateTime = DateTime.Parse(reader.GetString(2)),
                Diagnosis = reader.GetString(3),
                VetWorkerId = reader.GetString(4),
                PrescribedMedicines = JsonSerializer.Deserialize<List<PrescribedMedicine>>(prescriptionsJson) ?? new List<PrescribedMedicine>()
            });
        }

        return visits;
    }
}
