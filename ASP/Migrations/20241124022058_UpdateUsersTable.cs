using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.Migrations
{
    public partial class UpdateUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_UserID1",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Reminders_Users_UserID1",
                table: "Reminders");

            migrationBuilder.DropIndex(
                name: "IX_Reminders_UserID1",
                table: "Reminders");

            migrationBuilder.DropIndex(
                name: "IX_Events_UserID1",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Taskks");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Taskks");

            migrationBuilder.DropColumn(
                name: "UserID1",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "UserID1",
                table: "Events");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Reminders",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ReminderID",
                table: "Reminders",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Events",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "EventID",
                table: "Events",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Reminders_UserID",
                table: "Reminders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserID",
                table: "Events",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_UserID",
                table: "Events",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reminders_Users_UserID",
                table: "Reminders",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_UserID",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Reminders_Users_UserID",
                table: "Reminders");

            migrationBuilder.DropIndex(
                name: "IX_Reminders_UserID",
                table: "Reminders");

            migrationBuilder.DropIndex(
                name: "IX_Events_UserID",
                table: "Events");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Taskks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Taskks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Reminders",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "ReminderID",
                table: "Reminders",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "UserID1",
                table: "Reminders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Events",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "EventID",
                table: "Events",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "UserID1",
                table: "Events",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reminders_UserID1",
                table: "Reminders",
                column: "UserID1");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserID1",
                table: "Events",
                column: "UserID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_UserID1",
                table: "Events",
                column: "UserID1",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reminders_Users_UserID1",
                table: "Reminders",
                column: "UserID1",
                principalTable: "Users",
                principalColumn: "UserID");
        }
    }
}
