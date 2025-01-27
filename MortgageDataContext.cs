using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class MortgageDataContext : DbContext
    {
        public DbSet<Mortgage> Mortgages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;database=MortgageDB;Trusted_connection=true;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mortgage>().ToTable("Mortgages");
        }
    }
    public class Mortgage
    {
        public int Id { get; set; }
        public string Type { get; set; }

       
        public decimal InterestRate { get; set; }
        public decimal LoanAmount { get; set; }
        public int LoanDuration { get; set; }
        public bool IsActive { get; set; }
    }
}
