using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CapaInfraestructura.Migrations
{
    /// <inheritdoc />
    public partial class createDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    NoCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCategoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.NoCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    NoProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProduto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    PrecioVenta = table.Column<double>(type: "float", nullable: false),
                    NoCategoria = table.Column<int>(type: "int", nullable: false),
                    CategoriaNoCategoria = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.NoProducto);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_CategoriaNoCategoria",
                        column: x => x.CategoriaNoCategoria,
                        principalTable: "Categorias",
                        principalColumn: "NoCategoria");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriaNoCategoria",
                table: "Productos",
                column: "CategoriaNoCategoria");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
