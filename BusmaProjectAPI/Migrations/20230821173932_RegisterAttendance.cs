using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusmaProjectAPI.Migrations
{
    /// <inheritdoc />
    public partial class RegisterAttendance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "programmingLanguage",
                table: "Users",
                newName: "ProgrammingLanguage");

            migrationBuilder.AlterColumn<int>(
                name: "ProgrammingLanguage",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginAttendance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LogoutAttendance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StateAttendance = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendances_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProgrammingLanguage",
                table: "Users",
                column: "ProgrammingLanguage",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_UserId",
                table: "Attendances",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropIndex(
                name: "IX_Users_ProgrammingLanguage",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "ProgrammingLanguage",
                table: "Users",
                newName: "programmingLanguage");

            migrationBuilder.AlterColumn<string>(
                name: "programmingLanguage",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
