using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMenu.Models.Interfaces
{
    public interface IIranian : IHuman
    {
        string? NationalCode { get; set; }
    }
}