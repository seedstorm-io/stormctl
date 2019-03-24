using System;
using Figgle;
using McMaster.Extensions.CommandLineUtils;

namespace stormctl
{
    internal class StormCtl
    {
        private readonly string[] arguments;
        private readonly CommandLineApplication ctl;

        public StormCtl(string[] args)
        {
            this.arguments = args;
            this.ctl = new CommandLineApplication()
            {
                Name = "stormctl",
            };
        }

        public StormCtl Banner()
        {
            Console.Write(FiggleFonts.Standard.Render("SeedStorm.io"));
            Console.WriteLine("stormctl is the command line tool to manage your seedstorm.io account." + Environment.NewLine);

            return this;
        }

        public int Execute()
        {
            this.ctl.ShowHelp();
            return 0;
        }
    }
}