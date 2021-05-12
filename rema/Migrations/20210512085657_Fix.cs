using Microsoft.EntityFrameworkCore.Migrations;

namespace rema.Migrations
{
    public partial class Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_categoryID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Supplier_SupplierID",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Supplier",
                newName: "SupplierID");

            migrationBuilder.RenameColumn(
                name: "categoryID",
                table: "Product",
                newName: "CategoryID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Product",
                newName: "ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_categoryID",
                table: "Product",
                newName: "IX_Product_CategoryID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Category",
                newName: "CategoryID");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SupplierID",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryID",
                table: "Product",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Supplier_SupplierID",
                table: "Product",
                column: "SupplierID",
                principalTable: "Supplier",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Supplier_SupplierID",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "SupplierID",
                table: "Supplier",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Product",
                newName: "categoryID");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Product",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CategoryID",
                table: "Product",
                newName: "IX_Product_categoryID");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Category",
                newName: "ID");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierID",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "categoryID",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_categoryID",
                table: "Product",
                column: "categoryID",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Supplier_SupplierID",
                table: "Product",
                column: "SupplierID",
                principalTable: "Supplier",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
