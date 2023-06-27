using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMenu.Tools
{
    public class ProfessorMenu
    {
        public List<string> Items { get; set; }=new List<string>();
        public ProfessorMenu()
        {
            Items.Add("1-Add professor");
            Items.Add("2-Edit professor");
            Items.Add("3-Delete professor");
            Items.Add("4-Professors list");
            Items.Add("5-Sort by field");
            Items.Add("0-Exit");
        }
        public int Show()
        {
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.WriteLine("    ****************     ");
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            Console.WriteLine("     Professor Menu");
            Console.ForegroundColor=ConsoleColor.DarkBlue;
            Items.ForEach(p=>Console.WriteLine(p));
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.WriteLine("    ****************     ");
            Console.ResetColor();
            Console.Write("Your choice: ");
            return int.Parse(Console.ReadLine()??"0");
        }
    }
}