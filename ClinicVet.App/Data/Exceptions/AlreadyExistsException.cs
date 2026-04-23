namespace ClinicVet.App.Data.Exceptions;

public class AlreadyExistsException(string entityName, string id)
    : Exception($"{entityName} with id {id} already exists.");
