using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FethiTekyaygilWebsite.Database.Migrations
{
    public partial class Mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactTable",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Message = table.Column<string>(nullable: false),
                    SendDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DeveloperTable",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    ImageName = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    EnglishTitle = table.Column<string>(nullable: false),
                    TurkishTitle = table.Column<string>(nullable: false),
                    TurkishNativeLanguage = table.Column<string>(nullable: false),
                    EnglishNativeLanguage = table.Column<string>(nullable: false),
                    TurkishAboutMe = table.Column<string>(nullable: false),
                    EnglishAboutMe = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeveloperTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EducationTable",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TurkishDepartment = table.Column<string>(nullable: false),
                    EnglishDepartment = table.Column<string>(nullable: false),
                    TurkishSchool = table.Column<string>(nullable: false),
                    EnglishSchool = table.Column<string>(nullable: false),
                    ImageName = table.Column<string>(nullable: true),
                    ImageExt = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    IsPresent = table.Column<bool>(nullable: false),
                    TurkishAddress = table.Column<string>(nullable: false),
                    EnglishAddress = table.Column<string>(nullable: false),
                    WebSite = table.Column<string>(nullable: false),
                    TurkishExplanation = table.Column<string>(nullable: true),
                    EnglishExplanation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HobbyTable",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TurkishName = table.Column<string>(nullable: false),
                    EnglishName = table.Column<string>(nullable: false),
                    VideoName = table.Column<string>(nullable: false),
                    ImageName = table.Column<string>(nullable: false),
                    TurkishExplanation = table.Column<string>(nullable: false),
                    EnglishExplanation = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HobbyTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LanguageDegreeTable",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Degree = table.Column<string>(maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageDegreeTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PersonalTalentTable",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalTalentTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTable",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TurkishName = table.Column<string>(nullable: false),
                    EnglishName = table.Column<string>(nullable: false),
                    Link = table.Column<string>(nullable: true),
                    Link2 = table.Column<string>(nullable: true),
                    TurkishExplanation = table.Column<string>(nullable: false),
                    EnglishExplanation = table.Column<string>(nullable: false),
                    IsMobile = table.Column<bool>(nullable: false),
                    Sira = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WorkExperienceTable",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TurkishPosition = table.Column<string>(nullable: false),
                    EnglishPosition = table.Column<string>(nullable: false),
                    Company = table.Column<string>(nullable: false),
                    ImageName = table.Column<string>(nullable: true),
                    ImageExt = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    IsPresent = table.Column<bool>(nullable: false),
                    TurkishExplanation = table.Column<string>(nullable: true),
                    EnglishExplanation = table.Column<string>(nullable: true),
                    WebSite = table.Column<string>(nullable: false),
                    TurkishAddress = table.Column<string>(nullable: true),
                    EnglishAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperienceTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LanguageCategoryTable",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TurkishCategory = table.Column<string>(nullable: false),
                    EnglishCategory = table.Column<string>(nullable: false),
                    LanguageDegreeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageCategoryTable", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LanguageCategoryTable_LanguageDegreeTable_LanguageDegreeID",
                        column: x => x.LanguageDegreeID,
                        principalTable: "LanguageDegreeTable",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CommunicationTalents",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TurkishCommunicationTalent = table.Column<string>(nullable: false),
                    EnglishCommunicationTalent = table.Column<string>(nullable: false),
                    ImagePath = table.Column<string>(nullable: false),
                    PersonalTalentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunicationTalents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CommunicationTalents_PersonalTalentTable_PersonalTalentID",
                        column: x => x.PersonalTalentID,
                        principalTable: "PersonalTalentTable",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LanguageTable",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TurkishName = table.Column<string>(nullable: false),
                    EnglishName = table.Column<string>(nullable: false),
                    PersonalTalentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageTable", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LanguageTable_PersonalTalentTable_PersonalTalentID",
                        column: x => x.PersonalTalentID,
                        principalTable: "PersonalTalentTable",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkTalentTable",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Rate = table.Column<double>(nullable: false),
                    PeronalTalentID = table.Column<int>(nullable: false),
                    CategoryNumber = table.Column<int>(nullable: false),
                    PersonalTalentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTalentTable", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WorkTalentTable_PersonalTalentTable_PeronalTalentID",
                        column: x => x.PeronalTalentID,
                        principalTable: "PersonalTalentTable",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LanguageLanguageCategoryTable",
                columns: table => new
                {
                    LanguageID = table.Column<int>(nullable: false),
                    LanguageCategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageLanguageCategoryTable", x => new { x.LanguageCategoryID, x.LanguageID });
                    table.ForeignKey(
                        name: "FK_LanguageLanguageCategoryTable_LanguageCategoryTable_LanguageCategoryID",
                        column: x => x.LanguageCategoryID,
                        principalTable: "LanguageCategoryTable",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageLanguageCategoryTable_LanguageTable_LanguageID",
                        column: x => x.LanguageID,
                        principalTable: "LanguageTable",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommunicationTalents_PersonalTalentID",
                table: "CommunicationTalents",
                column: "PersonalTalentID");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageCategoryTable_LanguageDegreeID",
                table: "LanguageCategoryTable",
                column: "LanguageDegreeID");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageLanguageCategoryTable_LanguageID",
                table: "LanguageLanguageCategoryTable",
                column: "LanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageTable_EnglishName",
                table: "LanguageTable",
                column: "EnglishName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LanguageTable_PersonalTalentID",
                table: "LanguageTable",
                column: "PersonalTalentID");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageTable_TurkishName",
                table: "LanguageTable",
                column: "TurkishName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkTalentTable_PeronalTalentID",
                table: "WorkTalentTable",
                column: "PeronalTalentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommunicationTalents");

            migrationBuilder.DropTable(
                name: "ContactTable");

            migrationBuilder.DropTable(
                name: "DeveloperTable");

            migrationBuilder.DropTable(
                name: "EducationTable");

            migrationBuilder.DropTable(
                name: "HobbyTable");

            migrationBuilder.DropTable(
                name: "LanguageLanguageCategoryTable");

            migrationBuilder.DropTable(
                name: "ProjectTable");

            migrationBuilder.DropTable(
                name: "WorkExperienceTable");

            migrationBuilder.DropTable(
                name: "WorkTalentTable");

            migrationBuilder.DropTable(
                name: "LanguageCategoryTable");

            migrationBuilder.DropTable(
                name: "LanguageTable");

            migrationBuilder.DropTable(
                name: "LanguageDegreeTable");

            migrationBuilder.DropTable(
                name: "PersonalTalentTable");
        }
    }
}
