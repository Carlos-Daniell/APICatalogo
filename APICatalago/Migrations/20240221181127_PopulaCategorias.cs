using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalago.Migrations {
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb) {
            mb.Sql("insert into Categorias(Nome,ImagemUrl) Values('Bebidas','bebidas.jpg')");
            mb.Sql("insert into Categorias(Nome,ImagemUrl) Values('Lanches','lanches.jpg')");
            mb.Sql("insert into Categorias(Nome,ImagemUrl) Values('Sobremesas','sobremesas.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder md) {

            md.Sql("Delete from Categorias");

        }
    }
}
