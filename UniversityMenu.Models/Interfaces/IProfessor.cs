using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMenu.Models.Interfaces
{
    public interface IProfessor : IIranian
    {
        string? Field { get; set; }
        string? Level { get; set; }
        void Read();
    }
}