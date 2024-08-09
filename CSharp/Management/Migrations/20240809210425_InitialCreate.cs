using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Management.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    personID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    martialStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.personID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    personID = table.Column<int>(type: "int", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    jobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    department = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.personID);
                    table.ForeignKey(
                        name: "FK_Employees_Persons_personID",
                        column: x => x.personID,
                        principalTable: "Persons",
                        principalColumn: "personID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    languageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    languageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    proficiency = table.Column<int>(type: "int", nullable: false),
                    personID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.languageID);
                    table.ForeignKey(
                        name: "FK_Languages_Persons_personID",
                        column: x => x.personID,
                        principalTable: "Persons",
                        principalColumn: "personID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    personID = table.Column<int>(type: "int", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    jobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    department = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.personID);
                    table.ForeignKey(
                        name: "FK_Managers_Persons_personID",
                        column: x => x.personID,
                        principalTable: "Persons",
                        principalColumn: "personID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    skillID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    skillName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.skillID);
                    table.ForeignKey(
                        name: "FK_Skills_Persons_personID",
                        column: x => x.personID,
                        principalTable: "Persons",
                        principalColumn: "personID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Languages_personID",
                table: "Languages",
                column: "personID");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_personID",
                table: "Skills",
                column: "personID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
