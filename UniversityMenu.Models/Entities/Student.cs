using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMenu.Models.Interfaces;

namespace UniversityMenu.Models.Interfaces
{
    public sealed class Student : IStudent
    {
        public Student()
        {
            BirthDate=DateTime.Now;
        }  
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string? NationalCode { get; set; }
        public string? Field { get; set; }
        public double Average { get; set; }
        public void Read()
        {
            Console.Write("Firstname: ");
            Firstname=Console.ReadLine();
            Console.Write("Lastname: ");
            Lastname=Console.ReadLine();
            Console.Write("Gender: ");
            Gender=Console.ReadLine();
            Console.Write("NatioanlCode: ");
            NationalCode=Console.ReadLine();
            Console.Write("Field: ");
            Field=Console.ReadLine();
            Console.Write("Average: ");
            Average=double.Parse(Console.ReadLine()??"0");
        }
        public override string ToString()
        {
            return $"{Id} {Firstname} {Lastname} {Gender} {BirthDate} {NationalCode} {Field} {Average}";
        }
    }
}