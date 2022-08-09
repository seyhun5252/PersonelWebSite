using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mg_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDegree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutBirthday = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutExperience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactEmail = table.Column<int>(type: "int", nullable: false),
                    ContactSubject = table.Column<int>(type: "int", nullable: false),
                    ContactMessage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "EducationAndExpericences",
                columns: table => new
                {
                    EducationAndExpericenceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationAndExpericenceTitle = table.Column<int>(type: "int", nullable: false),
                    EducationAndExpericenceLittleTitle = table.Column<int>(type: "int", nullable: false),
                    EducationAndExpericenceDate = table.Column<int>(type: "int", nullable: false),
                    EducationAndExpericenceDescription = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationAndExpericences", x => x.EducationAndExpericenceID);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    LinkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkTwitter = table.Column<int>(type: "int", nullable: false),
                    LinkFacebook = table.Column<int>(type: "int", nullable: false),
                    LinkLinkedin = table.Column<int>(type: "int", nullable: false),
                    LinkInstagram = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.LinkID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServicesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicesTitle = table.Column<int>(type: "int", nullable: false),
                    ServicesDescription = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServicesID);
                });

            migrationBuilder.CreateTable(
                name: "Skils",
                columns: table => new
                {
                    SkilsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkilsTitle = table.Column<int>(type: "int", nullable: false),
                    SkilsRatio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skils", x => x.SkilsID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "EducationAndExpericences");

            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Skils");
        }
    }
}
