using Figgle;
using System;

namespace stormctl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(FiggleFonts.Standard.Render("SeedStorm.io"));
            Console.WriteLine(" stormctl is the command line tool to manage your seedstorm.io account.");
        }
    }
}
