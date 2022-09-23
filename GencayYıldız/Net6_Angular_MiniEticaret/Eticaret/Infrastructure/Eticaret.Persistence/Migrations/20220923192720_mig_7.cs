using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaret.Persistence.Migrations
{
    public partial class mig_7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProductImageFile_Products_ProductId",
                table: "ProductProductImageFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductProductImageFile",
                table: "ProductProductImageFile");

            migrationBuilder.DropIndex(
                name: "IX_ProductProductImageFile_ProductImageFilesId",
                table: "ProductProductImageFile");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductProductImageFile",
                newName: "ProductsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductProductImageFile",
                table: "ProductProductImageFile",
                columns: new[] { "ProductImageFilesId", "ProductsId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductImageFile_ProductsId",
                table: "ProductProductImageFile",
                column: "ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProductImageFile_Products_ProductsId",
                table: "ProductProductImageFile",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProductImageFile_Products_ProductsId",
                table: "ProductProductImageFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductProductImageFile",
                table: "ProductProductImageFile");

            migrationBuilder.DropIndex(
                name: "IX_ProductProductImageFile_ProductsId",
                table: "ProductProductImageFile");

            migrationBuilder.RenameColumn(
                name: "ProductsId",
                table: "ProductProductImageFile",
                newName: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductProductImageFile",
                table: "ProductProductImageFile",
                columns: new[] { "ProductId", "ProductImageFilesId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductImageFile_ProductImageFilesId",
                table: "ProductProductImageFile",
                column: "ProductImageFilesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProductImageFile_Products_ProductId",
                table: "ProductProductImageFile",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
