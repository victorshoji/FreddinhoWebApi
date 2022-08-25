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

        public DbSet<Dependent>? DbDependent { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            SetAccountBuilder(builder);
            SetDependentBuilder(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        private void SetAccountBuilder(ModelBuilder builder)
        {
            builder.Entity<AccountModel>().ToTable("T_ACCOUNT");

            builder.Entity<AccountModel>().Property(a => a.Name)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(80);

            builder.Entity<AccountModel>().Property(a => a.CellphoneNumber)
                .IsRequired();

            builder.Entity<AccountModel>().Property(a => a.Gender)
                .IsRequired();

            builder.Entity<AccountModel>().Property(a => a.Email)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(200);

            builder.Entity<AccountModel>().Property(a => a.Password)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(250);
        }

        private void SetDependentBuilder(ModelBuilder builder)
        {
            builder.Entity<Dependent>().ToTable("T_DEPENDENT");

            builder.Entity<Dependent>().Property(d => d.BirthYear)
                .IsRequired();

            builder.Entity<Dependent>().Property(d => d.Name)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(80);

            builder.Entity<Dependent>().Property(a => a.Gender)
                .IsRequired();

            builder.Entity<Dependent>()
                .HasOne<AccountModel>(d => d.AccountModel)
                .WithMany(a => a.Dependents)
                .HasForeignKey(fk => fk.AccountModelId);
        }
    }
}