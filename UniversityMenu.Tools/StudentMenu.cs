using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace UniversityMenu.Tools
{
    public class StudentMenu
    {
        public List<string> Items { get; set; }=new List<string>();
        public StudentMenu()
        {
            Items.Add("1-Add student");
            Items.Add("2-Edit student");
            Items.Add("3-Delete student");
            Items.Add("4-Students list");
            Items.Add("5-Sort by average");
            Items.Add("0-Exit");
        }
        public int Show()
        {
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.WriteLine("    ****************     ");
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            Console.WriteLine("      Student Menu");
            Console.ForegroundColor=ConsoleColor.DarkBlue;
            Items.ForEach(s=>Console.WriteLine(s));
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.WriteLine("    ****************     ");
            Console.ResetColor();
            Console.Write("Your choice: ");
            return int.Parse(Console.ReadLine()??"0");
        }
    }
}