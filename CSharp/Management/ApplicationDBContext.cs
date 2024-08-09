using Microsoft.EntityFrameworkCore;
using System;

namespace Management
{
    public class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\v11.0;Initial Catalog=TestDB;Integrated Security=True");
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Language> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .ToTable("Persons");

            modelBuilder.Entity<Employee>()
                .ToTable("Employees")
                .HasBaseType<Person>();

            modelBuilder.Entity<Manager>()
                .ToTable("Managers")
                .HasBaseType<Person>();

            modelBuilder.Entity<Skill>()
                .HasOne(s => s.Person)
                .WithMany(p => p.skills)
                .HasForeignKey(s => s.personID);

            modelBuilder.Entity<Language>()
                .HasOne(l => l.Person)
                .WithMany(p => p.languages)
                .HasForeignKey(l => l.personID);
        }
    }
}
