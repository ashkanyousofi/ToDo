using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToDo.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModify = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhoneNumberIsActive = table.Column<bool>(type: "bit", nullable: false),
                    PlanCount = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModify = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsNotification = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModify = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plans_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModify = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_Id",
                        column: x => x.Id,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateDate", "Description", "IsActive", "IsDelete", "LastModify", "ParentId", "Title" },
                values: new object[,]
                {
                    { "1", new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(5141), "", true, false, new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(5144), null, "Creator" },
                    { "2", new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(5157), "", true, false, new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(5159), null, "Admin" },
                    { "3", new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(5173), "", true, false, new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(5186), null, "User" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "CreateDate", "Email", "FirstName", "IsActive", "IsDelete", "LastModify", "LastName", "PhoneNumber", "PhoneNumberIsActive", "PlanCount" },
                values: new object[,]
                {
                    { "1", new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7368), new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7374), "Test@test.com", "Test", true, false, new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7376), "Test", "09100000000", true, 3L },
                    { "2", new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7389), new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7392), "Test2@test.com", "Test2", true, false, new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7394), "Test2", "09110000000", true, 0L },
                    { "3", new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7405), new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7408), "Test3@test.com", "Test3", true, false, new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7410), "Test3", "09120000000", true, 0L }
                });

            migrationBuilder.InsertData(
                table: "Plans",
                columns: new[] { "Id", "CreateDate", "Description", "IsActive", "IsDelete", "IsNotification", "LastModify", "Time", "Title", "UserId" },
                values: new object[,]
                {
                    { "1", new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2547), "", true, false, true, new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2549), new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2560), "School", "1" },
                    { "2", new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2595), "", true, false, true, new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2601), new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2604), "School2", "1" },
                    { "3", new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2637), "", true, false, true, new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2639), new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2642), "School3", "1" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId", "CreateDate", "Id", "IsActive", "IsDelete", "LastModify" },
                values: new object[,]
                {
                    { "1", "1", new DateTime(2023, 6, 22, 6, 56, 11, 562, DateTimeKind.Local).AddTicks(9517), "1", true, false, new DateTime(2023, 6, 22, 6, 56, 11, 562, DateTimeKind.Local).AddTicks(9519) },
                    { "2", "1", new DateTime(2023, 6, 22, 6, 56, 11, 562, DateTimeKind.Local).AddTicks(9532), "1", true, false, new DateTime(2023, 6, 22, 6, 56, 11, 562, DateTimeKind.Local).AddTicks(9535) },
                    { "3", "1", new DateTime(2023, 6, 22, 6, 56, 11, 562, DateTimeKind.Local).AddTicks(9545), "1", true, false, new DateTime(2023, 6, 22, 6, 56, 11, 562, DateTimeKind.Local).AddTicks(9548) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_Id",
                table: "UserRoles",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
