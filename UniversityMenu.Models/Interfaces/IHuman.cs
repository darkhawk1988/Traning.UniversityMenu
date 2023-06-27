using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMenu.Models.Interfaces
{
    public interface IHuman : IBaseEntity       
    {

        string? Firstname { get; set; }
        string? Lastname { get; set; }
        string? Gender { get; set; }
        DateTime BirthDate { get; set; }

    }
}