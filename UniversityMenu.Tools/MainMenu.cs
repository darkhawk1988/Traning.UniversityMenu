using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMenu.Tools
{
    public class MainMenu
    {
        public List<string> Items { get; set; } = new List<string>();
        public MainMenu()
        {
            Items.Add("1-Student Menu");
            Items.Add("2-Professor Menu");
            Items.Add("0-Exit");
        }
        public int Show()
        {
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.WriteLine("    ****************     ");
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            Console.WriteLine("  Wellcome to MainMenu");
            Console.ForegroundColor=ConsoleColor.DarkBlue;
            Items.ForEach(m=>Console.WriteLine(m));
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.WriteLine("    ****************     ");
            Console.ResetColor();
            Console.Write("Your choice: ");
            return int.Parse(Console.ReadLine()??"0");
        }
    }
}