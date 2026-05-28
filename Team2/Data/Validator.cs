using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClinicVet.Data;

public static class ModelValidator
{
    public static bool TryValidate(object model, out List<string> errorMessages)
    {
        errorMessages = [];

        var context = new ValidationContext(model);
        var results = new List<ValidationResult>();

        bool isValid = Validator.TryValidateObject(model, context, results, validateAllProperties: true);

        if (!isValid)
        {
            foreach (var validationResult in results)
            {
                errorMessages.Add(validationResult.ErrorMessage);
            }
        }

        return isValid;
    }
}