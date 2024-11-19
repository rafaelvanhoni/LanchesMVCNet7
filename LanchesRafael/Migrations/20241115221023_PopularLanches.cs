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
                                 "VALUES ('Lanche de Frango', 'Lanche com frango grelhado e molho especial', 'Lanche delicioso com peito de frango grelhado, alface, tomate, cebola e molho especial.', 15.99, 'url-imagem-frango', 'url-miniatura-frango', 1, 1, 1)");

            migrationBuilder.Sql("INSERT INTO Lanches (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImageUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
                                 "VALUES ('Lanche Vegetariano', 'Lanche com ingredientes naturais e frescos', 'Lanche saudável com abacate, alface, tomate, pepino e molho especial.', 18.50, 'url-imagem-vegetariano', 'url-miniatura-vegetariano', 0, 1, 2)");

            migrationBuilder.Sql("INSERT INTO Lanches (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImageUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
                                 "VALUES ('Lanche de Carne', 'Lanche com carne bovina grelhada e molho barbecue', 'Lanche com carne grelhada, cebola caramelizada, queijo cheddar e molho barbecue.', 19.99, 'url-imagem-carne', 'url-miniatura-carne', 0, 1, 1)");

            migrationBuilder.Sql("INSERT INTO Lanches (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImageUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
                                 "VALUES ('Lanche de Peixe', 'Lanche com peixe empanado e molho tártaro', 'Lanche leve com peixe empanado, alface, tomate e molho tártaro.', 17.00, 'url-imagem-peixe', 'url-miniatura-peixe', 0, 1, 1)");

            migrationBuilder.Sql("INSERT INTO Lanches (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImageUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
                                 "VALUES ('Lanche de Bacon', 'Lanche com bacon crocante e queijo', 'Lanche saboroso com bacon crocante, alface, queijo e maionese.', 20.50, 'url-imagem-bacon', 'url-miniatura-bacon', 0, 1, 1)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Deletar os lanches que foram inseridos
            migrationBuilder.Sql("DELETE FROM Lanches");

        }
    }
}
