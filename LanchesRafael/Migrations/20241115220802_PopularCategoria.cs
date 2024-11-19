using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesRafael.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) VALUES " +
                "('Normal', 'Lanches feitos com ingredientes normais')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) VALUES " +
                "('Natural', 'Lanches feitos com ingredientes naturais')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
