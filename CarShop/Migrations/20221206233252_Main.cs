using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarShop.Migrations
{
    /// <inheritdoc />
    public partial class Main : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ads_Cars_CarId",
                table: "Ads");

            migrationBuilder.DropForeignKey(
                name: "FK_Ads_Users_OwnerId",
                table: "Ads");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopCartItem_Cars_CarId",
                table: "ShopCartItem");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_ShopCartItem_CarId",
                table: "ShopCartItem");

            migrationBuilder.DropIndex(
                name: "IX_Ads_CarId",
                table: "Ads");

            migrationBuilder.DropIndex(
                name: "IX_Ads_OwnerId",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "ShopCartItem");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Ads",
                newName: "UserToken");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "Ads",
                newName: "ReleaseYear");

            migrationBuilder.AlterColumn<long>(
                name: "Price",
                table: "ShopCartItem",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "ShopCartItem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ShopCartItem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "ShopCartItem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "ShopCartItem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Ads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Ads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Ads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Ads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Ads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "Price",
                table: "Ads",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Run",
                table: "Ads",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "ShopCartItem");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ShopCartItem");

            migrationBuilder.DropColumn(
                name: "Img",
                table: "ShopCartItem");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "ShopCartItem");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "Run",
                table: "Ads");

            migrationBuilder.RenameColumn(
                name: "UserToken",
                table: "Ads",
                newName: "OwnerId");

            migrationBuilder.RenameColumn(
                name: "ReleaseYear",
                table: "Ads",
                newName: "CarId");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "ShopCartItem",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "ShopCartItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false),
                    Run = table.Column<long>(type: "bigint", nullable: false),
                    UserToken = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopCartItem_CarId",
                table: "ShopCartItem",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_CarId",
                table: "Ads",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_OwnerId",
                table: "Ads",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ads_Cars_CarId",
                table: "Ads",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ads_Users_OwnerId",
                table: "Ads",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCartItem_Cars_CarId",
                table: "ShopCartItem",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
