using FethiTekyaygilWebsite.Data.POCOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;

namespace FethiTekyaygilWebsite.Database.DatabaseContextFolder
{
    public class GenericDatabaseContext : DbContext
    {

        public static DatabaseProvider provider = DatabaseProvider.MSSQL;

        public GenericDatabaseContext() : base()
        { }

        public GenericDatabaseContext(DbContextOptions options) : base()
        { }

        public DbSet<Developer> Developers { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<LanguageCategory> LanguageCategories { get; set; }
        public DbSet<LanguageDegree> LanguageDegrees { get; set; }
        public DbSet<PersonalTalent> PersonalTalents { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<WorkTalent> WorkTalents { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<LanguageLanguageCategory> LanguageLanguageCategories { get; set; }
        public DbSet<CommunicationTalent> CommunicationTalents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
                foreach (var property in entityType.GetProperties())
                    if (property.ClrType == typeof(Nullable<bool>) || property.ClrType == typeof(Nullable<Boolean>))
                        property.SetValueConverter(new BoolToZeroOneConverter<Nullable<Int16>>());

            modelBuilder.Entity<LanguageLanguageCategory>()
                .HasKey(lc => new { lc.LanguageCategoryID, lc.LanguageID });

            modelBuilder.Entity<LanguageLanguageCategory>()
                .HasOne<LanguageCategory>(lc => lc.LanguageCategory)
                .WithMany(m => m.Languages)
                .HasForeignKey(fk => fk.LanguageCategoryID);

            modelBuilder.Entity<LanguageLanguageCategory>()
                .HasOne<Language>(lc => lc.Language)
                .WithMany(m => m.Categories)
                .HasForeignKey(fk => fk.LanguageID);


            modelBuilder.Entity<Language>()
                .HasIndex(i => i.TurkishName)
                .IsUnique();

            modelBuilder.Entity<Language>()
                .HasIndex(i => i.EnglishName)
                .IsUnique();

            modelBuilder.Entity<PersonalTalent>()
                .HasMany(m => m.Languages)
                .WithOne(o => o.PersonalTalent)
                .HasForeignKey(fk => fk.PersonalTalentID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PersonalTalent>()
                .HasMany(m => m.CommunicationTalents)
                .WithOne(o => o.PersonalTalent)
                .HasForeignKey(fk => fk.PersonalTalentID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PersonalTalent>()
                .HasMany(m => m.WorkTalents)
                .WithOne(o => o.PersonalTalent)
                .HasForeignKey(fk => fk.PeronalTalentID)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Language>()
                .HasMany(m => m.Categories)
                .WithOne(o => o.Language)
                .HasForeignKey(fk => fk.LanguageID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LanguageCategory>()
                .HasOne(o => o.LanguageDegree)
                .WithMany(m => m.Categories)
                .HasForeignKey(fk => fk.LanguageDegreeID)
                .OnDelete(DeleteBehavior.Restrict);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            string connectionString = DatabaseContextSelector.GetConnectionString(provider); ;

            builder.EnableSensitiveDataLogging();
            if (provider == DatabaseProvider.MSSQL)
                builder.UseSqlServer(connectionString);
            else
                builder.UseMySql(connectionString);
            //builder.UseLazyLoadingProxies();
            base.OnConfiguring(builder);
        }
    }
}

