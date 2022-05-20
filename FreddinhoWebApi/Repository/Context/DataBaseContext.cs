using FreddinhoWebApi.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FreddinhoWebApi.Repository.Context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> preferences) 
            : base(preferences) { }


        public DbSet<AccountModel>? DbAccount { get; set; }

        public DbSet<AvailabilityModel>? DbAvailability { get; set; }

        public DbSet<PatientModel>? DbPatient { get; set; }

        public DbSet<PayHistoricModel>? DbHistoric { get; set; }

        public DbSet<PlainModel>? DbPlain { get; set; }

        public DbSet<PsychologistModel>? DbPsychologist { get; set; }


        protected override void OnModelCreating(ModelBuilder builder) 
        {
            SetAccountBuilder(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        private void SetAccountBuilder(ModelBuilder builder) 
        {
            builder.Entity<AccountModel>().ToTable("T_CONTA");

            builder.Entity<AccountModel>().Property();
        }
    }
}