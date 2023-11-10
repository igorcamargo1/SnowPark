using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SnowPark.Migrations
{
    /// <inheritdoc />
    public partial class atualizando : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Tbl_Compra",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Tp_Pagamento",
                table: "Tbl_Compra",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Tbl_Compra");

            migrationBuilder.DropColumn(
                name: "Tp_Pagamento",
                table: "Tbl_Compra");
        }
    }
}
