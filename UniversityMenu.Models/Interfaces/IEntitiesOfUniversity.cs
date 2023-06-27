using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMenu.Models.Interfaces
{
    public interface IEntitiesOfUniversity : IIranian
    {
        string? Field { get; set; }
    }
}