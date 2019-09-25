﻿// <auto-generated />
using System;
using FethiTekyaygilWebsite.Database.DatabaseContextFolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FethiTekyaygilWebsite.Database.Migrations
{
    [DbContext(typeof(GenericDatabaseContext))]
    [Migration("20190925090450_Mig1")]
    partial class Mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FethiTekyaygilWebsite.Data.POCOs.CommunicationTalent", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EnglishCommunicationTalent")
                        .IsRequired();

                    b.Property<string>("ImagePath")
                        .IsRequired();

                    b.Property<int>("PersonalTalentID");

                    b.Property<string>("TurkishCommunicationTalent")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("PersonalTalentID");

                    b.ToTable("CommunicationTalents");
                });

            modelBuilder.Entity("FethiTekyaygilWebsite.Data.POCOs.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Message")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("SendDate");

                    b.HasKey("ID");

                    b.ToTable("ContactTable");
                });

            modelBuilder.Entity("FethiTekyaygilWebsite.Data.POCOs.Developer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("EnglishAboutMe")
                        .IsRequired();

                    b.Property<string>("EnglishNativeLanguage")
                        .IsRequired();

                    b.Property<string>("EnglishTitle")
                        .IsRequired();

                    b.Property<string>("ImageName")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Surname")
                        .IsRequired();

                    b.Property<string>("TurkishAboutMe")
                        .IsRequired();

                    b.Property<string>("TurkishNativeLanguage")
                        .IsRequired();

                    b.Property<string>("TurkishTitle")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("DeveloperTable");
                });

            modelBuilder.Entity("FethiTekyaygilWebsite.Data.POCOs.Education", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EndDate");

                    b.Property<string>("EnglishAddress")
                        .IsRequired();

                    b.Property<string>("EnglishDepartment")
                        .IsRequired();

                    b.Property<string>("EnglishExplanation");

                    b.Property<string>("EnglishSchool")
                        .IsRequired();

                    b.Property<string>("ImageExt");

                    b.Property<string>("ImageName");

                    b.Property<bool>("IsPresent");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("TurkishAddress")
                        .IsRequired();

                    b.Property<string>("TurkishDepartment")
                        .IsRequired();

                    b.Property<string>("TurkishExplanation");

                    b.Property<string>("TurkishSchool")
                        .IsRequired();

                    b.Property<string>("WebSite")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("EducationTable");
                });

            modelBuilder.Entity("FethiTekyaygilWebsite.Data.POCOs.Hobby", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EnglishExplanation")
                        .IsRequired();

                    b.Property<string>("EnglishName")
                        .IsRequired();

                    b.Property<string>("ImageName")
                        .IsRequired();

                    b.Property<string>("TurkishExplanation")
                        .IsRequired();

                    b.Property<string>("TurkishName")
                        .IsRequired();

                    b.Property<string>("VideoName")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("HobbyTable");
                });

            modelBuilder.Entity("FethiTekyaygilWebsite.Data.POCOs.Language", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EnglishName")
                        .IsRequired();

                    b.Property<int>("PersonalTalentID");

                    b.Property<string>("TurkishName")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("EnglishName")
                        .IsUnique();

                    b.HasIndex("PersonalTalentID");

                    b.HasIndex("TurkishName")
                        .IsUnique();

                    b.ToTable("LanguageTable");
                });

            modelBuilder.Entity("FethiTekyaygilWebsite.Data.POCOs.LanguageCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EnglishCategory")
                        .IsRequired();

                    b.Property<int>("LanguageDegreeID");

                    b.Property<string>("TurkishCategory")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("LanguageDegreeID");

                    b.ToTable("LanguageCategoryTable");
                });

            modelBuilder.Entity("FethiTekyaygilWebsite.Data.POCOs.LanguageDegree", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.HasKey("ID");

                    b.ToTable("LanguageDegreeTable");
                });

            modelBuilder.Entity("FethiTekyaygilWebsite.Data.POCOs.LanguageLanguageCategory", b =>
                {
                    b.Property<int>("LanguageCategoryID");

                    b.Property<int>("LanguageID");

                    b.HasKey("LanguageCategoryID", "LanguageID");

                    b.HasIndex("LanguageID");

                    b.ToTable("LanguageLanguageCategoryTable");
                });

            modelBuilder.Entity("FethiTekyaygilWebsite.Data.POCOs.PersonalTalent", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("ID");

                    b.ToTable("PersonalTalentTable");
                });

            modelBuilder.Entity("FethiTekyaygilWebsite.Data.POCOs.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EnglishExplanation")
                        .IsRequired();

                    b.Property<string>("EnglishName")
                        .IsRequired();

                    b.Property<bool>("IsMobile");

                    b.Property<string>("Link");

                    b.Property<string>("Link2");

                    b.Property<int>("Sira");

                    b.Property<string>("TurkishExplanation")
                        .IsRequired();

                    b.Property<string>("TurkishName")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("ProjectTable");
                });

            modelBuilder.Entity("FethiTekyaygilWebsite.Data.POCOs.WorkExperience", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Company")
                        .IsRequired();

                    b.Property<DateTime?>("EndDate");

                    b.Property<string>("EnglishAddress");

                    b.Property<string>("EnglishExplanation");

                    b.Property<string>("EnglishPosition")
                        .IsRequired();

                    b.Property<string>("ImageExt");

                    b.Property<string>("ImageName");

                    b.Property<bool>("IsPresent");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("TurkishAddress");

                    b.Property<string>("TurkishExplanation");

                    b.Property<string>("TurkishPosition")
                        .IsRequired();

                    b.Property<string>("WebSite")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("WorkExperienceTable");
                });

            modelBuilder.Entity("FethiTekyaygilWebsite.Data.POCOs.WorkTalent", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryNumber");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("PeronalTalentID");

                    b.Property<int?>("PersonalTalentID");

                    b.Property<double>("Rate");

                    b.HasKey("ID");

                    b.HasIndex("PeronalTalentID");

                    b.ToTable("WorkTalentTable");
                });

            modelBuilder.Entity("FethiTekyaygilWebsite.Data.POCOs.CommunicationTalent", b =>
                {
                    b.HasOne("FethiTekyaygilWebsite.Data.POCOs.PersonalTalent", "PersonalTalent")
                        .WithMany("CommunicationTalents")
                        .HasForeignKey("PersonalTalentID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FethiTekyaygilWebsite.Data.POCOs.Language", b =>
                {
                    b.HasOne("FethiTekyaygilWebsite.Data.POCOs.PersonalTalent", "PersonalTalent")
                        .WithMany("Languages")
                        .HasForeignKey("PersonalTalentID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FethiTekyaygilWebsite.Data.POCOs.LanguageCategory", b =>
                {
                    b.HasOne("FethiTekyaygilWebsite.Data.POCOs.LanguageDegree", "LanguageDegree")
                        .WithMany("Categories")
                        .HasForeignKey("LanguageDegreeID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FethiTekyaygilWebsite.Data.POCOs.LanguageLanguageCategory", b =>
                {
                    b.HasOne("FethiTekyaygilWebsite.Data.POCOs.LanguageCategory", "LanguageCategory")
                        .WithMany("Languages")
                        .HasForeignKey("LanguageCategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FethiTekyaygilWebsite.Data.POCOs.Language", "Language")
                        .WithMany("Categories")
                        .HasForeignKey("LanguageID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FethiTekyaygilWebsite.Data.POCOs.WorkTalent", b =>
                {
                    b.HasOne("FethiTekyaygilWebsite.Data.POCOs.PersonalTalent", "PersonalTalent")
                        .WithMany("WorkTalents")
                        .HasForeignKey("PeronalTalentID")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
