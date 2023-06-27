using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMenu.Models.Interfaces
{
    public interface IStudent : IIranian
    {
        string? Field { get; set; }
        double Average { get; set; }
        void Read();
    }
}