using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicVet.Data.Models;

public class AnimalType : Document
{
    public required string Name { get; set; }
}
