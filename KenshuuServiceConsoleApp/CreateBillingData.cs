using KenshuServiceDatabaseLibrary;
using System.Runtime.InteropServices;
using CommandLine;
using System.Runtime.CompilerServices;
using Npgsql.Replication.PgOutput.Messages;

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
        static KenshuDBHandler handler = new KenshuDBHandler();
        static DateOnly date;
        static DateOnly dateEnd;


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
                            //Main programme
                            //TODO:fix this madness
                            string temp = options.Date + "01";
                            date = DateOnly.Parse(temp);
                            dateEnd = new DateOnly(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
                            Logic();
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Error: Invalid date format. Please provide a date in the format YYYYMM.");
                            Environment.Exit(0);
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

       static private void Logic()
        {
            
            if (CheckForAbsenceOfData()) 
            {
                CreateData();   
            }
        }

       static private bool CheckForAbsenceOfData()
        {
            List<T_Billing_Status> tenativeData =  handler.GetT_Billing_Statuses(date);
            if (tenativeData != null)
            {
                return true;
            }
            else
            {

                if (tenativeData.Count != 1)
                {
                    {
                        Console.WriteLine("Multiple status data returned");
                        return false;
                    }
                }
                else
                {
                    //if
                    
                }
            }


            return false;
        }



        static private void CreateData()
        {
            

        }
    }
}

