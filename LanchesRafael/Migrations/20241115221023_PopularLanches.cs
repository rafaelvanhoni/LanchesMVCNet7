using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesRafael.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Inserir lanches populares na tabela Lanches
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImageUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
                                 "VALUES ('Lanche de Frango', 'Lanche com frango grelhado e molho especial', 'Lanche delicioso com peito de frango grelhado, alface, tomate, cebola e molho especial.', 15.99, '/images/lanches01.jpeg', '/images/thumbnails/lanches01.jpeg', 1, 1, 1)");

            migrationBuilder.Sql("INSERT INTO Lanches (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImageUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
                                 "VALUES ('Lanche Vegetariano', 'Lanche com ingredientes naturais e frescos', 'Lanche saudável com abacate, alface, tomate, pepino e molho especial.', 18.50, '/images/lanches02.jpeg', '/images/thumbnails/lanches02.jpeg', 0, 1, 2)");

            migrationBuilder.Sql("INSERT INTO Lanches (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImageUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
                                 "VALUES ('Lanche de Carne', 'Lanche com carne bovina grelhada e molho barbecue', 'Lanche com carne grelhada, cebola caramelizada, queijo cheddar e molho barbecue.', 19.99, '/images/lanches03.jpeg', '/images/thumbnails/lanches03.jpeg', 0, 1, 1)");

            migrationBuilder.Sql("INSERT INTO Lanches (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImageUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
                                 "VALUES ('Lanche de Peixe', 'Lanche com peixe empanado e molho tártaro', 'Lanche leve com peixe empanado, alface, tomate e molho tártaro.', 17.00, '/images/lanches04.jpeg', '/images/thumbnails/lanches04.jpeg', 0, 1, 1)");

            migrationBuilder.Sql("INSERT INTO Lanches (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImageUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
                                 "VALUES ('Lanche de Bacon', 'Lanche com bacon crocante e queijo', 'Lanche saboroso com bacon crocante, alface, queijo e maionese.', 20.50, '/images/lanches05.jpeg', '/images/thumbnails/lanches05.jpeg', 0, 1, 1)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Deletar os lanches que foram inseridos
            migrationBuilder.Sql("DELETE FROM Lanches");

        }
    }
}
