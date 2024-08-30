using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityExample.Migrations;

/// <inheritdoc />
public partial class customFields : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<string>(
            name: "firstName",
            table: "AspNetUsers",
            type: "TEXT",
            nullable: false,
            defaultValue: "");

        migrationBuilder.AddColumn<string>(
            name: "lastName",
            table: "AspNetUsers",
            type: "TEXT",
            nullable: false,
            defaultValue: "");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "firstName",
            table: "AspNetUsers");

        migrationBuilder.DropColumn(
            name: "lastName",
            table: "AspNetUsers");
    }
}
