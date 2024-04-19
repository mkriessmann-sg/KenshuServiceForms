using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace KenshuServiceDatabaseLibrary
{
    public class ModelContext : DbContext
    {
        public ModelContext()
        {
        }
        public DbSet<T_Member> Members { get; set; }
        public DbSet<T_Charge> Charges { get; set; }
        public DbSet<T_Billing_Data> Billing_Data { get; set; }
        public DbSet<T_Billing_Detail_Data> Billing_Data_Detail { get; set; }
        public DbSet<T_Billing_Status> Billing_Status { get; set; }

        public ModelContext(DbContextOptions<ModelContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<T_Billing_Data>()
                .HasKey(bd => new { bd.billing_ym, bd.member_id });

            modelBuilder.Entity<T_Billing_Detail_Data>()
                .HasKey(bdd => new { bdd.billing_ym, bdd.member_id, bdd.charge_id });
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=172.27.200.231;Port=5432;Database=kmarcodb;Username=kmarco;Password=kmarco");
        }
    }
    public class T_Member
    {        
        [Key]
        public int member_id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(256)]
        [Required]
        public string mail { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(32)]
        [Required]
        public string name { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(256)]
        public string address { get; set; }
        public DateOnly start_date { get; set; }
        public DateOnly? end_date { get; set; }
        public int payment_method { get; set; }
    }
    public class T_Charge
    {
        [Key]
        public int charge_id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(64)]
        [Required]
        public string charge_name { get; set; }
        [Range(0, 999999999)]
        public int amount { get; set; }
        public DateOnly startDate { get; set; }
        public DateOnly? endDate { get; set; }
    }
    public class T_Billing_Data
    {
        public DateOnly billing_ym { get; set; }
        public int member_id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(256)]
        public string mail { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(32)]
        public string name { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(256)]
        public string address { get; set; }
        public DateOnly member_start_date { get; set; }
        public DateOnly? member_end_date { get; set; }
        public int payment_method { get; set; }
        [Range(0, 999999999)]
        public int amount { get; set; }
        [RegularExpression(@"^\d{1,3}(\.\d{1,2})?$", ErrorMessage = "Invalid format")]
        public double tax_ratio { get; set; }
        [Range(0, 999999999)]
        public int total { get; set; }
    }
    public class T_Billing_Detail_Data
    {
        public DateOnly billing_ym { get; set; }
        public int member_id { get; set; }
        public int charge_id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(64)]
        public string name { get; set; }
        [Range(0, 999999999)]
        public int? amount { get; set; }
        public DateOnly start_date { get; set; }
        public DateOnly? end_date { get; set; }
    }
    public class T_Billing_Status
    {
        [Key]
        public DateOnly billing_ym { get; set; }
        public bool is_commited { get; set; }
    }


}
