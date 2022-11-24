using Microsoft.EntityFrameworkCore.Migrations;

namespace InformeTqERegiao.Migrations
{
    public partial class subestabelecimentoscompras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CAMAMESABANHO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    whatsapp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    redessociais = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMAMESABANHO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CONSTRUCAOUTENSILIOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    whatsapp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    redessociais = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONSTRUCAOUTENSILIOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ROUPAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    whatsapp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    redessociais = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROUPAS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SUPERMERCADOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    whatsapp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    redessociais = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUPERMERCADOS", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CAMAMESABANHO");

            migrationBuilder.DropTable(
                name: "CONSTRUCAOUTENSILIOS");

            migrationBuilder.DropTable(
                name: "ROUPAS");

            migrationBuilder.DropTable(
                name: "SUPERMERCADOS");
        }
    }
}
