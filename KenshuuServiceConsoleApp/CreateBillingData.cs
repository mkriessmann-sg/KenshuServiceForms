using KenshuServiceDatabaseLibrary;
using System.Runtime.InteropServices;
using CommandLine;
using System.Runtime.CompilerServices;
using Npgsql.Replication.PgOutput.Messages;
using System.Globalization;

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
                            //date = DateOnly.Parse(temp);
                            date = DateOnly.ParseExact(temp, "yyyyMMdd", CultureInfo.InvariantCulture);
                            dateEnd = new DateOnly(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
                            Console.WriteLine("Start Date:" + date + "EndDate:" + dateEnd);
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
                
                handler.DeleteDesignatedDateData(date);
                Console.WriteLine("Creaing new Data");
                CreateData();
                handler.SaveChanges();
            }
        }

       static private bool CheckForAbsenceOfData()
        {
            List<T_Billing_Status> tenativeData =  handler.GetT_Billing_Statuses(date);
            if (tenativeData != null)
            {
                Console.WriteLine("Data absent executing");
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
                    foreach  (T_Billing_Status b in tenativeData)
                    {
                        if (b.is_commited) { Console.WriteLine("Data already comitted"); return false; }
                        else { Console.WriteLine("Data flagged false executing"); return true; }

                    }
                    
                }
            }
            return false;
        }



        static private void CreateData()
        {
            List<T_Member> t_Members = handler.GetMembersByDate(date, dateEnd);
            List<T_Charge> charges = handler.GetChargesByDate(date,dateEnd);

            foreach (T_Member t in t_Members)
            {
                T_Billing_Data b = new T_Billing_Data();
                //KEY
                b.member_id = t.member_id;
                //KEY
                b.billing_ym = date;
                b.mail = t.mail;
                b.name = t.name;
                b.address = t.address;
                b.member_start_date = (DateOnly)t.start_date;
                b.member_end_date = t.end_date;
                b.payment_method = t.payment_method;

                int total= 0;
                foreach (T_Charge charge in charges)
                {
                    total +=charge.amount;
                    T_Billing_Detail_Data d = new T_Billing_Detail_Data();

                    d.billing_ym = date;
                    d.member_id = t.member_id;
                    d.charge_id = charge.charge_id;
                    d.name = charge.charge_name;
                    d.amount = charge.amount;
                    d.start_date = charge.startDate;
                    d.end_date = charge.endDate;
                    Console.WriteLine("Creating billing details: Year:" + d.billing_ym +"MemberID" + d.member_id+ "chargeID:" + d.charge_id );
                    handler.CreateBillingDetails(d);
                }
                b.amount = total;
                b.tax_ratio = 10.00;
                b.total = Convert.ToInt32(b.tax_ratio + b.amount);
                Console.WriteLine("Creating billing data: Year:" + b.billing_ym + "MemberID" + b.member_id);
                handler.CreateBillingData(b);
            }
             
            T_Billing_Status status = new T_Billing_Status();
            status.billing_ym = date;
            status.is_commited = false;
            handler.CreateBillingStatus(status);


        }
    }
}

