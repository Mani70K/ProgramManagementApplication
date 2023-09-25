using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgramApp.API.Migrations
{
    public partial class program : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DOBEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsInternal = table.Column<bool>(type: "bit", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    DOBInfo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOBEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsMandatory = table.Column<bool>(type: "bit", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenderEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsInternal = table.Column<bool>(type: "bit", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    GenderInfo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenderEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IDEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsInternal = table.Column<bool>(type: "bit", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    IDNumberInfo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IDEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NationalityEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsInternal = table.Column<bool>(type: "bit", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    NationalityInfo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalityEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumberEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsInternal = table.Column<bool>(type: "bit", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumberInfo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumberEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "programs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgramSummary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgramDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgramBenefits = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationCriteria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgramType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgramStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationOpen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationClose = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgramLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinQualifications = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxNumberOfApplication = table.Column<int>(type: "int", nullable: false),
                    CoverImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_programs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResidenceEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsInternal = table.Column<bool>(type: "bit", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    CurrentResidenceInfo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidenceEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResumeEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsMandatory = table.Column<bool>(type: "bit", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    ResumeURLInfo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkExperienceEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsMandatory = table.Column<bool>(type: "bit", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperienceEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationDomain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCurrentStudy = table.Column<bool>(type: "bit", nullable: false),
                    EducationEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationDomain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationDomain_EducationEntity_EducationEntityId",
                        column: x => x.EducationEntityId,
                        principalTable: "EducationEntity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "stages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_stages_programs_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "programs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumberId = table.Column<int>(type: "int", nullable: false),
                    NationalityId = table.Column<int>(type: "int", nullable: false),
                    CurrentResidenceId = table.Column<int>(type: "int", nullable: false),
                    IdNumberId = table.Column<int>(type: "int", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    DOBId = table.Column<int>(type: "int", nullable: false),
                    EducationsId = table.Column<int>(type: "int", nullable: false),
                    WorkExperiencesId = table.Column<int>(type: "int", nullable: false),
                    ResumeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_users_DOBEntity_DOBId",
                        column: x => x.DOBId,
                        principalTable: "DOBEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_EducationEntity_EducationsId",
                        column: x => x.EducationsId,
                        principalTable: "EducationEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_GenderEntity_GenderId",
                        column: x => x.GenderId,
                        principalTable: "GenderEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_IDEntity_IdNumberId",
                        column: x => x.IdNumberId,
                        principalTable: "IDEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_NationalityEntity_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "NationalityEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_PhoneNumberEntity_PhoneNumberId",
                        column: x => x.PhoneNumberId,
                        principalTable: "PhoneNumberEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_programs_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "programs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_ResidenceEntity_CurrentResidenceId",
                        column: x => x.CurrentResidenceId,
                        principalTable: "ResidenceEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_ResumeEntity_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "ResumeEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_WorkExperienceEntity_WorkExperiencesId",
                        column: x => x.WorkExperiencesId,
                        principalTable: "WorkExperienceEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkExperienceDomain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Locattion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCurrentCompany = table.Column<bool>(type: "bit", nullable: false),
                    WorkExperienceEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperienceDomain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkExperienceDomain_WorkExperienceEntity_WorkExperienceEntityId",
                        column: x => x.WorkExperienceEntityId,
                        principalTable: "WorkExperienceEntity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StageDomain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsTheStageVisible = table.Column<bool>(type: "bit", nullable: false),
                    StageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StageDomain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StageDomain_stages_StageId",
                        column: x => x.StageId,
                        principalTable: "stages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "QuestionDomain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionDomain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionDomain_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EducationDomain_EducationEntityId",
                table: "EducationDomain",
                column: "EducationEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionDomain_UserId",
                table: "QuestionDomain",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StageDomain_StageId",
                table: "StageDomain",
                column: "StageId");

            migrationBuilder.CreateIndex(
                name: "IX_stages_ProgramId",
                table: "stages",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_users_CurrentResidenceId",
                table: "users",
                column: "CurrentResidenceId");

            migrationBuilder.CreateIndex(
                name: "IX_users_DOBId",
                table: "users",
                column: "DOBId");

            migrationBuilder.CreateIndex(
                name: "IX_users_EducationsId",
                table: "users",
                column: "EducationsId");

            migrationBuilder.CreateIndex(
                name: "IX_users_GenderId",
                table: "users",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_users_IdNumberId",
                table: "users",
                column: "IdNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_users_NationalityId",
                table: "users",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_users_PhoneNumberId",
                table: "users",
                column: "PhoneNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_users_ProgramId",
                table: "users",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_users_ResumeId",
                table: "users",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_users_WorkExperiencesId",
                table: "users",
                column: "WorkExperiencesId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperienceDomain_WorkExperienceEntityId",
                table: "WorkExperienceDomain",
                column: "WorkExperienceEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EducationDomain");

            migrationBuilder.DropTable(
                name: "QuestionDomain");

            migrationBuilder.DropTable(
                name: "StageDomain");

            migrationBuilder.DropTable(
                name: "WorkExperienceDomain");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "stages");

            migrationBuilder.DropTable(
                name: "DOBEntity");

            migrationBuilder.DropTable(
                name: "EducationEntity");

            migrationBuilder.DropTable(
                name: "GenderEntity");

            migrationBuilder.DropTable(
                name: "IDEntity");

            migrationBuilder.DropTable(
                name: "NationalityEntity");

            migrationBuilder.DropTable(
                name: "PhoneNumberEntity");

            migrationBuilder.DropTable(
                name: "ResidenceEntity");

            migrationBuilder.DropTable(
                name: "ResumeEntity");

            migrationBuilder.DropTable(
                name: "WorkExperienceEntity");

            migrationBuilder.DropTable(
                name: "programs");
        }
    }
}
