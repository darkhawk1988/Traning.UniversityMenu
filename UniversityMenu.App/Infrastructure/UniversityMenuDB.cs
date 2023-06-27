using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniversityMenu.Models.Entities;
using UniversityMenu.Models.Interfaces;

namespace UniversityMenu.App.Infrastructure
{
    public class UniversityMenuDB : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=university.db");
        }
    }
}