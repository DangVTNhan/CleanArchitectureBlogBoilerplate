using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Persistence.Migrations
{
    public partial class GenericsEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Files",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "LastModified",
                table: "Files",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Files",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Blogs",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "LastModified",
                table: "Blogs",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Blogs",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Accounts",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "LastModified",
                table: "Accounts",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Accounts",
                newName: "CreatedDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Files",
                newName: "LastModified");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Files",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Files",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Blogs",
                newName: "LastModified");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Blogs",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Blogs",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Accounts",
                newName: "LastModified");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Accounts",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Accounts",
                newName: "Created");
        }
    }
}
