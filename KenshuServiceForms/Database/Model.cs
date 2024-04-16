using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace KenshuServiceForms.Database
{
    public class Model : DbContext
    {
        public Model(DbContextOptions<Model> options) : base(options)
        {

        }

        public DbSet<T_Member> Members { get; set; }
        public DbSet<T_Charge> Charges { get; set; }
        public DbSet<T_Billing_Data> Billing_Data { get; set; }
        public DbSet<T_Billing_Detail_Data> Billing_Data_Detail { get; set; }
        public DbSet<T_Billing_Status> Billing_Status { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=172.27.200.231;Database=kmarcodb;Username=kmarco;Password=kmarco");
        }

    }
    public class T_Member
    {
        public int member_id { get; set; }
        [Required]
        public string mail { get; set; }
        [Required]
        public string? name { get; set; }
        public string? address { get; set; }
        public DateOnly? start_date { get; set; }
        public DateOnly? end_date { get; set; }
        public int? payment_method { get; set; } 
        //public DateTime? created_at { get; set; }
        //public DateTime? modified_at { get;set; }
    }
    public class T_Charge
    {
        public int charge_id { get; set; }
        [Required]
        public string charge_name { get; set; }
        public int? amount { get; set; }
        public DateOnly? startDate { get; set; }    
        public DateOnly? endDate { get; set;}
        //public DateTime? created_at { get; set; }
        //public DateTime? updated_at { get; set; }
    }
    public class T_Billing_Data
    {
        [Key]
        public DateOnly billing_ym { get; set; }
        [Key]
        public int member_id { get; set; }
        public string mail { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public DateOnly member_start_date { get; set; }
        public DateOnly member_end_date { get; set; }
        public int payment_method { get; set; }
        public int amount { get; set; } 
        public int tax_ratio { get; set; }
        public int total {  get; set; }
        //public DateTime? created_at { get; set; }
        //public DateTime? updated_at { get;set; }
    }
    public class T_Billing_Detail_Data
    {
        [Key]
        public DateOnly billing_ym { get; set; }
        [Key]
        public int member_id { get; set; }
        [Key]
        public int charge_id { get; set; }
        public string name { get; set; }
        public DateOnly start_date { get; set; }
        public DateOnly end_date { get; set; }
        //public DateTime? created_at { get; set; }
        //public DateTime? updated_at { get; set; }
    }
    public class T_Billing_Status
    {
        public DateOnly billing_ym { get; set; }
        public bool is_commited { get; set; }
        //public DateTime? created_at { get; set; }
        //public DateTime? updated_at { get; set; }
    }


}
