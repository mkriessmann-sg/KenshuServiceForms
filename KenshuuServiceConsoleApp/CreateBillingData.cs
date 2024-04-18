using KenshuServiceDatabaseLibrary;
using System.Runtime.InteropServices;
using CommandLine;

namespace KenshuuServiceConsoleApp
{
    class Options
    {
        [Option('d', "date", Required = true, HelpText = "Date in the format YYYYMM.")]
        public string Date { get; set; }

        [Option('h', "help", HelpText = "Display this help message.")]
        public bool Help { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(options =>
                {
                    if (options.Help)
                    {
                        Console.WriteLine("Usage: MyApp.exe [options]");
                        Console.WriteLine("Options:");
                        Console.WriteLine("  -d, --date <YYYYMM>   Date in the format YYYYMM.");
                        Console.WriteLine("  -h, --help            Display this help message.");
                    }
                    else
                    {
                        if (IsValidDate(options.Date))
                        {
                            Console.WriteLine($"Date provided: {options.Date}");
                            // Add your application logic here
                        }
                        else
                        {
                            Console.WriteLine("Error: Invalid date format. Please provide a date in the format YYYYMM.");
                        }
                    }
                });
        }

        static bool IsValidDate(string date)
        {
            if (date.Length != 6)
                return false;

            if (!int.TryParse(date, out _))
                return false;

            return true;
        }
    }
}

