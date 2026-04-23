namespace ClinicVet.App.Data.Exceptions;

public class NotFoundException(string entityName, string id)
    : Exception($"could not find entity {entityName} with id {id}.");
    